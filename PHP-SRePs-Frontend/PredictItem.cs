using PHP_SRePS_Backend;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Grpc.Core;
using System.Linq;
using System.Runtime.InteropServices;
using ScottPlot.Statistics;
using ScottPlot;

namespace PHP_SRePS_Frontend
{
    public partial class PredictItem : Form
    {
        ReportMenu menuForm;
        LinearRegressionLine model;
        List<double> dataX;
        List<double> dataY;

        public PredictItem(ReportMenu form)
        {
            InitializeComponent();
            _ = Gprc_channel_instance.GetInstance();
            menuForm = form;

            dataX = new List<double>();
            dataY = new List<double>();

        }

        private async void btnGo_Click(object sender, EventArgs e)
        {
            var client = Gprc_channel_instance.ReportClient;

            var input = new LinearGet
            {
                DateInfo = new DateGet
                {
                    Month = int.Parse(txtMonth.Text.Trim()),
                    Year = int.Parse(txtYear.Text.Trim())
                },
                ItemId = uint.Parse(txtItemID.Text.Trim())
            };

            var reply = await client.GetPredictionReportAsync(input);

            dataY.AddRange(reply.Sales);

            for (int i = 0; i < dataY.Count; i++)
            {
                dataX.Add(i);
            }

            List<double> Sales_list = new List<double>();


            Console.WriteLine(dataY.Count);
            Console.WriteLine(dataX.Count);

            this.model = new ScottPlot.Statistics.LinearRegressionLine(dataX.ToArray(), dataY.ToArray());
            var slope = model.slope;

            var offset = model.offset;
            var pearsonsquared = model.rSquared;

            predictGraph.plt.Title($"Y = {model.slope:0.0000}x + {model.offset:0.0}\nR² = {model.rSquared:0.0000}");
            predictGraph.plt.XLabel("Days");
            predictGraph.plt.YLabel("Sales");
            predictGraph.plt.PlotScatter(dataX.ToArray(), dataY.ToArray());

            predictGraph.plt.PlotLine(model.slope, model.offset, (dataX[0], dataX[dataX.Count - 1]), lineWidth: 2);
            predictGraph.plt.AxisAuto();
            predictGraph.Render();

        }

        private void btnPredict_Click(object sender, EventArgs e)
        {
            var days = int.Parse(txtDaysAhead.Text.Trim());

            lblVal.Text = $"{Math.Round(double.Parse($"{model.slope:0.0000}") * (dataX[dataX.Count - 1] + days) + double.Parse($"{model.offset}")):0} sales";

            List<double> dataX2 = new List<double>();
            dataX2.Add(dataX[dataX.Count - 1]);
            dataX2.Add(dataX[dataX.Count - 1] + days);
            List<double> dataY2 = new List<double>();
            dataY2.Add(dataY[dataY.Count - 1]);
            dataY2.Add(((dataX[dataX.Count - 1] + days) * model.slope) + model.offset);
            predictGraph.plt.PlotScatter(dataX2.ToArray(), dataY2.ToArray(), markerSize: 7, markerShape: MarkerShape.filledSquare);
            predictGraph.plt.AxisAuto();
            predictGraph.Render();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            menuForm.Show();
            this.Close();
        }
    }
}

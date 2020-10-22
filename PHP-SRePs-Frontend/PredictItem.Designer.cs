namespace PHP_SRePS_Frontend
{
    partial class PredictItem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.predictGraph = new ScottPlot.FormsPlot();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGo = new System.Windows.Forms.Button();
            this.txtMonth = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtItemID = new System.Windows.Forms.TextBox();
            this.txtDaysAhead = new System.Windows.Forms.TextBox();
            this.ys = new System.Windows.Forms.Label();
            this.btnPredict = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblVal = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // predictGraph
            // 
            this.predictGraph.Location = new System.Drawing.Point(177, 12);
            this.predictGraph.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.predictGraph.Name = "predictGraph";
            this.predictGraph.Size = new System.Drawing.Size(610, 474);
            this.predictGraph.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter month(1-12)";
            // 
            // btnGo
            // 
            this.btnGo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGo.Location = new System.Drawing.Point(13, 286);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(138, 38);
            this.btnGo.TabIndex = 2;
            this.btnGo.Text = "GO";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // txtMonth
            // 
            this.txtMonth.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMonth.Location = new System.Drawing.Point(12, 84);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(139, 33);
            this.txtMonth.TabIndex = 3;
            // 
            // txtYear
            // 
            this.txtYear.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtYear.Location = new System.Drawing.Point(12, 151);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(139, 33);
            this.txtYear.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Year";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Item ID";
            // 
            // txtItemID
            // 
            this.txtItemID.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtItemID.Location = new System.Drawing.Point(13, 225);
            this.txtItemID.Name = "txtItemID";
            this.txtItemID.Size = new System.Drawing.Size(139, 33);
            this.txtItemID.TabIndex = 3;
            // 
            // txtDaysAhead
            // 
            this.txtDaysAhead.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDaysAhead.Location = new System.Drawing.Point(11, 362);
            this.txtDaysAhead.Name = "txtDaysAhead";
            this.txtDaysAhead.Size = new System.Drawing.Size(139, 33);
            this.txtDaysAhead.TabIndex = 3;
            // 
            // ys
            // 
            this.ys.AutoSize = true;
            this.ys.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ys.Location = new System.Drawing.Point(11, 338);
            this.ys.Name = "ys";
            this.ys.Size = new System.Drawing.Size(92, 21);
            this.ys.TabIndex = 1;
            this.ys.Text = "Days Ahead";
            // 
            // btnPredict
            // 
            this.btnPredict.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPredict.Location = new System.Drawing.Point(11, 401);
            this.btnPredict.Name = "btnPredict";
            this.btnPredict.Size = new System.Drawing.Size(138, 38);
            this.btnPredict.TabIndex = 2;
            this.btnPredict.Text = "Predict";
            this.btnPredict.UseVisualStyleBackColor = true;
            this.btnPredict.Click += new System.EventHandler(this.btnPredict_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(11, 455);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 30);
            this.label4.TabIndex = 4;
            this.label4.Text = "Prediction:";
            // 
            // lblVal
            // 
            this.lblVal.AutoSize = true;
            this.lblVal.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblVal.Location = new System.Drawing.Point(128, 455);
            this.lblVal.Name = "lblVal";
            this.lblVal.Size = new System.Drawing.Size(0, 30);
            this.lblVal.TabIndex = 5;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(11, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(96, 39);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "<--";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // PredictItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 498);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblVal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnPredict);
            this.Controls.Add(this.ys);
            this.Controls.Add(this.txtDaysAhead);
            this.Controls.Add(this.txtItemID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtMonth);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.predictGraph);
            this.Name = "PredictItem";
            this.Text = "PredictItem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ScottPlot.FormsPlot predictGraph;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button b;
        private System.Windows.Forms.TextBox txtMonth;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtItemID;
        private System.Windows.Forms.TextBox Yearh;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.TextBox txtDaysAhead;
        private System.Windows.Forms.Label ys;
        private System.Windows.Forms.Button btnPredict;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblVal;
        private System.Windows.Forms.Button btnBack;
    }
}
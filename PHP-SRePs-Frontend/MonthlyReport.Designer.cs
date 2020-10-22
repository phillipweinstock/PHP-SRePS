namespace PHP_SRePS_Frontend
{
    partial class MonthlyReport
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
            this.btnCSV = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMonth = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.itemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemQtySold = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemRevenue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgSalesReport = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dvgSalesReport)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCSV
            // 
            this.btnCSV.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCSV.Location = new System.Drawing.Point(390, 411);
            this.btnCSV.Name = "btnCSV";
            this.btnCSV.Size = new System.Drawing.Size(138, 47);
            this.btnCSV.TabIndex = 0;
            this.btnCSV.Text = "Generate CSV File";
            this.btnCSV.UseVisualStyleBackColor = true;
            this.btnCSV.Click += new System.EventHandler(this.btnCSV_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Search by Name:";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(202, 99);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(326, 39);
            this.textBox2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 408);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "Total Revenue:";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotalPrice.Location = new System.Drawing.Point(183, 408);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(116, 32);
            this.lblTotalPrice.TabIndex = 7;
            this.lblTotalPrice.Text = "TotalPrice";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(11, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 32);
            this.label5.TabIndex = 1;
            this.label5.Text = "Date:";
            // 
            // txtMonth
            // 
            this.txtMonth.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMonth.Location = new System.Drawing.Point(81, 58);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(168, 35);
            this.txtMonth.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(103, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "month (1-12)";
            // 
            // txtYear
            // 
            this.txtYear.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtYear.Location = new System.Drawing.Point(255, 58);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(156, 35);
            this.txtYear.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(315, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "year";
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGenerateReport.Location = new System.Drawing.Point(417, 58);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(111, 35);
            this.btnGenerateReport.TabIndex = 9;
            this.btnGenerateReport.Text = "Generate Report";
            this.btnGenerateReport.UseVisualStyleBackColor = true;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBack.Location = new System.Drawing.Point(2, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(78, 39);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "<--";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // itemID
            // 
            this.itemID.HeaderText = "ID";
            this.itemID.Name = "itemID";
            this.itemID.ReadOnly = true;
            this.itemID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.itemID.Width = 50;
            // 
            // itemName
            // 
            this.itemName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.itemName.HeaderText = "Name";
            this.itemName.Name = "itemName";
            this.itemName.ReadOnly = true;
            this.itemName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // itemQtySold
            // 
            this.itemQtySold.HeaderText = "Quantity Sold";
            this.itemQtySold.Name = "itemQtySold";
            this.itemQtySold.ReadOnly = true;
            this.itemQtySold.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.itemQtySold.Width = 120;
            // 
            // itemRevenue
            // 
            this.itemRevenue.HeaderText = "Revenue";
            this.itemRevenue.Name = "itemRevenue";
            this.itemRevenue.ReadOnly = true;
            this.itemRevenue.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // MonthlyReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 466);
            // 
            // dvgSalesReport
            // 
            this.dvgSalesReport.AllowUserToAddRows = false;
            this.dvgSalesReport.AllowUserToDeleteRows = false;
            this.dvgSalesReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgSalesReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemID,
            this.itemName,
            this.itemQtySold,
            this.itemRevenue});
            this.dvgSalesReport.Location = new System.Drawing.Point(11, 147);
            this.dvgSalesReport.Name = "dvgSalesReport";
            this.dvgSalesReport.ReadOnly = true;
            this.dvgSalesReport.Size = new System.Drawing.Size(517, 258);
            this.dvgSalesReport.TabIndex = 5;
            this.dvgSalesReport.Text = "dataGridView1";
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnGenerateReport);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMonth);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dvgSalesReport);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCSV);
            this.Name = "MonthlyReport";
            this.Text = "MonthlyReport";
            ((System.ComponentModel.ISupportInitialize)(this.dvgSalesReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCSV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView dvgSalesReport;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMonth;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemQtySold;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemRevenue;
    }
}
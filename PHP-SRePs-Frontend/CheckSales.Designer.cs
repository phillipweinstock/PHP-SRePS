namespace PHP_SRePS_Frontend
{
    partial class CheckSales
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
            this.dgvItemNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgSaleId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTotalBill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSearchDate = new System.Windows.Forms.Label();
            this.txtIDSearch = new System.Windows.Forms.TextBox();
            this.txtNameSearch = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.dgvSalesSearch = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ItemId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgItemInfo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgItemInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvItemNo
            // 
            this.dgvItemNo.HeaderText = "No.";
            this.dgvItemNo.Name = "dgvItemNo";
            // 
            // dvgSaleId
            // 
            this.dvgSaleId.HeaderText = "ID";
            this.dvgSaleId.Name = "dvgSaleId";
            // 
            // dgvTotalBill
            // 
            this.dgvTotalBill.HeaderText = "Total Billed";
            this.dgvTotalBill.Name = "dgvTotalBill";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search by ID :";
            // 
            // lblSearchDate
            // 
            this.lblSearchDate.AutoSize = true;
            this.lblSearchDate.Location = new System.Drawing.Point(12, 105);
            this.lblSearchDate.Name = "lblSearchDate";
            this.lblSearchDate.Size = new System.Drawing.Size(88, 15);
            this.lblSearchDate.TabIndex = 2;
            this.lblSearchDate.Text = "Search by Date:";
            // 
            // txtIDSearch
            // 
            this.txtIDSearch.Location = new System.Drawing.Point(114, 60);
            this.txtIDSearch.Name = "txtIDSearch";
            this.txtIDSearch.Size = new System.Drawing.Size(100, 23);
            this.txtIDSearch.TabIndex = 3;
            // 
            // txtNameSearch
            // 
            this.txtNameSearch.Location = new System.Drawing.Point(114, 102);
            this.txtNameSearch.Name = "txtNameSearch";
            this.txtNameSearch.Size = new System.Drawing.Size(100, 23);
            this.txtNameSearch.TabIndex = 4;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(96, 39);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "<--";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dgvSalesSearch
            // 
            this.dgvSalesSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalesSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvItemNo,
            this.dvgSaleId,
            this.dgvTotalBill});
            this.dgvSalesSearch.Location = new System.Drawing.Point(2, 154);
            this.dgvSalesSearch.Name = "dgvSalesSearch";
            this.dgvSalesSearch.Size = new System.Drawing.Size(343, 284);
            this.dgvSalesSearch.TabIndex = 0;
            this.dgvSalesSearch.Text = "dataGridView1";
            this.dgvSalesSearch.SelectionChanged += new System.EventHandler(this.dgvSalesSearch_SelectionChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Sale Info";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(352, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Item Information For Selected Sale";
            // 
            // ItemId
            // 
            this.ItemId.HeaderText = "Item Id";
            this.ItemId.Name = "ItemId";
            this.ItemId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ItemName
            // 
            this.ItemName.HeaderText = "Item Name";
            this.ItemName.Name = "ItemName";
            this.ItemName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ItemPrice
            // 
            this.ItemPrice.HeaderText = "Item Price";
            this.ItemPrice.Name = "ItemPrice";
            this.ItemPrice.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ItemQuantity
            // 
            this.ItemQuantity.HeaderText = "Quantity";
            this.ItemQuantity.Name = "ItemQuantity";
            this.ItemQuantity.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // CheckSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 463);
            // 
            // dvgItemInfo
            // 
            this.dvgItemInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgItemInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemId,
            this.ItemName,
            this.ItemPrice,
            this.ItemQuantity});
            this.dvgItemInfo.Location = new System.Drawing.Point(352, 154);
            this.dvgItemInfo.Name = "dvgItemInfo";
            this.dvgItemInfo.Size = new System.Drawing.Size(447, 284);
            this.dvgItemInfo.TabIndex = 6;
            this.dvgItemInfo.Text = "dataGridView1";
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dvgItemInfo);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtNameSearch);
            this.Controls.Add(this.txtIDSearch);
            this.Controls.Add(this.lblSearchDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvSalesSearch);
            this.Name = "CheckSales";
            this.Text = "CheckSales";
            this.Load += new System.EventHandler(this.CheckSales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgItemInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn dgvItemNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgSaleId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTotalBill;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSearchDate;
        private System.Windows.Forms.TextBox txtIDSearch;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dgvSalesSearch;
        private System.Windows.Forms.TextBox txtNameSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dvgItemInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemQuantity;
    }
}
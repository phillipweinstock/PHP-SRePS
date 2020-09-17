namespace PHP_SRePS_Frontend
{
    partial class AddSalesRecord
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
            this.amtSold = new System.Windows.Forms.TextBox();
            this.AmtSoldLbl = new System.Windows.Forms.Label();
            this.btnAddSale = new System.Windows.Forms.Button();
            this.btnRemoveSale = new System.Windows.Forms.Button();
            this.submitRecordBtn = new System.Windows.Forms.Button();
            this.itmIDTxt = new System.Windows.Forms.TextBox();
            this.itmIDLbl = new System.Windows.Forms.Label();
            this.btnNewItem = new System.Windows.Forms.Button();
            this.dgvID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSold = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesRecordView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.salesRecordView)).BeginInit();
            this.SuspendLayout();
            // 
            // amtSold
            // 
            this.amtSold.Location = new System.Drawing.Point(276, 13);
            this.amtSold.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.amtSold.Name = "amtSold";
            this.amtSold.Size = new System.Drawing.Size(88, 23);
            this.amtSold.TabIndex = 1;
            // 
            // AmtSoldLbl
            // 
            this.AmtSoldLbl.AutoSize = true;
            this.AmtSoldLbl.Location = new System.Drawing.Point(191, 16);
            this.AmtSoldLbl.Name = "AmtSoldLbl";
            this.AmtSoldLbl.Size = new System.Drawing.Size(62, 15);
            this.AmtSoldLbl.TabIndex = 6;
            this.AmtSoldLbl.Text = "Stock Sold";
            // 
            // btnAddSale
            // 
            this.btnAddSale.Location = new System.Drawing.Point(552, 59);
            this.btnAddSale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddSale.Name = "btnAddSale";
            this.btnAddSale.Size = new System.Drawing.Size(100, 28);
            this.btnAddSale.TabIndex = 7;
            this.btnAddSale.Text = "Add Sale";
            this.btnAddSale.UseVisualStyleBackColor = true;
            this.btnAddSale.Click += new System.EventHandler(this.AddItemBtn_Click);
            // 
            // btnRemoveSale
            // 
            this.btnRemoveSale.Location = new System.Drawing.Point(552, 104);
            this.btnRemoveSale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemoveSale.Name = "btnRemoveSale";
            this.btnRemoveSale.Size = new System.Drawing.Size(100, 28);
            this.btnRemoveSale.TabIndex = 9;
            this.btnRemoveSale.Text = "Remove Sale";
            this.btnRemoveSale.UseVisualStyleBackColor = true;
            this.btnRemoveSale.Click += new System.EventHandler(this.RemoveItemBtn_Click);
            // 
            // submitRecordBtn
            // 
            this.submitRecordBtn.Location = new System.Drawing.Point(552, 236);
            this.submitRecordBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.submitRecordBtn.Name = "submitRecordBtn";
            this.submitRecordBtn.Size = new System.Drawing.Size(100, 28);
            this.submitRecordBtn.TabIndex = 10;
            this.submitRecordBtn.Text = "Submit Record";
            this.submitRecordBtn.UseVisualStyleBackColor = true;
            // 
            // itmIDTxt
            // 
            this.itmIDTxt.Location = new System.Drawing.Point(75, 13);
            this.itmIDTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.itmIDTxt.Name = "itmIDTxt";
            this.itmIDTxt.Size = new System.Drawing.Size(88, 23);
            this.itmIDTxt.TabIndex = 11;
            // 
            // itmIDLbl
            // 
            this.itmIDLbl.AutoSize = true;
            this.itmIDLbl.Location = new System.Drawing.Point(11, 16);
            this.itmIDLbl.Name = "itmIDLbl";
            this.itmIDLbl.Size = new System.Drawing.Size(45, 15);
            this.itmIDLbl.TabIndex = 12;
            this.itmIDLbl.Text = "Item ID";
            // 
            // btnNewItem
            // 
            this.btnNewItem.Location = new System.Drawing.Point(531, 8);
            this.btnNewItem.Name = "btnNewItem";
            this.btnNewItem.Size = new System.Drawing.Size(119, 28);
            this.btnNewItem.TabIndex = 13;
            this.btnNewItem.Text = "Create New Item";
            this.btnNewItem.UseVisualStyleBackColor = true;
            // 
            // dgvID
            // 
            this.dgvID.HeaderText = "ID";
            this.dgvID.Name = "dgvID";
            // 
            // dgvName
            // 
            this.dgvName.HeaderText = "Name";
            this.dgvName.Name = "dgvName";
            // 
            // dgvPrice
            // 
            this.dgvPrice.HeaderText = "Price";
            this.dgvPrice.Name = "dgvPrice";
            // 
            // dgvCategory
            // 
            this.dgvCategory.HeaderText = "Category";
            this.dgvCategory.Name = "dgvCategory";
            // 
            // dgvSold
            // 
            this.dgvSold.HeaderText = "Stock Sold";
            this.dgvSold.Name = "dgvSold";
            // 
            // salesRecordView
            // 
            this.salesRecordView.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.salesRecordView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salesRecordView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvID,
            this.dgvName,
            this.dgvPrice,
            this.dgvCategory,
            this.dgvSold});
            this.salesRecordView.Location = new System.Drawing.Point(3, 59);
            this.salesRecordView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.salesRecordView.Name = "salesRecordView";
            this.salesRecordView.Size = new System.Drawing.Size(543, 206);
            this.salesRecordView.TabIndex = 8;
            this.salesRecordView.Text = "dataGridView1";
            // 
            // AddSalesRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 280);
            this.Controls.Add(this.btnNewItem);
            this.Controls.Add(this.itmIDLbl);
            this.Controls.Add(this.itmIDTxt);
            this.Controls.Add(this.submitRecordBtn);
            this.Controls.Add(this.btnRemoveSale);
            this.Controls.Add(this.salesRecordView);
            this.Controls.Add(this.btnAddSale);
            this.Controls.Add(this.AmtSoldLbl);
            this.Controls.Add(this.amtSold);
            this.Name = "AddSalesRecord";
            this.Text = "Add Sales Record";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.salesRecordView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox amtSold;
        private System.Windows.Forms.Label AmtSoldLbl;
        private System.Windows.Forms.Button btnAddSale;
        private System.Windows.Forms.DataGridView salesRecordView;
        private System.Windows.Forms.Button btnRemoveSale;
        private System.Windows.Forms.Button submitRecordBtn;
        private System.Windows.Forms.TextBox itmIDTxt;
        private System.Windows.Forms.Label itmIDLbl;
        private System.Windows.Forms.Button btnNewItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSold;
    }
}
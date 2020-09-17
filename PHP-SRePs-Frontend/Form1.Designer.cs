namespace PHP_SRePS_Frontend
{
    partial class Home
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
            this.price = new System.Windows.Forms.TextBox();
            this.itmName = new System.Windows.Forms.TextBox();
            this.ItemNameLbl = new System.Windows.Forms.Label();
            this.PriceLbl = new System.Windows.Forms.Label();
            this.AmtSoldLbl = new System.Windows.Forms.Label();
            this.addItemBtn = new System.Windows.Forms.Button();
            this.removeItemBtn = new System.Windows.Forms.Button();
            this.submitRecordBtn = new System.Windows.Forms.Button();
            this.itmID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itmPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numSold = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itmIDTxt = new System.Windows.Forms.TextBox();
            this.itmIDLbl = new System.Windows.Forms.Label();
            this.salesRecordView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.salesRecordView)).BeginInit();
            this.SuspendLayout();
            // 
            // amtSold
            // 
            this.amtSold.Location = new System.Drawing.Point(120, 101);
            this.amtSold.Name = "amtSold";
            this.amtSold.Size = new System.Drawing.Size(100, 23);
            this.amtSold.TabIndex = 1;
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(120, 56);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(100, 23);
            this.price.TabIndex = 2;
            // 
            // itmName
            // 
            this.itmName.Location = new System.Drawing.Point(329, 12);
            this.itmName.Multiline = true;
            this.itmName.Name = "itmName";
            this.itmName.Size = new System.Drawing.Size(198, 23);
            this.itmName.TabIndex = 3;
            // 
            // ItemNameLbl
            // 
            this.ItemNameLbl.AutoSize = true;
            this.ItemNameLbl.Location = new System.Drawing.Point(240, 15);
            this.ItemNameLbl.Name = "ItemNameLbl";
            this.ItemNameLbl.Size = new System.Drawing.Size(66, 15);
            this.ItemNameLbl.TabIndex = 4;
            this.ItemNameLbl.Text = "Item Name";
            // 
            // PriceLbl
            // 
            this.PriceLbl.AutoSize = true;
            this.PriceLbl.Location = new System.Drawing.Point(14, 59);
            this.PriceLbl.Name = "PriceLbl";
            this.PriceLbl.Size = new System.Drawing.Size(33, 15);
            this.PriceLbl.TabIndex = 5;
            this.PriceLbl.Text = "Price";
            // 
            // AmtSoldLbl
            // 
            this.AmtSoldLbl.AutoSize = true;
            this.AmtSoldLbl.Location = new System.Drawing.Point(14, 104);
            this.AmtSoldLbl.Name = "AmtSoldLbl";
            this.AmtSoldLbl.Size = new System.Drawing.Size(77, 15);
            this.AmtSoldLbl.TabIndex = 6;
            this.AmtSoldLbl.Text = "Amount Sold";
            // 
            // addItemBtn
            // 
            this.addItemBtn.Location = new System.Drawing.Point(466, 176);
            this.addItemBtn.Name = "addItemBtn";
            this.addItemBtn.Size = new System.Drawing.Size(114, 38);
            this.addItemBtn.TabIndex = 7;
            this.addItemBtn.Text = "Add Item";
            this.addItemBtn.UseVisualStyleBackColor = true;
            this.addItemBtn.Click += new System.EventHandler(this.addItemBtn_Click);
            // 
            // removeItemBtn
            // 
            this.removeItemBtn.Location = new System.Drawing.Point(466, 269);
            this.removeItemBtn.Name = "removeItemBtn";
            this.removeItemBtn.Size = new System.Drawing.Size(114, 38);
            this.removeItemBtn.TabIndex = 9;
            this.removeItemBtn.Text = "Remove Item";
            this.removeItemBtn.UseVisualStyleBackColor = true;
            this.removeItemBtn.Click += new System.EventHandler(this.removeItemBtn_Click);
            // 
            // submitRecordBtn
            // 
            this.submitRecordBtn.Location = new System.Drawing.Point(466, 370);
            this.submitRecordBtn.Name = "submitRecordBtn";
            this.submitRecordBtn.Size = new System.Drawing.Size(114, 38);
            this.submitRecordBtn.TabIndex = 10;
            this.submitRecordBtn.Text = "Submit Record";
            this.submitRecordBtn.UseVisualStyleBackColor = true;
            // 
            // itmID
            // 
            this.itmID.HeaderText = "ID";
            this.itmID.Name = "itmID";
            // 
            // Name
            // 
            this.Name.HeaderText = "Item Name";
            this.Name.Name = "Name";
            // 
            // itmPrice
            // 
            this.itmPrice.HeaderText = "Price";
            this.itmPrice.Name = "itmPrice";
            // 
            // numSold
            // 
            this.numSold.HeaderText = "Amount Sold";
            this.numSold.Name = "numSold";
            // 
            // itmIDTxt
            // 
            this.itmIDTxt.Location = new System.Drawing.Point(120, 12);
            this.itmIDTxt.Name = "itmIDTxt";
            this.itmIDTxt.Size = new System.Drawing.Size(100, 23);
            this.itmIDTxt.TabIndex = 11;
            // 
            // itmIDLbl
            // 
            this.itmIDLbl.AutoSize = true;
            this.itmIDLbl.Location = new System.Drawing.Point(14, 15);
            this.itmIDLbl.Name = "itmIDLbl";
            this.itmIDLbl.Size = new System.Drawing.Size(45, 15);
            this.itmIDLbl.TabIndex = 12;
            this.itmIDLbl.Text = "Item ID";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 450);
            // 
            // salesRecordView
            // 
            this.salesRecordView.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.salesRecordView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salesRecordView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itmID,
            this.Name,
            this.itmPrice,
            this.numSold});
            this.salesRecordView.Location = new System.Drawing.Point(5, 163);
            this.salesRecordView.Name = "salesRecordView";
            this.salesRecordView.Size = new System.Drawing.Size(445, 275);
            this.salesRecordView.TabIndex = 8;
            this.salesRecordView.Text = "dataGridView1";
            this.Controls.Add(this.itmIDLbl);
            this.Controls.Add(this.itmIDTxt);
            this.Controls.Add(this.submitRecordBtn);
            this.Controls.Add(this.removeItemBtn);
            this.Controls.Add(this.salesRecordView);
            this.Controls.Add(this.addItemBtn);
            this.Controls.Add(this.AmtSoldLbl);
            this.Controls.Add(this.PriceLbl);
            this.Controls.Add(this.ItemNameLbl);
            this.Controls.Add(this.itmName);
            this.Controls.Add(this.price);
            this.Controls.Add(this.amtSold);
            this.Name = "Home";
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.salesRecordView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox amtSold;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.TextBox itmName;
        private System.Windows.Forms.Label ItemNameLbl;
        private System.Windows.Forms.Label PriceLbl;
        private System.Windows.Forms.Label AmtSoldLbl;
        private System.Windows.Forms.Button addItemBtn;
        private System.Windows.Forms.DataGridView salesRecordView;
        private System.Windows.Forms.Button removeItemBtn;
        private System.Windows.Forms.Button submitRecordBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itmID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn itmPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn numSold;
        private System.Windows.Forms.TextBox itmIDTxt;
        private System.Windows.Forms.Label itmIDLbl;
    }
}
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
            this.itemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountSold = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesRecordView = new System.Windows.Forms.DataGridView();
            this.removeItmBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.salesRecordView)).BeginInit();
            this.SuspendLayout();
            // 
            // amtSold
            // 
            this.amtSold.Location = new System.Drawing.Point(123, 118);
            this.amtSold.Name = "amtSold";
            this.amtSold.Size = new System.Drawing.Size(100, 23);
            this.amtSold.TabIndex = 1;
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(123, 73);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(100, 23);
            this.price.TabIndex = 2;
            // 
            // itmName
            // 
            this.itmName.Location = new System.Drawing.Point(123, 26);
            this.itmName.Multiline = true;
            this.itmName.Name = "itmName";
            this.itmName.Size = new System.Drawing.Size(198, 23);
            this.itmName.TabIndex = 3;
            // 
            // ItemNameLbl
            // 
            this.ItemNameLbl.AutoSize = true;
            this.ItemNameLbl.Location = new System.Drawing.Point(17, 29);
            this.ItemNameLbl.Name = "ItemNameLbl";
            this.ItemNameLbl.Size = new System.Drawing.Size(66, 15);
            this.ItemNameLbl.TabIndex = 4;
            this.ItemNameLbl.Text = "Item Name";
            // 
            // PriceLbl
            // 
            this.PriceLbl.AutoSize = true;
            this.PriceLbl.Location = new System.Drawing.Point(17, 76);
            this.PriceLbl.Name = "PriceLbl";
            this.PriceLbl.Size = new System.Drawing.Size(33, 15);
            this.PriceLbl.TabIndex = 5;
            this.PriceLbl.Text = "Price";
            // 
            // AmtSoldLbl
            // 
            this.AmtSoldLbl.AutoSize = true;
            this.AmtSoldLbl.Location = new System.Drawing.Point(17, 121);
            this.AmtSoldLbl.Name = "AmtSoldLbl";
            this.AmtSoldLbl.Size = new System.Drawing.Size(77, 15);
            this.AmtSoldLbl.TabIndex = 6;
            this.AmtSoldLbl.Text = "Amount Sold";
            // 
            // addItemBtn
            // 
            this.addItemBtn.Location = new System.Drawing.Point(355, 163);
            this.addItemBtn.Name = "addItemBtn";
            this.addItemBtn.Size = new System.Drawing.Size(114, 38);
            this.addItemBtn.TabIndex = 7;
            this.addItemBtn.Text = "Add Item";
            this.addItemBtn.UseVisualStyleBackColor = true;
            this.addItemBtn.Click += new System.EventHandler(this.addItemBtn_Click);
            // 
            // itemName
            // 
            this.itemName.HeaderText = "Item Name";
            this.itemName.Name = "itemName";
            this.itemName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // itemPrice
            // 
            this.itemPrice.HeaderText = "Price";
            this.itemPrice.Name = "itemPrice";
            this.itemPrice.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // amountSold
            // 
            this.amountSold.HeaderText = "Amount Sold";
            this.amountSold.Name = "amountSold";
            this.amountSold.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // salesRecordView
            // 
            this.salesRecordView.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.salesRecordView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salesRecordView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemName,
            this.itemPrice,
            this.amountSold});
            this.salesRecordView.Location = new System.Drawing.Point(5, 163);
            this.salesRecordView.Name = "salesRecordView";
            this.salesRecordView.Size = new System.Drawing.Size(344, 275);
            this.salesRecordView.TabIndex = 8;
            this.salesRecordView.Text = "dataGridView1";
            // 
            // removeItmBtn
            // 
            this.removeItmBtn.Location = new System.Drawing.Point(355, 236);
            this.removeItmBtn.Name = "removeItmBtn";
            this.removeItmBtn.Size = new System.Drawing.Size(114, 38);
            this.removeItmBtn.TabIndex = 9;
            this.removeItmBtn.Text = "Remove Item";
            this.removeItmBtn.UseVisualStyleBackColor = true;
            this.removeItmBtn.Click += new System.EventHandler(this.removeItmBtn_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 450);
            this.Controls.Add(this.removeItmBtn);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn itemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountSold;
        private System.Windows.Forms.DataGridView salesRecordView;
        private System.Windows.Forms.Button removeItmBtn;
    }
}
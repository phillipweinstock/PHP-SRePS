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
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSalesNum = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnContinue = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.dgvItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesRecordView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.salesRecordView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(-1, -1);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(108, 39);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "<--";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Sales No:";
            // 
            // lblSalesNum
            // 
            this.lblSalesNum.AutoSize = true;
            this.lblSalesNum.Location = new System.Drawing.Point(201, 11);
            this.lblSalesNum.Name = "lblSalesNum";
            this.lblSalesNum.Size = new System.Drawing.Size(37, 15);
            this.lblSalesNum.TabIndex = 11;
            this.lblSalesNum.Text = "00001";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(279, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Date:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(319, 11);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(65, 15);
            this.lblDate.TabIndex = 13;
            this.lblDate.Text = "22/09/2020";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(427, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Time:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(497, 11);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(51, 15);
            this.lblTime.TabIndex = 15;
            this.lblTime.Text = "11:49am";
            // 
            // btnContinue
            // 
            this.btnContinue.Location = new System.Drawing.Point(455, 297);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(93, 37);
            this.btnContinue.TabIndex = 16;
            this.btnContinue.Text = "Add Sale";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(354, 44);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(95, 37);
            this.btnAddItem.TabIndex = 17;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.Location = new System.Drawing.Point(455, 44);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(93, 37);
            this.btnDeleteItem.TabIndex = 18;
            this.btnDeleteItem.Text = "Delete Item";
            this.btnDeleteItem.UseVisualStyleBackColor = true;
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // dgvItemID
            // 
            this.dgvItemID.Frozen = true;
            this.dgvItemID.HeaderText = "Item ID";
            this.dgvItemID.Name = "dgvItemID";
            this.dgvItemID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dgvName
            // 
            this.dgvName.FillWeight = 200F;
            this.dgvName.Frozen = true;
            this.dgvName.HeaderText = "Item Name";
            this.dgvName.Name = "dgvName";
            this.dgvName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvName.Width = 200;
            // 
            // dgvQuantity
            // 
            this.dgvQuantity.Frozen = true;
            this.dgvQuantity.HeaderText = "Quantity";
            this.dgvQuantity.Name = "dgvQuantity";
            this.dgvQuantity.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dgvPrice
            // 
            this.dgvPrice.HeaderText = "Price";
            this.dgvPrice.Name = "dgvPrice";
            this.dgvPrice.ReadOnly = true;
            this.dgvPrice.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // AddSalesRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 342);
            // 
            // salesRecordView
            // 
            this.salesRecordView.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.salesRecordView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salesRecordView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvItemID,
            this.dgvName,
            this.dgvQuantity,
            this.dgvPrice});
            this.salesRecordView.Location = new System.Drawing.Point(12, 86);
            this.salesRecordView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.salesRecordView.Name = "salesRecordView";
            this.salesRecordView.Size = new System.Drawing.Size(543, 206);
            this.salesRecordView.TabIndex = 8;
            this.salesRecordView.Text = "dataGridView1";
            this.Controls.Add(this.btnDeleteItem);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblSalesNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.salesRecordView);
            this.Name = "AddSalesRecord";
            this.Text = "Add Sales Record";
            ((System.ComponentModel.ISupportInitialize)(this.salesRecordView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView salesRecordView;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSalesNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnDeleteItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPrice;
    }
}
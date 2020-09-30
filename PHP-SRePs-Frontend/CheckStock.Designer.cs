namespace PHP_SRePS_Frontend
{
    partial class CheckStock
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
            this.dgvItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIDSearch = new System.Windows.Forms.TextBox();
            this.txtNameSearch = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.dgvStockSearch = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvItemNo
            // 
            this.dgvItemNo.HeaderText = "No.";
            this.dgvItemNo.Name = "dgvItemNo";
            // 
            // dgvItemID
            // 
            this.dgvItemID.HeaderText = "ID";
            this.dgvItemID.Name = "dgvItemID";
            // 
            // dgvItemName
            // 
            this.dgvItemName.HeaderText = "Name";
            this.dgvItemName.Name = "dgvItemName";
            // 
            // dgvPrice
            // 
            this.dgvPrice.HeaderText = "Price";
            this.dgvPrice.Name = "dgvPrice";
            // 
            // dgvStock
            // 
            this.dgvStock.HeaderText = "Available";
            this.dgvStock.Name = "dgvStock";
            // 
            // dgvCategory
            // 
            this.dgvCategory.HeaderText = "Category";
            this.dgvCategory.Name = "dgvCategory";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Search by Name:";
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
            // CheckStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 450);
            // 
            // dgvStockSearch
            // 
            this.dgvStockSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStockSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvItemNo,
            this.dgvItemID,
            this.dgvItemName,
            this.dgvPrice,
            this.dgvStock,
            this.dgvCategory});
            this.dgvStockSearch.Location = new System.Drawing.Point(2, 154);
            this.dgvStockSearch.Name = "dgvStockSearch";
            this.dgvStockSearch.Size = new System.Drawing.Size(644, 260);
            this.dgvStockSearch.TabIndex = 0;
            this.dgvStockSearch.Text = "dataGridView1";
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtNameSearch);
            this.Controls.Add(this.txtIDSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvStockSearch);
            this.Name = "CheckStock";
            this.Text = "CheckStock";
            this.Load += new System.EventHandler(this.CheckStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn dgvItemNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIDSearch;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dgvStockSearch;
        private System.Windows.Forms.TextBox txtNameSearch;
    }
}
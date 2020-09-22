namespace PHP_SRePS_Frontend
{
    partial class MainMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddSale = new System.Windows.Forms.Button();
            this.btnCheckStock = new System.Windows.Forms.Button();
            this.btnAnalysis = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Elephant", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(135, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(439, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "People\'s Health Pharmacy";
            // 
            // btnAddSale
            // 
            this.btnAddSale.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddSale.Location = new System.Drawing.Point(274, 129);
            this.btnAddSale.Name = "btnAddSale";
            this.btnAddSale.Size = new System.Drawing.Size(158, 48);
            this.btnAddSale.TabIndex = 1;
            this.btnAddSale.Text = "Add Sale";
            this.btnAddSale.UseVisualStyleBackColor = true;
            this.btnAddSale.Click += new System.EventHandler(this.btnAddSale_Click);
            // 
            // btnCheckStock
            // 
            this.btnCheckStock.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCheckStock.Location = new System.Drawing.Point(274, 183);
            this.btnCheckStock.Name = "btnCheckStock";
            this.btnCheckStock.Size = new System.Drawing.Size(158, 48);
            this.btnCheckStock.TabIndex = 2;
            this.btnCheckStock.Text = "Check Stock";
            this.btnCheckStock.UseVisualStyleBackColor = true;
            this.btnCheckStock.Click += new System.EventHandler(this.btnCheckStock_Click);
            // 
            // btnAnalysis
            // 
            this.btnAnalysis.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAnalysis.Location = new System.Drawing.Point(274, 237);
            this.btnAnalysis.Name = "btnAnalysis";
            this.btnAnalysis.Size = new System.Drawing.Size(158, 48);
            this.btnAnalysis.TabIndex = 3;
            this.btnAnalysis.Text = "Analysis";
            this.btnAnalysis.UseVisualStyleBackColor = true;
            this.btnAnalysis.Click += new System.EventHandler(this.btnAnalysis_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogOut.Location = new System.Drawing.Point(274, 291);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(158, 48);
            this.btnLogOut.TabIndex = 4;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 450);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnAnalysis);
            this.Controls.Add(this.btnCheckStock);
            this.Controls.Add(this.btnAddSale);
            this.Controls.Add(this.label1);
            this.Name = "frmMainMenu";
            this.Text = "Main Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddSale;
        private System.Windows.Forms.Button btnCheckStock;
        private System.Windows.Forms.Button btnAnalysis;
        private System.Windows.Forms.Button btnLogOut;
    }
}
namespace PHP_SRePS_Frontend
{
    partial class Payment
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
            this.btnCash = new System.Windows.Forms.Button();
            this.btnCard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCash
            // 
            this.btnCash.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCash.Location = new System.Drawing.Point(47, 30);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(134, 55);
            this.btnCash.TabIndex = 0;
            this.btnCash.Text = "Cash";
            this.btnCash.UseVisualStyleBackColor = true;
            this.btnCash.Click += new System.EventHandler(this.btnCash_Click);
            // 
            // btnCard
            // 
            this.btnCard.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCard.Location = new System.Drawing.Point(47, 122);
            this.btnCard.Name = "btnCard";
            this.btnCard.Size = new System.Drawing.Size(134, 55);
            this.btnCard.TabIndex = 1;
            this.btnCard.Text = "Card";
            this.btnCard.UseVisualStyleBackColor = true;
            this.btnCard.Click += new System.EventHandler(this.btnCard_Click);
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 213);
            this.Controls.Add(this.btnCard);
            this.Controls.Add(this.btnCash);
            this.Name = "Payment";
            this.Text = "Payment";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCash;
        private System.Windows.Forms.Button btnCard;
    }
}
﻿namespace PHP_SRePS_Frontend
{
    partial class ReportMenu
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
            this.btnMonthly = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnPredictSales = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Elephant", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(181, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(439, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "People\'s Health Pharmacy";
            // 
            // btnMonthly
            // 
            this.btnMonthly.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMonthly.Location = new System.Drawing.Point(262, 124);
            this.btnMonthly.Name = "btnMonthly";
            this.btnMonthly.Size = new System.Drawing.Size(270, 48);
            this.btnMonthly.TabIndex = 2;
            this.btnMonthly.Text = "Display Monthly Sales";
            this.btnMonthly.UseVisualStyleBackColor = true;
            this.btnMonthly.Click += new System.EventHandler(this.btnMonthly_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBack.Location = new System.Drawing.Point(343, 346);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(109, 48);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnPredictSales
            // 
            this.btnPredictSales.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPredictSales.Location = new System.Drawing.Point(262, 178);
            this.btnPredictSales.Name = "btnPredictSales";
            this.btnPredictSales.Size = new System.Drawing.Size(270, 48);
            this.btnPredictSales.TabIndex = 2;
            this.btnPredictSales.Text = "Predict Sales";
            this.btnPredictSales.UseVisualStyleBackColor = true;
            this.btnPredictSales.Click += new System.EventHandler(this.btnPredictSales_Click);
            // 
            // ReportMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPredictSales);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnMonthly);
            this.Controls.Add(this.label1);
            this.Name = "ReportMenu";
            this.Text = "ReportMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMonthly;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnPredictSales;
    }
}
﻿namespace PHP_SRePS_Frontend
{
    partial class ConfirmPayment
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtAmtPaid = new System.Windows.Forms.TextBox();
            this.txtBalDue = new System.Windows.Forms.TextBox();
            this.btnChangeOption = new System.Windows.Forms.Button();
            this.btnContinue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Amount Paid";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Balance Due";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(142, 33);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 23);
            this.txtTotal.TabIndex = 3;
            // 
            // txtAmtPaid
            // 
            this.txtAmtPaid.Location = new System.Drawing.Point(142, 86);
            this.txtAmtPaid.Name = "txtAmtPaid";
            this.txtAmtPaid.Size = new System.Drawing.Size(100, 23);
            this.txtAmtPaid.TabIndex = 4;
            // 
            // txtBalDue
            // 
            this.txtBalDue.Location = new System.Drawing.Point(142, 141);
            this.txtBalDue.Name = "txtBalDue";
            this.txtBalDue.Size = new System.Drawing.Size(100, 23);
            this.txtBalDue.TabIndex = 5;
            // 
            // btnChangeOption
            // 
            this.btnChangeOption.Location = new System.Drawing.Point(12, 177);
            this.btnChangeOption.Name = "btnChangeOption";
            this.btnChangeOption.Size = new System.Drawing.Size(114, 42);
            this.btnChangeOption.TabIndex = 6;
            this.btnChangeOption.Text = "Change Payment Option";
            this.btnChangeOption.UseVisualStyleBackColor = true;
            // 
            // btnContinue
            // 
            this.btnContinue.Location = new System.Drawing.Point(205, 177);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(105, 42);
            this.btnContinue.TabIndex = 7;
            this.btnContinue.Text = "Continue";
            this.btnContinue.UseVisualStyleBackColor = true;
            // 
            // ConfirmPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 231);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.btnChangeOption);
            this.Controls.Add(this.txtBalDue);
            this.Controls.Add(this.txtAmtPaid);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ConfirmPayment";
            this.Text = "ConfirmPayment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtAmtPaid;
        private System.Windows.Forms.TextBox txtBalDue;
        private System.Windows.Forms.Button btnChangeOption;
        private System.Windows.Forms.Button btnContinue;
    }
}
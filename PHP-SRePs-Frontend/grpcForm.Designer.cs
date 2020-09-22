namespace PHP_SRePS_Frontend
{
    partial class grpcForm
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
            this.txtPortNo = new System.Windows.Forms.TextBox();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.lblPortNo = new System.Windows.Forms.Label();
            this.lblURL = new System.Windows.Forms.Label();
            this.btnSaveTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPortNo
            // 
            this.txtPortNo.Location = new System.Drawing.Point(95, 17);
            this.txtPortNo.Name = "txtPortNo";
            this.txtPortNo.Size = new System.Drawing.Size(119, 23);
            this.txtPortNo.TabIndex = 0;
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(47, 69);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(167, 23);
            this.txtURL.TabIndex = 1;
            // 
            // lblPortNo
            // 
            this.lblPortNo.AutoSize = true;
            this.lblPortNo.Location = new System.Drawing.Point(13, 20);
            this.lblPortNo.Name = "lblPortNo";
            this.lblPortNo.Size = new System.Drawing.Size(76, 15);
            this.lblPortNo.TabIndex = 3;
            this.lblPortNo.Text = "Port Number";
            // 
            // lblURL
            // 
            this.lblURL.AutoSize = true;
            this.lblURL.Location = new System.Drawing.Point(13, 72);
            this.lblURL.Name = "lblURL";
            this.lblURL.Size = new System.Drawing.Size(28, 15);
            this.lblURL.TabIndex = 4;
            this.lblURL.Text = "URL";
            // 
            // btnSaveTest
            // 
            this.btnSaveTest.Location = new System.Drawing.Point(119, 118);
            this.btnSaveTest.Name = "btnSaveTest";
            this.btnSaveTest.Size = new System.Drawing.Size(95, 32);
            this.btnSaveTest.TabIndex = 5;
            this.btnSaveTest.Text = "Save and Test";
            this.btnSaveTest.UseVisualStyleBackColor = true;
            this.btnSaveTest.Click += new System.EventHandler(this.btnSaveTest_Click);
            // 
            // grpcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 162);
            this.Controls.Add(this.btnSaveTest);
            this.Controls.Add(this.lblURL);
            this.Controls.Add(this.lblPortNo);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.txtPortNo);
            this.Name = "grpcForm";
            this.Text = "grpc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPortNo;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Label lblPortNo;
        private System.Windows.Forms.Label lblURL;
        private System.Windows.Forms.Button btnSaveTest;
    }
}

namespace GerProtocol
{
    partial class FrmGerProtocols
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        [System.Obsolete]
        private void InitializeComponent()
        {
            this.BtnConfigTLS12 = new System.Windows.Forms.Button();
            this.BtnConfigDefault = new System.Windows.Forms.Button();
            this.BtnConfigTLS13 = new System.Windows.Forms.Button();
            this.BtnConfigSSL3 = new System.Windows.Forms.Button();
            this.BtnTestarTLS12 = new System.Windows.Forms.Button();
            this.BtnConfigTLS11 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnConfigTLS12
            // 
            this.BtnConfigTLS12.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.BtnConfigTLS12.Location = new System.Drawing.Point(12, 12);
            this.BtnConfigTLS12.Name = "BtnConfigTLS12";
            this.BtnConfigTLS12.Size = new System.Drawing.Size(64, 23);
            this.BtnConfigTLS12.TabIndex = 0;
            this.BtnConfigTLS12.Text = "TLS 1.2";
            this.BtnConfigTLS12.UseVisualStyleBackColor = true;
            this.BtnConfigTLS12.Click += new System.EventHandler(this.BtnConfigTLS12_Click);
            // 
            // BtnConfigDefault
            // 
            this.BtnConfigDefault.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.BtnConfigDefault.Location = new System.Drawing.Point(12, 70);
            this.BtnConfigDefault.Name = "BtnConfigDefault";
            this.BtnConfigDefault.Size = new System.Drawing.Size(64, 23);
            this.BtnConfigDefault.TabIndex = 4;
            this.BtnConfigDefault.Text = "Default";
            this.BtnConfigDefault.UseVisualStyleBackColor = true;
            this.BtnConfigDefault.Click += new System.EventHandler(this.BtnConfigDefault_Click);
            // 
            // BtnConfigTLS13
            // 
            this.BtnConfigTLS13.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.BtnConfigTLS13.Location = new System.Drawing.Point(12, 41);
            this.BtnConfigTLS13.Name = "BtnConfigTLS13";
            this.BtnConfigTLS13.Size = new System.Drawing.Size(64, 23);
            this.BtnConfigTLS13.TabIndex = 2;
            this.BtnConfigTLS13.Text = "TLS 1.3";
            this.BtnConfigTLS13.UseVisualStyleBackColor = true;
            this.BtnConfigTLS13.Click += new System.EventHandler(this.BtnConfigTLS13_Click);
            // 
            // BtnConfigSSL3
            // 
            this.BtnConfigSSL3.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.BtnConfigSSL3.Location = new System.Drawing.Point(82, 41);
            this.BtnConfigSSL3.Name = "BtnConfigSSL3";
            this.BtnConfigSSL3.Size = new System.Drawing.Size(64, 23);
            this.BtnConfigSSL3.TabIndex = 3;
            this.BtnConfigSSL3.Text = "SSL 3.0";
            this.BtnConfigSSL3.UseVisualStyleBackColor = true;
            this.BtnConfigSSL3.Click += new System.EventHandler(this.BtnConfigSSL3_Click);
            // 
            // BtnTestarTLS12
            // 
            this.BtnTestarTLS12.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.BtnTestarTLS12.Location = new System.Drawing.Point(82, 70);
            this.BtnTestarTLS12.Name = "BtnTestarTLS12";
            this.BtnTestarTLS12.Size = new System.Drawing.Size(64, 23);
            this.BtnTestarTLS12.TabIndex = 5;
            this.BtnTestarTLS12.Text = "Testar";
            this.BtnTestarTLS12.UseVisualStyleBackColor = true;
            this.BtnTestarTLS12.Click += new System.EventHandler(this.BtnTestarTLS12_Click);
            // 
            // BtnConfigTLS11
            // 
            this.BtnConfigTLS11.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.BtnConfigTLS11.Location = new System.Drawing.Point(82, 12);
            this.BtnConfigTLS11.Name = "BtnConfigTLS11";
            this.BtnConfigTLS11.Size = new System.Drawing.Size(64, 23);
            this.BtnConfigTLS11.TabIndex = 1;
            this.BtnConfigTLS11.Text = "TLS 1.1";
            this.BtnConfigTLS11.UseVisualStyleBackColor = true;
            this.BtnConfigTLS11.Click += new System.EventHandler(this.BtnConfigTLS11_Click);
            // 
            // FrmGerProtocols
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(159, 103);
            this.Controls.Add(this.BtnConfigTLS11);
            this.Controls.Add(this.BtnTestarTLS12);
            this.Controls.Add(this.BtnConfigSSL3);
            this.Controls.Add(this.BtnConfigTLS13);
            this.Controls.Add(this.BtnConfigDefault);
            this.Controls.Add(this.BtnConfigTLS12);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGerProtocols";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GerProtocol";
            this.Load += new System.EventHandler(this.FrmIniciaTLS_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnConfigTLS12;
        private System.Windows.Forms.Button BtnConfigDefault;
        private System.Windows.Forms.Button BtnConfigTLS13;
        private System.Windows.Forms.Button BtnConfigSSL3;
        private System.Windows.Forms.Button BtnTestarTLS12;
        private System.Windows.Forms.Button BtnConfigTLS11;
    }
}


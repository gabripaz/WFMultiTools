
namespace WFOOPProject
{
    partial class IP4Validator
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
            this.labelToday = new System.Windows.Forms.Label();
            this.labelEnterIp = new System.Windows.Forms.Label();
            this.txtIpAddress = new System.Windows.Forms.TextBox();
            this.btnValidateIP = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelToday
            // 
            this.labelToday.AutoSize = true;
            this.labelToday.Location = new System.Drawing.Point(102, 41);
            this.labelToday.Name = "labelToday";
            this.labelToday.Size = new System.Drawing.Size(52, 17);
            this.labelToday.TabIndex = 0;
            this.labelToday.Text = "Today:";
            // 
            // labelEnterIp
            // 
            this.labelEnterIp.AutoSize = true;
            this.labelEnterIp.Location = new System.Drawing.Point(102, 132);
            this.labelEnterIp.Name = "labelEnterIp";
            this.labelEnterIp.Size = new System.Drawing.Size(117, 17);
            this.labelEnterIp.TabIndex = 1;
            this.labelEnterIp.Text = "Enter IP address:";
            // 
            // txtIpAddress
            // 
            this.txtIpAddress.Location = new System.Drawing.Point(226, 129);
            this.txtIpAddress.Name = "txtIpAddress";
            this.txtIpAddress.Size = new System.Drawing.Size(198, 22);
            this.txtIpAddress.TabIndex = 2;
            // 
            // btnValidateIP
            // 
            this.btnValidateIP.Location = new System.Drawing.Point(75, 196);
            this.btnValidateIP.Name = "btnValidateIP";
            this.btnValidateIP.Size = new System.Drawing.Size(98, 31);
            this.btnValidateIP.TabIndex = 3;
            this.btnValidateIP.Text = "Validade IP";
            this.btnValidateIP.UseVisualStyleBackColor = true;
            this.btnValidateIP.Click += new System.EventHandler(this.btnValidateIP_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(207, 196);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(98, 31);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(339, 196);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(98, 31);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // IP4Validator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 286);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnValidateIP);
            this.Controls.Add(this.txtIpAddress);
            this.Controls.Add(this.labelEnterIp);
            this.Controls.Add(this.labelToday);
            this.Name = "IP4Validator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IP4Validator";
            this.Load += new System.EventHandler(this.IP4Validator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelToday;
        private System.Windows.Forms.Label labelEnterIp;
        private System.Windows.Forms.TextBox txtIpAddress;
        private System.Windows.Forms.Button btnValidateIP;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
    }
}
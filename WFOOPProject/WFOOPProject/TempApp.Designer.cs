
namespace WFOOPProject
{
    partial class TempApp
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
            this.radiobtnCtoF = new System.Windows.Forms.RadioButton();
            this.radiobtnFtoC = new System.Windows.Forms.RadioButton();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.labelto = new System.Windows.Forms.Label();
            this.labelMessage = new System.Windows.Forms.Label();
            this.txtboxMessage = new System.Windows.Forms.TextBox();
            this.labelInput = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReadFile = new System.Windows.Forms.Button();
            this.btnConvert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radiobtnCtoF
            // 
            this.radiobtnCtoF.AutoSize = true;
            this.radiobtnCtoF.Location = new System.Drawing.Point(132, 38);
            this.radiobtnCtoF.Name = "radiobtnCtoF";
            this.radiobtnCtoF.Size = new System.Drawing.Size(102, 21);
            this.radiobtnCtoF.TabIndex = 0;
            this.radiobtnCtoF.TabStop = true;
            this.radiobtnCtoF.Text = "From C to F";
            this.radiobtnCtoF.UseVisualStyleBackColor = true;
            this.radiobtnCtoF.CheckedChanged += new System.EventHandler(this.radiobtnCtoF_CheckedChanged);
            // 
            // radiobtnFtoC
            // 
            this.radiobtnFtoC.AutoSize = true;
            this.radiobtnFtoC.Location = new System.Drawing.Point(132, 75);
            this.radiobtnFtoC.Name = "radiobtnFtoC";
            this.radiobtnFtoC.Size = new System.Drawing.Size(102, 21);
            this.radiobtnFtoC.TabIndex = 1;
            this.radiobtnFtoC.TabStop = true;
            this.radiobtnFtoC.Text = "From F to C";
            this.radiobtnFtoC.UseVisualStyleBackColor = true;
            this.radiobtnFtoC.CheckedChanged += new System.EventHandler(this.radiobtnFtoC_CheckedChanged);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(45, 129);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(100, 22);
            this.txtInput.TabIndex = 2;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(221, 129);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(100, 22);
            this.txtResult.TabIndex = 3;
            // 
            // labelto
            // 
            this.labelto.AutoSize = true;
            this.labelto.Location = new System.Drawing.Point(173, 129);
            this.labelto.Name = "labelto";
            this.labelto.Size = new System.Drawing.Size(20, 17);
            this.labelto.TabIndex = 4;
            this.labelto.Text = "to";
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Location = new System.Drawing.Point(42, 185);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(69, 17);
            this.labelMessage.TabIndex = 5;
            this.labelMessage.Text = "Message:";
            // 
            // txtboxMessage
            // 
            this.txtboxMessage.Location = new System.Drawing.Point(45, 205);
            this.txtboxMessage.Multiline = true;
            this.txtboxMessage.Name = "txtboxMessage";
            this.txtboxMessage.ReadOnly = true;
            this.txtboxMessage.Size = new System.Drawing.Size(277, 58);
            this.txtboxMessage.TabIndex = 6;
            // 
            // labelInput
            // 
            this.labelInput.AutoSize = true;
            this.labelInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInput.Location = new System.Drawing.Point(87, 154);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(18, 17);
            this.labelInput.TabIndex = 7;
            this.labelInput.Text = "C";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResult.Location = new System.Drawing.Point(263, 154);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(17, 17);
            this.labelResult.TabIndex = 8;
            this.labelResult.Text = "F";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(237, 295);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(87, 30);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReadFile
            // 
            this.btnReadFile.Location = new System.Drawing.Point(140, 295);
            this.btnReadFile.Name = "btnReadFile";
            this.btnReadFile.Size = new System.Drawing.Size(87, 30);
            this.btnReadFile.TabIndex = 10;
            this.btnReadFile.Text = "&ReadFile";
            this.btnReadFile.UseVisualStyleBackColor = true;
            this.btnReadFile.Click += new System.EventHandler(this.btnReadFile_Click);
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(43, 295);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(87, 30);
            this.btnConvert.TabIndex = 11;
            this.btnConvert.Text = "&Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // TempApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 337);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.btnReadFile);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelInput);
            this.Controls.Add(this.txtboxMessage);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.labelto);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.radiobtnFtoC);
            this.Controls.Add(this.radiobtnCtoF);
            this.Name = "TempApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TempApp - Gabriel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radiobtnCtoF;
        private System.Windows.Forms.RadioButton radiobtnFtoC;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label labelto;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.TextBox txtboxMessage;
        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReadFile;
        private System.Windows.Forms.Button btnConvert;
    }
}

namespace WFOOPProject
{
    partial class DashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            this.tabGenNumb = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLotto649 = new System.Windows.Forms.Button();
            this.btnLottoMax = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lottoMaxlabel = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTempConv = new System.Windows.Forms.Button();
            this.btnMoneyExc = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnCalc = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnIP = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.tabGenNumb.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabGenNumb
            // 
            this.tabGenNumb.Controls.Add(this.tabPage1);
            this.tabGenNumb.Controls.Add(this.tabPage2);
            this.tabGenNumb.Controls.Add(this.tabPage3);
            this.tabGenNumb.Controls.Add(this.tabPage4);
            this.tabGenNumb.Location = new System.Drawing.Point(24, 19);
            this.tabGenNumb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabGenNumb.Name = "tabGenNumb";
            this.tabGenNumb.SelectedIndex = 0;
            this.tabGenNumb.Size = new System.Drawing.Size(488, 288);
            this.tabGenNumb.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(480, 262);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Generated Numbers";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLotto649);
            this.groupBox1.Controls.Add(this.btnLottoMax);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lottoMaxlabel);
            this.groupBox1.Location = new System.Drawing.Point(47, 28);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(387, 217);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lotto";
            // 
            // btnLotto649
            // 
            this.btnLotto649.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLotto649.BackgroundImage")));
            this.btnLotto649.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLotto649.Location = new System.Drawing.Point(209, 32);
            this.btnLotto649.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLotto649.Name = "btnLotto649";
            this.btnLotto649.Size = new System.Drawing.Size(134, 124);
            this.btnLotto649.TabIndex = 5;
            this.btnLotto649.UseVisualStyleBackColor = true;
            this.btnLotto649.Click += new System.EventHandler(this.btnLotto649_Click);
            // 
            // btnLottoMax
            // 
            this.btnLottoMax.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLottoMax.BackgroundImage")));
            this.btnLottoMax.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLottoMax.Location = new System.Drawing.Point(44, 32);
            this.btnLottoMax.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLottoMax.Name = "btnLottoMax";
            this.btnLottoMax.Size = new System.Drawing.Size(134, 124);
            this.btnLottoMax.TabIndex = 4;
            this.btnLottoMax.UseVisualStyleBackColor = true;
            this.btnLottoMax.Click += new System.EventHandler(this.btnLottoMax_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(248, 168);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lotto649";
            // 
            // lottoMaxlabel
            // 
            this.lottoMaxlabel.AutoSize = true;
            this.lottoMaxlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lottoMaxlabel.Location = new System.Drawing.Point(80, 168);
            this.lottoMaxlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lottoMaxlabel.Name = "lottoMaxlabel";
            this.lottoMaxlabel.Size = new System.Drawing.Size(69, 17);
            this.lottoMaxlabel.TabIndex = 1;
            this.lottoMaxlabel.Text = "Lotto Max";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Size = new System.Drawing.Size(480, 262);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Conversions";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnTempConv);
            this.groupBox2.Controls.Add(this.btnMoneyExc);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(47, 28);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(387, 217);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Convertions";
            // 
            // btnTempConv
            // 
            this.btnTempConv.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTempConv.BackgroundImage")));
            this.btnTempConv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTempConv.Location = new System.Drawing.Point(215, 46);
            this.btnTempConv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTempConv.Name = "btnTempConv";
            this.btnTempConv.Size = new System.Drawing.Size(134, 124);
            this.btnTempConv.TabIndex = 6;
            this.btnTempConv.UseVisualStyleBackColor = true;
            this.btnTempConv.Click += new System.EventHandler(this.btnTempConv_Click);
            // 
            // btnMoneyExc
            // 
            this.btnMoneyExc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMoneyExc.BackgroundImage")));
            this.btnMoneyExc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMoneyExc.Location = new System.Drawing.Point(39, 46);
            this.btnMoneyExc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMoneyExc.Name = "btnMoneyExc";
            this.btnMoneyExc.Size = new System.Drawing.Size(134, 124);
            this.btnMoneyExc.TabIndex = 5;
            this.btnMoneyExc.UseVisualStyleBackColor = true;
            this.btnMoneyExc.Click += new System.EventHandler(this.btnMoneyExc_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(223, 180);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Temprature Convert";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 180);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Money Exchange";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnCalc);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(480, 262);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Simple Calculator";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnCalc
            // 
            this.btnCalc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCalc.BackgroundImage")));
            this.btnCalc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCalc.Location = new System.Drawing.Point(174, 56);
            this.btnCalc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(134, 161);
            this.btnCalc.TabIndex = 6;
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnIP);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(480, 262);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "IP v4 validator";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnIP
            // 
            this.btnIP.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIP.BackgroundImage")));
            this.btnIP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIP.Location = new System.Drawing.Point(174, 56);
            this.btnIP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnIP.Name = "btnIP";
            this.btnIP.Size = new System.Drawing.Size(134, 161);
            this.btnIP.TabIndex = 7;
            this.btnIP.UseVisualStyleBackColor = true;
            this.btnIP.Click += new System.EventHandler(this.btnIP_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(440, 311);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(65, 24);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 358);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.tabGenNumb);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard - Gabriel Paz Paiva";
            this.tabGenNumb.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabGenNumb;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lottoMaxlabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLotto649;
        private System.Windows.Forms.Button btnLottoMax;
        private System.Windows.Forms.Button btnTempConv;
        private System.Windows.Forms.Button btnMoneyExc;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnIP;
    }
}


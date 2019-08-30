namespace Unicode
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.txtGb2312 = new System.Windows.Forms.TextBox();
            this.txtUnicode = new System.Windows.Forms.TextBox();
            this.txtUnicodeHex = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rhtInput = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConvertToChar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(139, 338);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "转换为编码";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txtGb2312
            // 
            this.txtGb2312.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGb2312.Location = new System.Drawing.Point(3, 17);
            this.txtGb2312.Multiline = true;
            this.txtGb2312.Name = "txtGb2312";
            this.txtGb2312.Size = new System.Drawing.Size(572, 90);
            this.txtGb2312.TabIndex = 1;
            this.txtGb2312.Text = "Gb2312编码";
            // 
            // txtUnicode
            // 
            this.txtUnicode.Location = new System.Drawing.Point(2, 41);
            this.txtUnicode.Multiline = true;
            this.txtUnicode.Name = "txtUnicode";
            this.txtUnicode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtUnicode.Size = new System.Drawing.Size(283, 100);
            this.txtUnicode.TabIndex = 2;
            this.txtUnicode.Text = "Gb2312编码";
            // 
            // txtUnicodeHex
            // 
            this.txtUnicodeHex.Location = new System.Drawing.Point(294, 41);
            this.txtUnicodeHex.Multiline = true;
            this.txtUnicodeHex.Name = "txtUnicodeHex";
            this.txtUnicodeHex.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtUnicodeHex.Size = new System.Drawing.Size(276, 100);
            this.txtUnicodeHex.TabIndex = 3;
            this.txtUnicodeHex.Text = "Gb2312编码";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rhtInput);
            this.groupBox1.Location = new System.Drawing.Point(10, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(578, 50);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "输入字符";
            // 
            // rhtInput
            // 
            this.rhtInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rhtInput.Location = new System.Drawing.Point(3, 17);
            this.rhtInput.Name = "rhtInput";
            this.rhtInput.Size = new System.Drawing.Size(572, 30);
            this.rhtInput.TabIndex = 6;
            this.rhtInput.Text = "Unicode编码区";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtUnicode);
            this.groupBox2.Controls.Add(this.txtUnicodeHex);
            this.groupBox2.Location = new System.Drawing.Point(10, 58);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(578, 149);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Unicode";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(367, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "16进制";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "10进制";
            // 
            // btnConvertToChar
            // 
            this.btnConvertToChar.Location = new System.Drawing.Point(321, 338);
            this.btnConvertToChar.Name = "btnConvertToChar";
            this.btnConvertToChar.Size = new System.Drawing.Size(139, 32);
            this.btnConvertToChar.TabIndex = 6;
            this.btnConvertToChar.Text = "逆转为字符";
            this.btnConvertToChar.UseVisualStyleBackColor = true;
            this.btnConvertToChar.Click += new System.EventHandler(this.BtnConvertToChar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtGb2312);
            this.groupBox3.Location = new System.Drawing.Point(10, 213);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(578, 110);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Gb2312";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 382);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnConvertToChar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "字符查询Unicode";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtGb2312;
        private System.Windows.Forms.TextBox txtUnicode;
        private System.Windows.Forms.TextBox txtUnicodeHex;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rhtInput;
        private System.Windows.Forms.Button btnConvertToChar;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}


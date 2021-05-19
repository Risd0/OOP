
namespace WindowsFormsApp
{
    partial class Form1
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
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.maxLengthText = new System.Windows.Forms.TextBox();
            this.str1Txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.str2Txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.getStr3Button = new System.Windows.Forms.Button();
            this.operators = new System.Windows.Forms.ComboBox();
            this.resultTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.strTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.strFirstElementTxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bigIntegerMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Philosopher", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(436, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Max Length";
            // 
            // maxLengthText
            // 
            this.maxLengthText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maxLengthText.Enabled = false;
            this.maxLengthText.Location = new System.Drawing.Point(436, 70);
            this.maxLengthText.Name = "maxLengthText";
            this.maxLengthText.Size = new System.Drawing.Size(81, 23);
            this.maxLengthText.TabIndex = 1;
            this.maxLengthText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // str1Txt
            // 
            this.str1Txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.str1Txt.Location = new System.Drawing.Point(12, 234);
            this.str1Txt.Multiline = true;
            this.str1Txt.Name = "str1Txt";
            this.str1Txt.Size = new System.Drawing.Size(150, 23);
            this.str1Txt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "String1";
            // 
            // str2Txt
            // 
            this.str2Txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.str2Txt.Location = new System.Drawing.Point(12, 278);
            this.str2Txt.Multiline = true;
            this.str2Txt.Name = "str2Txt";
            this.str2Txt.Size = new System.Drawing.Size(150, 23);
            this.str2Txt.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "String2";
            // 
            // getStr3Button
            // 
            this.getStr3Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.getStr3Button.Location = new System.Drawing.Point(222, 287);
            this.getStr3Button.Name = "getStr3Button";
            this.getStr3Button.Size = new System.Drawing.Size(106, 23);
            this.getStr3Button.TabIndex = 4;
            this.getStr3Button.Text = "Compute";
            this.getStr3Button.UseVisualStyleBackColor = true;
            this.getStr3Button.Click += new System.EventHandler(this.GetStr3Button_Click);
            // 
            // operators
            // 
            this.operators.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.operators.FormattingEnabled = true;
            this.operators.Items.AddRange(new object[] {
            "+",
            "-",
            "*"});
            this.operators.Location = new System.Drawing.Point(168, 257);
            this.operators.Name = "operators";
            this.operators.Size = new System.Drawing.Size(48, 23);
            this.operators.TabIndex = 5;
            // 
            // resultTxt
            // 
            this.resultTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.resultTxt.Location = new System.Drawing.Point(222, 257);
            this.resultTxt.Multiline = true;
            this.resultTxt.Name = "resultTxt";
            this.resultTxt.ReadOnly = true;
            this.resultTxt.Size = new System.Drawing.Size(150, 23);
            this.resultTxt.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(222, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Result";
            // 
            // strTxt
            // 
            this.strTxt.Location = new System.Drawing.Point(12, 66);
            this.strTxt.Multiline = true;
            this.strTxt.Name = "strTxt";
            this.strTxt.Size = new System.Drawing.Size(150, 23);
            this.strTxt.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "String";
            // 
            // strFirstElementTxt
            // 
            this.strFirstElementTxt.Location = new System.Drawing.Point(168, 66);
            this.strFirstElementTxt.Multiline = true;
            this.strFirstElementTxt.Name = "strFirstElementTxt";
            this.strFirstElementTxt.Size = new System.Drawing.Size(107, 23);
            this.strFirstElementTxt.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(281, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Run";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(168, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "First letter of String";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitMenuItem,
            this.bigIntegerMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(529, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.CheckOnClick = true;
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitMenuItem.Text = "Exit";
            // 
            // bigIntegerMenuItem
            // 
            this.bigIntegerMenuItem.Name = "bigIntegerMenuItem";
            this.bigIntegerMenuItem.Size = new System.Drawing.Size(105, 20);
            this.bigIntegerMenuItem.Text = "&Go to BigInteger";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 322);
            this.Controls.Add(this.operators);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.getStr3Button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resultTxt);
            this.Controls.Add(this.strFirstElementTxt);
            this.Controls.Add(this.strTxt);
            this.Controls.Add(this.str2Txt);
            this.Controls.Add(this.str1Txt);
            this.Controls.Add(this.maxLengthText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(458, 240);
            this.Name = "Form1";
            this.Text = "CharString";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox maxLengthText;
        private System.Windows.Forms.TextBox str1Txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox str2Txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button getStr3Button;
        private System.Windows.Forms.ComboBox operators;
        private System.Windows.Forms.TextBox resultTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox strTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox strFirstElementTxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bigIntegerMenuItem;
    }
}


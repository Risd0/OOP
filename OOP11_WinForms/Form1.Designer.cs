
namespace OOP11_WinForms
{
    partial class Form1
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
            this.bitStrTxtBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.myStrTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.runMyStrButton = new System.Windows.Forms.Button();
            this.signButton1 = new System.Windows.Forms.Button();
            this.bitStrTxtBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.signButton2 = new System.Windows.Forms.Button();
            this.sumButton = new System.Windows.Forms.Button();
            this.sumBitStrTxtBox = new System.Windows.Forms.TextBox();
            this.myStr_clearButton = new System.Windows.Forms.Button();
            this.bitStr1_clearButton = new System.Windows.Forms.Button();
            this.bitStr2_clearButton = new System.Windows.Forms.Button();
            this.runBitStrButton1 = new System.Windows.Forms.Button();
            this.runBitStrButton2 = new System.Windows.Forms.Button();
            this.signTxtBox1 = new System.Windows.Forms.TextBox();
            this.signTxtBox2 = new System.Windows.Forms.TextBox();
            this.equalityTxtBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bitStrTxtBox1
            // 
            this.bitStrTxtBox1.Location = new System.Drawing.Point(46, 55);
            this.bitStrTxtBox1.Name = "bitStrTxtBox1";
            this.bitStrTxtBox1.Size = new System.Drawing.Size(112, 20);
            this.bitStrTxtBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Значеня для BitString";
            // 
            // myStrTxtBox
            // 
            this.myStrTxtBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.myStrTxtBox.Location = new System.Drawing.Point(359, 52);
            this.myStrTxtBox.Name = "myStrTxtBox";
            this.myStrTxtBox.Size = new System.Drawing.Size(146, 20);
            this.myStrTxtBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(356, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Значеня для MyString";
            // 
            // runMyStrButton
            // 
            this.runMyStrButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.runMyStrButton.Location = new System.Drawing.Point(511, 52);
            this.runMyStrButton.Name = "runMyStrButton";
            this.runMyStrButton.Size = new System.Drawing.Size(75, 23);
            this.runMyStrButton.TabIndex = 2;
            this.runMyStrButton.Text = "Ready";
            this.runMyStrButton.UseVisualStyleBackColor = true;
            this.runMyStrButton.Click += new System.EventHandler(this.runMyStrButton_Click);
            // 
            // signButton1
            // 
            this.signButton1.Location = new System.Drawing.Point(116, 84);
            this.signButton1.Name = "signButton1";
            this.signButton1.Size = new System.Drawing.Size(161, 23);
            this.signButton1.TabIndex = 3;
            this.signButton1.Text = "Змінити знаковий розряд";
            this.signButton1.UseVisualStyleBackColor = true;
            this.signButton1.Click += new System.EventHandler(this.signButton1_Click);
            // 
            // bitStrTxtBox2
            // 
            this.bitStrTxtBox2.Location = new System.Drawing.Point(46, 137);
            this.bitStrTxtBox2.Name = "bitStrTxtBox2";
            this.bitStrTxtBox2.Size = new System.Drawing.Size(112, 20);
            this.bitStrTxtBox2.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Значеня для BitString";
            // 
            // signButton2
            // 
            this.signButton2.Location = new System.Drawing.Point(116, 166);
            this.signButton2.Name = "signButton2";
            this.signButton2.Size = new System.Drawing.Size(161, 23);
            this.signButton2.TabIndex = 3;
            this.signButton2.Text = "Змінити знаковий розряд";
            this.signButton2.UseVisualStyleBackColor = true;
            this.signButton2.Click += new System.EventHandler(this.signButton2_Click);
            // 
            // sumButton
            // 
            this.sumButton.Location = new System.Drawing.Point(190, 248);
            this.sumButton.Name = "sumButton";
            this.sumButton.Size = new System.Drawing.Size(75, 23);
            this.sumButton.TabIndex = 4;
            this.sumButton.Text = "Sum";
            this.sumButton.UseVisualStyleBackColor = true;
            this.sumButton.Click += new System.EventHandler(this.sumButton_Click);
            // 
            // sumBitStrTxtBox
            // 
            this.sumBitStrTxtBox.Location = new System.Drawing.Point(12, 250);
            this.sumBitStrTxtBox.Name = "sumBitStrTxtBox";
            this.sumBitStrTxtBox.ReadOnly = true;
            this.sumBitStrTxtBox.Size = new System.Drawing.Size(172, 20);
            this.sumBitStrTxtBox.TabIndex = 5;
            // 
            // myStr_clearButton
            // 
            this.myStr_clearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.myStr_clearButton.Enabled = false;
            this.myStr_clearButton.Location = new System.Drawing.Point(511, 84);
            this.myStr_clearButton.Name = "myStr_clearButton";
            this.myStr_clearButton.Size = new System.Drawing.Size(75, 23);
            this.myStr_clearButton.TabIndex = 6;
            this.myStr_clearButton.Text = "Clear";
            this.myStr_clearButton.UseVisualStyleBackColor = true;
            this.myStr_clearButton.Click += new System.EventHandler(this.myStr_clearButton_Click);
            // 
            // bitStr1_clearButton
            // 
            this.bitStr1_clearButton.Enabled = false;
            this.bitStr1_clearButton.Location = new System.Drawing.Point(245, 55);
            this.bitStr1_clearButton.Name = "bitStr1_clearButton";
            this.bitStr1_clearButton.Size = new System.Drawing.Size(75, 23);
            this.bitStr1_clearButton.TabIndex = 6;
            this.bitStr1_clearButton.Text = "Clear";
            this.bitStr1_clearButton.UseVisualStyleBackColor = true;
            this.bitStr1_clearButton.Click += new System.EventHandler(this.bitStr1_clearButton_Click);
            // 
            // bitStr2_clearButton
            // 
            this.bitStr2_clearButton.Enabled = false;
            this.bitStr2_clearButton.Location = new System.Drawing.Point(245, 137);
            this.bitStr2_clearButton.Name = "bitStr2_clearButton";
            this.bitStr2_clearButton.Size = new System.Drawing.Size(75, 23);
            this.bitStr2_clearButton.TabIndex = 6;
            this.bitStr2_clearButton.Text = "Clear";
            this.bitStr2_clearButton.UseVisualStyleBackColor = true;
            this.bitStr2_clearButton.Click += new System.EventHandler(this.bitStr2_clearButton_Click);
            // 
            // runBitStrButton1
            // 
            this.runBitStrButton1.Location = new System.Drawing.Point(164, 55);
            this.runBitStrButton1.Name = "runBitStrButton1";
            this.runBitStrButton1.Size = new System.Drawing.Size(75, 23);
            this.runBitStrButton1.TabIndex = 2;
            this.runBitStrButton1.Text = "Ready";
            this.runBitStrButton1.UseVisualStyleBackColor = true;
            this.runBitStrButton1.Click += new System.EventHandler(this.runBitStrButton1_Click);
            // 
            // runBitStrButton2
            // 
            this.runBitStrButton2.Location = new System.Drawing.Point(164, 137);
            this.runBitStrButton2.Name = "runBitStrButton2";
            this.runBitStrButton2.Size = new System.Drawing.Size(75, 23);
            this.runBitStrButton2.TabIndex = 2;
            this.runBitStrButton2.Text = "Ready";
            this.runBitStrButton2.UseVisualStyleBackColor = true;
            this.runBitStrButton2.Click += new System.EventHandler(this.runBitStrButton2_Click);
            // 
            // signTxtBox1
            // 
            this.signTxtBox1.Enabled = false;
            this.signTxtBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.signTxtBox1.Location = new System.Drawing.Point(12, 55);
            this.signTxtBox1.Name = "signTxtBox1";
            this.signTxtBox1.Size = new System.Drawing.Size(28, 23);
            this.signTxtBox1.TabIndex = 7;
            this.signTxtBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // signTxtBox2
            // 
            this.signTxtBox2.Enabled = false;
            this.signTxtBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.signTxtBox2.Location = new System.Drawing.Point(12, 137);
            this.signTxtBox2.Name = "signTxtBox2";
            this.signTxtBox2.Size = new System.Drawing.Size(28, 23);
            this.signTxtBox2.TabIndex = 7;
            this.signTxtBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // equalityTxtBox
            // 
            this.equalityTxtBox.Location = new System.Drawing.Point(84, 224);
            this.equalityTxtBox.Name = "equalityTxtBox";
            this.equalityTxtBox.ReadOnly = true;
            this.equalityTxtBox.Size = new System.Drawing.Size(74, 20);
            this.equalityTxtBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Equal";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 302);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.equalityTxtBox);
            this.Controls.Add(this.signTxtBox2);
            this.Controls.Add(this.signTxtBox1);
            this.Controls.Add(this.bitStr2_clearButton);
            this.Controls.Add(this.bitStr1_clearButton);
            this.Controls.Add(this.myStr_clearButton);
            this.Controls.Add(this.sumBitStrTxtBox);
            this.Controls.Add(this.sumButton);
            this.Controls.Add(this.signButton2);
            this.Controls.Add(this.signButton1);
            this.Controls.Add(this.runBitStrButton2);
            this.Controls.Add(this.runBitStrButton1);
            this.Controls.Add(this.runMyStrButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.myStrTxtBox);
            this.Controls.Add(this.bitStrTxtBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bitStrTxtBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox bitStrTxtBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox myStrTxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button runMyStrButton;
        private System.Windows.Forms.Button signButton1;
        private System.Windows.Forms.TextBox bitStrTxtBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button signButton2;
        private System.Windows.Forms.Button sumButton;
        private System.Windows.Forms.TextBox sumBitStrTxtBox;
        private System.Windows.Forms.Button myStr_clearButton;
        private System.Windows.Forms.Button bitStr1_clearButton;
        private System.Windows.Forms.Button bitStr2_clearButton;
        private System.Windows.Forms.Button runBitStrButton1;
        private System.Windows.Forms.Button runBitStrButton2;
        private System.Windows.Forms.TextBox signTxtBox1;
        private System.Windows.Forms.TextBox signTxtBox2;
        private System.Windows.Forms.TextBox equalityTxtBox;
        private System.Windows.Forms.Label label4;
    }
}


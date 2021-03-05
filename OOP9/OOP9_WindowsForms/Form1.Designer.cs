
namespace OOP9_WindowsForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.uselessText = new System.Windows.Forms.TextBox();
            this.squareLabel = new System.Windows.Forms.Label();
            this.squareText = new System.Windows.Forms.TextBox();
            this.uselessLabel = new System.Windows.Forms.Label();
            this.lenRoomLabel = new System.Windows.Forms.Label();
            this.lenText = new System.Windows.Forms.TextBox();
            this.widthRoomLabel = new System.Windows.Forms.Label();
            this.widthText = new System.Windows.Forms.TextBox();
            this.volumeLabel = new System.Windows.Forms.Label();
            this.volumeText = new System.Windows.Forms.TextBox();
            this.runButton = new System.Windows.Forms.Button();
            this.windowsLabel = new System.Windows.Forms.Label();
            this.windowsCountText = new System.Windows.Forms.TextBox();
            this.heightLabel = new System.Windows.Forms.Label();
            this.heightText = new System.Windows.Forms.TextBox();
            this.meassureLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(317, 278);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.SizeChanged += new System.EventHandler(this.pictureBox1_SizeChanged);
            // 
            // uselessText
            // 
            this.uselessText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uselessText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.uselessText.Location = new System.Drawing.Point(335, 34);
            this.uselessText.Name = "uselessText";
            this.uselessText.ReadOnly = true;
            this.uselessText.Size = new System.Drawing.Size(154, 23);
            this.uselessText.TabIndex = 2;
            // 
            // squareLabel
            // 
            this.squareLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.squareLabel.AutoSize = true;
            this.squareLabel.Font = new System.Drawing.Font("Philosopher", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.squareLabel.Location = new System.Drawing.Point(333, 199);
            this.squareLabel.Name = "squareLabel";
            this.squareLabel.Size = new System.Drawing.Size(50, 19);
            this.squareLabel.TabIndex = 1;
            this.squareLabel.Text = "Square";
            // 
            // squareText
            // 
            this.squareText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.squareText.Enabled = false;
            this.squareText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.squareText.Location = new System.Drawing.Point(389, 196);
            this.squareText.Name = "squareText";
            this.squareText.Size = new System.Drawing.Size(100, 23);
            this.squareText.TabIndex = 2;
            this.squareText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.squareText_KeyPress);
            // 
            // uselessLabel
            // 
            this.uselessLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uselessLabel.AutoSize = true;
            this.uselessLabel.Font = new System.Drawing.Font("Philosopher", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.uselessLabel.Location = new System.Drawing.Point(335, 12);
            this.uselessLabel.Name = "uselessLabel";
            this.uselessLabel.Size = new System.Drawing.Size(103, 19);
            this.uselessLabel.TabIndex = 1;
            this.uselessLabel.Text = "Useless Method";
            // 
            // lenRoomLabel
            // 
            this.lenRoomLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lenRoomLabel.AutoSize = true;
            this.lenRoomLabel.Font = new System.Drawing.Font("Philosopher", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lenRoomLabel.Location = new System.Drawing.Point(333, 112);
            this.lenRoomLabel.Name = "lenRoomLabel";
            this.lenRoomLabel.Size = new System.Drawing.Size(51, 19);
            this.lenRoomLabel.TabIndex = 1;
            this.lenRoomLabel.Text = "Length";
            // 
            // lenText
            // 
            this.lenText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lenText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lenText.Location = new System.Drawing.Point(389, 109);
            this.lenText.Name = "lenText";
            this.lenText.Size = new System.Drawing.Size(100, 23);
            this.lenText.TabIndex = 2;
            this.lenText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.squareText_KeyPress);
            // 
            // widthRoomLabel
            // 
            this.widthRoomLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.widthRoomLabel.AutoSize = true;
            this.widthRoomLabel.Font = new System.Drawing.Font("Philosopher", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.widthRoomLabel.Location = new System.Drawing.Point(340, 83);
            this.widthRoomLabel.Name = "widthRoomLabel";
            this.widthRoomLabel.Size = new System.Drawing.Size(43, 19);
            this.widthRoomLabel.TabIndex = 1;
            this.widthRoomLabel.Text = "Width";
            // 
            // widthText
            // 
            this.widthText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.widthText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.widthText.Location = new System.Drawing.Point(389, 80);
            this.widthText.Name = "widthText";
            this.widthText.Size = new System.Drawing.Size(100, 23);
            this.widthText.TabIndex = 2;
            this.widthText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.squareText_KeyPress);
            // 
            // volumeLabel
            // 
            this.volumeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.volumeLabel.AutoSize = true;
            this.volumeLabel.Font = new System.Drawing.Font("Philosopher", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.volumeLabel.Location = new System.Drawing.Point(333, 170);
            this.volumeLabel.Name = "volumeLabel";
            this.volumeLabel.Size = new System.Drawing.Size(53, 19);
            this.volumeLabel.TabIndex = 1;
            this.volumeLabel.Text = "Volume";
            // 
            // volumeText
            // 
            this.volumeText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.volumeText.Enabled = false;
            this.volumeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.volumeText.Location = new System.Drawing.Point(389, 167);
            this.volumeText.Name = "volumeText";
            this.volumeText.Size = new System.Drawing.Size(100, 23);
            this.volumeText.TabIndex = 2;
            this.volumeText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.squareText_KeyPress);
            // 
            // runButton
            // 
            this.runButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.runButton.Font = new System.Drawing.Font("Roboto", 10F);
            this.runButton.Location = new System.Drawing.Point(389, 383);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(100, 44);
            this.runButton.TabIndex = 3;
            this.runButton.Text = "Run";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // windowsLabel
            // 
            this.windowsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.windowsLabel.AutoSize = true;
            this.windowsLabel.Font = new System.Drawing.Font("Philosopher", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.windowsLabel.Location = new System.Drawing.Point(12, 293);
            this.windowsLabel.Name = "windowsLabel";
            this.windowsLabel.Size = new System.Drawing.Size(62, 19);
            this.windowsLabel.TabIndex = 1;
            this.windowsLabel.Text = "Windows";
            // 
            // windowsCountText
            // 
            this.windowsCountText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.windowsCountText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.windowsCountText.Location = new System.Drawing.Point(12, 315);
            this.windowsCountText.Name = "windowsCountText";
            this.windowsCountText.Size = new System.Drawing.Size(100, 23);
            this.windowsCountText.TabIndex = 2;
            this.windowsCountText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // heightLabel
            // 
            this.heightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.heightLabel.AutoSize = true;
            this.heightLabel.Font = new System.Drawing.Font("Philosopher", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.heightLabel.Location = new System.Drawing.Point(336, 141);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(48, 19);
            this.heightLabel.TabIndex = 1;
            this.heightLabel.Text = "Height";
            // 
            // heightText
            // 
            this.heightText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.heightText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.heightText.Location = new System.Drawing.Point(389, 138);
            this.heightText.Name = "heightText";
            this.heightText.Size = new System.Drawing.Size(100, 23);
            this.heightText.TabIndex = 2;
            this.heightText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.squareText_KeyPress);
            // 
            // meassureLabel
            // 
            this.meassureLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.meassureLabel.AutoSize = true;
            this.meassureLabel.Location = new System.Drawing.Point(420, 64);
            this.meassureLabel.Name = "meassureLabel";
            this.meassureLabel.Size = new System.Drawing.Size(69, 13);
            this.meassureLabel.TabIndex = 4;
            this.meassureLabel.Text = "meassure (m)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(501, 439);
            this.Controls.Add(this.meassureLabel);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.heightText);
            this.Controls.Add(this.widthText);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.lenText);
            this.Controls.Add(this.widthRoomLabel);
            this.Controls.Add(this.windowsCountText);
            this.Controls.Add(this.volumeText);
            this.Controls.Add(this.squareText);
            this.Controls.Add(this.windowsLabel);
            this.Controls.Add(this.lenRoomLabel);
            this.Controls.Add(this.volumeLabel);
            this.Controls.Add(this.uselessLabel);
            this.Controls.Add(this.squareLabel);
            this.Controls.Add(this.uselessText);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(337, 320);
            this.Name = "Form1";
            this.Text = "Fun with Room class";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox uselessText;
        private System.Windows.Forms.Label squareLabel;
        private System.Windows.Forms.TextBox squareText;
        private System.Windows.Forms.Label uselessLabel;
        private System.Windows.Forms.Label lenRoomLabel;
        private System.Windows.Forms.TextBox lenText;
        private System.Windows.Forms.Label widthRoomLabel;
        private System.Windows.Forms.TextBox widthText;
        private System.Windows.Forms.Label volumeLabel;
        private System.Windows.Forms.TextBox volumeText;
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.Label windowsLabel;
        private System.Windows.Forms.TextBox windowsCountText;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.TextBox heightText;
        private System.Windows.Forms.Label meassureLabel;
    }
}


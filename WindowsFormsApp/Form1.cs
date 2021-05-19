using System;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            maxLengthText.Text = CharString.maxLength.ToString();
        }

        private void GetStr3Button_Click(object sender, EventArgs e)
        {
            CharString charString1 = new CharString(str1Txt.Text);
            CharString charString2 = new CharString(str2Txt.Text);
            // intellisense suggestion ☜(ﾟヮﾟ☜)
            resultTxt.Text = operators.SelectedIndex switch
            {
                0 => (charString1 + charString2).String,
                1 => (charString1 - charString2).String,
                2 => $"{charString1 * charString2}",
                _ => new CharString("Undefined").String,
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            strFirstElementTxt.Text = new CharString(strTxt.Text).FirstElement.ToString();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem == exitMenuItem) { Application.Exit(); }
            else if (e.ClickedItem == bigIntegerMenuItem)
            {
                this.Hide();
                var form = new Form2();
                form.ShowDialog();
                this.Close();
            }
        }
    }
}

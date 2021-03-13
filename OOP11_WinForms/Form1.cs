using System;
using System.Windows.Forms;

namespace OOP11_WinForms
{
    public partial class Form1 : Form
    {
        MyString myStr = new MyString();
        BitString bitStr1 = new BitString("");
        BitString bitStr2 = new BitString("");

        public Form1()
        {
            InitializeComponent();
        }

        private void bitStr1_clearButton_Click(object sender, EventArgs e)
        {
            bitStr1.Clear();
            bitStrTxtBox1.Text = bitStr1.Str;
        }

        private void runBitStrButton1_Click(object sender, EventArgs e)
        {
            bitStr1.Str = bitStrTxtBox1.Text;
            bitStrTxtBox1.Text = bitStr1.Str;
            signTxtBox1.Text = bitStr1.Sign.ToString();
            bitStr1_clearButton.Enabled = true;
        }

        private void runBitStrButton2_Click(object sender, EventArgs e)
        {
            bitStr2 = new BitString(bitStrTxtBox2.Text);
            bitStrTxtBox2.Text = bitStr2.Str;
            signTxtBox2.Text = bitStr2.Sign.ToString();
            bitStr2_clearButton.Enabled = true;
        }

        private void bitStr2_clearButton_Click(object sender, EventArgs e)
        {
            bitStr2.Clear();
            bitStrTxtBox2.Text = bitStr2.Str;
        }

        private void signButton1_Click(object sender, EventArgs e)
        {
            bitStr1.ChangeSign();
            signTxtBox1.Text = bitStr1.Sign.ToString();
        }

        private void signButton2_Click(object sender, EventArgs e)
        {
            bitStr2.ChangeSign();
            signTxtBox2.Text = bitStr2.Sign.ToString();
        }

        private void runMyStrButton_Click(object sender, EventArgs e)
        {
            myStr = new MyString(myStrTxtBox.Text);
            myStrTxtBox.Text = myStr.ToString();
            myStr_clearButton.Enabled = true;
        }

        private void myStr_clearButton_Click(object sender, EventArgs e)
        {
            myStr.Clear();
            myStrTxtBox.Text = myStr.ToString();
        }

        private void sumButton_Click(object sender, EventArgs e)
        {
            equalityTxtBox.Text = bitStr1 == bitStr2 ? "Yep" : "Nope";
            sumBitStrTxtBox.Text = bitStr1 + bitStr2;
        }
    }
}

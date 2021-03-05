using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace OOP9_WindowsForms
{
    public partial class Form1 : Form
    {
        void FunWithRoomClass()
        {
            uselessText.Text = Room.UselessMethod();
            Room room = new Room();
            try
            {
                room.SquareCompute(double.Parse(lenText.Text), double.Parse(widthText.Text));
                room.Height = double.Parse(heightText.Text);
                room.WindowsCount = uint.Parse(windowsCountText.Text);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show($"What a pity! Here's error!\nMore info:\nMessage: {ex.Message}\nSource: {ex.Source}\nMethod: " +
                    $"{ex.TargetSite}");
            }
            catch { MessageBox.Show("Something got wrong!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            squareText.Text = room.Square.ToString();
            volumeText.Text = room.Volume().ToString();
            MessageBox.Show(room.Condition);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_SizeChanged(object sender, EventArgs e)
        {
            pictureBox1.Width = pictureBox1.Height;
        }

        private void squareText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != ',') { e.Handled = true; }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b') { e.Handled = true; }
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            FunWithRoomClass();
        }
    }
}

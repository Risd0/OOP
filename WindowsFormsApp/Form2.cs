using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem == exitMenuItem) { Application.Exit(); }
            else if (e.ClickedItem == charStrMenuItem)
            {
                this.Hide();
                var form = new Form1();
                form.ShowDialog();
                this.Close();
            }
        }
    }
}

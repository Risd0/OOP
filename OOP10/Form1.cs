using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP10
{
    public partial class Form1 : Form
    {
        int[,] arr;
        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Ok") { Application.Restart(); }

            (int rows, int cols) = ((int)rowsUpDown.Value, (int)colsUpDown.Value);
            arr = new int[rows, cols];

            dataGridView1.RowCount = rows;
            dataGridView1.ColumnCount = cols;

            Randomize2DArr(-5, 11);

            Print();

            PositiveColsSum();

            label5.Text += ParallelMainDiagMaxSum();

            button1.Text = "Ok";
        }

        void Randomize2DArr(int min, int max)
        {
            var rand = new Random();
            for (int i = 0; i < rowsUpDown.Value; i++)
            {
                for (int j = 0; j < colsUpDown.Value; j++)
                {
                    arr[i, j] = rand.Next(min, max);
                }
            }
        }
        void PositiveColsSum()
        {
            for (int j = 0; j < rowsUpDown.Value; j++)
            {
                int sum = 0;
                bool isPositive = true;
                for (int i = 0; i < colsUpDown.Value; i++)
                {
                    if (arr[i, j] >= 0) { sum += arr[i, j]; }
                    else
                    {
                        isPositive = false;
                        break;
                    }

                }
                if (isPositive && sum != 0) { label4.Text += sum + " "; }
            }
        }
        void Print()
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = arr[i, j];
                }
            }
        }

        int ParallelMainDiagMaxSum()
        {
            int size = (int)Math.Min(rowsUpDown.Value, colsUpDown.Value);
            int max = arr[0, size - 1];
            for (int k = -size + 1; k < size; ++k)
            {
                int sum = 0;
                for (int i = Math.Max(0, k), j = Math.Max(-k, 0); j < Math.Min(size, size - k); i++, j++) { sum += arr[i, j]; }
                if (max < sum) max = sum;
            }
            return max;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void rowsUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (rowsUpDown.Value > 10) rowsUpDown.Value = 10;
            else if (rowsUpDown.Value < 1) rowsUpDown.Value = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

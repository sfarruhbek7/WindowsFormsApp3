using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtN_TextChanged(object sender, EventArgs e)
        {
            //
        }

        private void txtM_TextChanged(object sender, EventArgs e)
        {
            //
        }

        private void lblResult_Click(object sender, EventArgs e)
        {
            //
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //
        }


        private void FillArrayAndDisplay()
        {
            if (!int.TryParse(txtN.Text, out int n) || !int.TryParse(txtM.Text, out int m))
            {
                MessageBox.Show("N va M sonlarini to'g'ri kiriting.");
                return;
            }

            if (n <= 0 || m <= 0)
            {
                MessageBox.Show("N va M musbat bo'lishi kerak.");
                return;
            }

            Random random = new Random();
            int[,] array = new int[n, m];
            int countGreaterThan200 = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    array[i, j] = random.Next(-3000, 3001);
                    if (array[i, j] > 200)
                    {
                        countGreaterThan200++;
                    }
                }
            }

            dataGridView1.Columns.Clear();

            for (int j = 0; j < m; j++)
            {
                dataGridView1.Columns.Add($"Column{j + 1}", $"Column {j + 1}");
            }

            dataGridView1.Rows.Clear();
            for (int i = 0; i < n; i++)
            {
                dataGridView1.Rows.Add();
                for (int j = 0; j < m; j++)
                {
                    dataGridView1[j, i].Value = array[i, j];
                }
            }


            lblResult.Text = $"Qiymati 200 dan katta elementlar soni: {countGreaterThan200}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FillArrayAndDisplay();
        }
    }
}

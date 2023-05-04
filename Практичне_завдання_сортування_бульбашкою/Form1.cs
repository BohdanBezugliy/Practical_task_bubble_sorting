using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практичне_завдання_сортування_бульбашкою
{
    public partial class frmBubbleSort : Form
    {
        int m;
        char s;
        public frmBubbleSort()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Кількість елементів не введено!", "Помилка");
            }
            else
            {
                m=int.Parse(textBox1.Text);
                dataGridView1.ColumnCount= m;
                for (int i = 0; i < m; i++)
                {
                    dataGridView1.Columns[i].Width = 110;
                    dataGridView1.ColumnHeadersDefaultCellStyle.Alignment=DataGridViewContentAlignment.MiddleCenter;
                    dataGridView1.Columns[i].HeaderText="Символ №"+(i+1).ToString();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            char[] symbs = new char[m];
            for (int i = 0; i < symbs.Length; i++)
            {
                symbs[i] = Convert.ToChar(dataGridView1.Rows[0].Cells[i].Value);
            }
            for (int i = 1; i <= symbs.Length-1; i++)
            {
                for (int j = 0; j < symbs.Length-i; j++)
                {
                    if (symbs[j] > symbs[j+1])
                    {
                        s = symbs[j + 1];
                        symbs[j+1] = symbs[j];
                        symbs[j] = s;
                    }
                }
            }
            for (int i = 0; i < symbs.Length; i++)
            {
                textBox2.Text+=Convert.ToString(symbs[i]) + " ";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

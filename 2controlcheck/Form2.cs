using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2controlcheck
{
    public partial class Form2 : Form
    {
        public double[] X;
        public double[] Y;

        int errorR, errorC;
        public Form2()
        {
            InitializeComponent();
        }
       
        private void Form2_Load(object sender, EventArgs e)
        {
                        
        }

        public void button1_Click(object sender, EventArgs e)
        {
            int N = dataGridView1.RowCount;
            X = new double[N];
            Y = new double[N];

            try
            {
                for (int i = 0; i < N; i++)
                {
                    errorR = i;
                    errorC = 0;
                    X[i] = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);
                    errorC = 1;
                    Y[i] = Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);
                }

            }
            catch 
            {
                dataGridView1.Rows[errorR].Cells[errorC].Style.BackColor = Color.Red;
                MessageBox.Show("Ошибка");
                Application.Restart();
            }
            
            for (int i = 0; i < N; i++)
            {
                X[i] = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);
                Y[i] = Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);
            }
            Form1.X = this.X;
            Form1.Y = this.Y;
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}

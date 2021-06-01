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
    public partial class Form3 : Form
    {
        public int n;
        public double[] A;
        int error,a;
        public Form3()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {

            try
            {
                n = int.Parse(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("Ошибка");
                Application.Restart();
            }
            n = int.Parse(textBox1.Text);
            A = new double[n + 1];
            try
            {
                for (int i = 0; i < n + 1; i++)
                {
                    error = i;
                    a = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);
                }
            }
            catch
            {
                dataGridView1.Rows[error].Cells[0].Style.BackColor = Color.Red;
                MessageBox.Show("Ошибка");
                Application.Restart();
            }
            for (int i = 0; i < n + 1; i++) A[i] = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);
            Form1.n = this.n;
            Form1.A = this.A;
        }
        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}

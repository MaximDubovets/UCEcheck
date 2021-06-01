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
    public partial class Form1 : Form
    {
        public static int n = 0;
        public static double[] A;      

        int Wcell,Wgraphic;
        Color CLcell,CLgraphic;

        int TypePoints;

        public Form PointProp;
        public static double[] X;
        public static double[] Y;

        int cellGR, cellVR;
        bool polynom;
        bool errorCell;


        public Form Form3;

        public Form1()
        {
            InitializeComponent();

        }
       
        private void Form1_Load(object sender, EventArgs e)
        {            
            control1.InitGraphics();            
        }

        private void построитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (Wcell == 0) Wcell = 1;
            try
            {
                errorCell = false;
                cellGR = int.Parse(toolStripTextBox4.Text);
                errorCell = true;
                cellVR = int.Parse(toolStripTextBox5.Text);
            }

            catch 
            {              
                MessageBox.Show("Ошибка");
                Application.Restart();
            }
            cellGR = int.Parse(toolStripTextBox4.Text);
            cellVR = int.Parse(toolStripTextBox5.Text);
            try
            {
                Wcell = Math.Abs(int.Parse(toolStripTextBox1.Text));
                toolStripTextBox1.Text = Wcell.ToString();
            }
            catch 
            {
                MessageBox.Show("Введите толщину сетки");
                Application.Restart();
            }

            switch(toolStripComboBox1.SelectedItem)
            {
                case "Красный":
                    CLcell = Color.Red;
                    break;

                case "Зеленый":
                    CLcell = Color.Green;
                    break;

                case "Желтый":
                    CLcell = Color.Yellow;
                    break;
            }

            Wcell = Math.Abs(int.Parse(toolStripTextBox1.Text)); 
            control1.AddCell(cellGR, cellVR, CLcell, Wcell);
            
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            control1.DeleteCell();
        }

        private void построитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
            switch (toolStripComboBox2.SelectedItem)
            {
                case "Красный":
                    CLgraphic = Color.Red;
                    break;

                case "Зеленый":
                    CLgraphic = Color.Green;
                    break;

                case "Желтый":
                    CLgraphic = Color.Yellow;
                    break;
            }
            
            Wgraphic = int.Parse(toolStripTextBox2.Text);
            control1.ah = 2;
            control1.av = 2.5;          
            if(polynom) control1.AddPolynomGraphic(n, A, CLgraphic, Wgraphic);
        }

        private void добавитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form2 PointProp = new Form2();
            PointProp.Show();           
            
        }
       
       
        private void удалитьToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            control1.DeletePoints();
        }

        private void toolStripComboBox3_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void многочленToolStripMenuItem_Click(object sender, EventArgs e)
        {
            polynom = true;
            Form3 Polynom = new Form3();
            Polynom.Show();

        }

        private void toolStripComboBox3_TextUpdate(object sender, EventArgs e)
        {
            switch (toolStripComboBox3.Text)
            {
                case "Круг":
                    TypePoints = 0;
                    break;

                case "Квадрат":
                    TypePoints = 1;
                    break;

                case "Треугольник":
                    TypePoints = 2;
                    break;
             }
        }

        private void удалитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            control1.DeletePolynomGraphic();
        }

       
        private void отображениеToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            control1.SizePoints = int.Parse(toolStripTextBox3.Text);
            control1.TypePoints = TypePoints;                        
            control1.AddPoints(4, X, Y, Color.Red);            
        }

    }
}

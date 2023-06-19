using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double x = double.Parse(num1.Text);
                double y = double.Parse(num2.Text);
                double resultat = x * y;
                result.Text = resultat.ToString();
            }
            catch
            {
                MessageBox.Show("Error");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                double x = double.Parse(num1.Text);
                double y = double.Parse(num2.Text);
                double resultat = Math.Pow(x, y);
                result.Text = resultat.ToString();
            }
            catch
            {
                MessageBox.Show("Error");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                double x = double.Parse(num1.Text);
                double y = double.Parse(num2.Text);
                double resultat = (x + y) / 2;
                result.Text = resultat.ToString();
            }
            catch
            {
                MessageBox.Show("Error");
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void plus_Click(object sender, EventArgs e)
        {
            try
            {
                double x = double.Parse(num1.Text);
                double y = double.Parse(num2.Text);
                double resultat = x + y;
                result.Text = resultat.ToString();
            }
            catch
            {
                MessageBox.Show("Error");
            }

        }

        private void minus_Click(object sender, EventArgs e)
        {
            try
            {
                double x = double.Parse(num1.Text);
                double y = double.Parse(num2.Text);
                double resultat = x - y;
                result.Text = resultat.ToString();
            }
            catch
            {
                MessageBox.Show("Error");
            }

        }

        private void deleno_Click(object sender, EventArgs e)
        {
            try
            {
                double x = double.Parse(num1.Text);
                double y = double.Parse(num2.Text);
                if (y == 0)
                {
                    MessageBox.Show("Делителят не може да е 0!");
                }
                else
                {
                    double resultat = x / y;
                    result.Text = resultat.ToString();
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }

        }
    }
}

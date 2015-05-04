using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuadraticEquations
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Double.Parse(textBox1.Text);
            double b = Double.Parse(textBox2.Text);
            double c = Double.Parse(textBox3.Text);
            double bSqu = Math.Pow(b, 2);
            double fourAC = Math.Pow((bSqu - (4 * a * c)), .5);
            double xPositive = ((-1 * b) + fourAC) / (2 * a);
            double xNegative = ((-1 * b) - fourAC) / (2 * a);

            if ((bSqu - (4 * a * c))< 0)
            {
                double i = (bSqu - (4 * a * c)) / (-1);
                double iSqu = (Math.Pow(i, 0.5))/(2*a);
                double bI = (-1 * b) / (2 * a);
                
                label5.Text = "x is " + bI.ToString() + " + " + iSqu.ToString() + "i or " + bI.ToString() + " - " + iSqu.ToString()+"i";
            }
            else
            {

                label5.Text = "x is " + xPositive.ToString() + " or " + xNegative.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

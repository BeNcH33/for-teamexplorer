using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_equation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //label1.Text = "Hello world";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            int x;
            if (checkBox1.Checked == true)
            {
                if (int.TryParse(textBox_IN.Text,out x))
                {
                    double y = (((2 * x) - 7) / (Math.Sqrt((3 * x) + 21)));
                    label2.Text = y.ToString();
                    label2.Visible = true;
                }
                else
                {
                    MessageBox.Show("Введите число!");
                }
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            int x;
            if (checkBox2.Checked == true)
            {
                if (int.TryParse(textBox_IN.Text, out x))
                {
                    if (x == 1)
                    {
                        MessageBox.Show("При x=1, происходит деление на 0!");
                    }
                    else
                    {
                        double y = (Math.Sqrt(x / (x - 1)));
                        label3.Text = y.ToString();
                        label3.Visible = true;
                    }
                }
                else
                {
                    MessageBox.Show("Введите число!");
                }
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            int x;
            if (checkBox2.Checked == true)
            {
                if (int.TryParse(textBox_IN.Text, out x))
                {
                    if (x == 1)
                    {
                        MessageBox.Show("При x=1, происходит деление на 0!");
                    }
                    else
                    {
                        double y = ((x + 1) / (x - 1) + Math.Sqrt(x * x));
                        label4.Text = y.ToString();
                        label4.Visible = true;
                    }
                }
                else
                {
                    MessageBox.Show("Введите число!");
                }
            }
        }
    }
}


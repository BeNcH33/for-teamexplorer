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
        int x;
        public Form1()
        {
            InitializeComponent();
            //label1.Text = "Hello world";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                if (int.TryParse(textBox_IN.Text,out x))
                {
                    double y = (((2 * x) - 7) / (Math.Sqrt((3 * x) + 21)));
                    label2.Text = y.ToString();
                }
                else
                {
                    MessageBox.Show("Введите число!");
                }
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

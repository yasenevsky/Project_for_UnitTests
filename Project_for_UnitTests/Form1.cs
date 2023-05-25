using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_for_UnitTests
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public double Method1(double x)
        {
            double y = Math.Sin(x) * Math.Tan(x);
            return y;
        }
        public double Method2(double x)
        {
            double y = Math.Cos(x) * 3;
            return y;
        }
        public double Method3(double x)
        {
            double y = Math.Cos(x) * Math.Tan(x);
            return y;
        }
        public double DoubleRes(double x)
        {
            double y = x * 2;
            return y;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string x1 = textBox1.Text;
                double y = 0;
                double x = Convert.ToDouble(x1);
                if (x < 0)
                {
                    y = Method1(x);
                    radioButton1.Checked = true;
                }
                if (x == 0)
                {
                    y = Method2(x);
                    radioButton2.Checked = true;
                }
                if (x > 0)
                {
                    y = Method3(x);
                    radioButton3.Checked = true;
                }
                label5.Text = "" + y;
            }
            catch (FormatException)
            {
                MessageBox.Show("Что Вы наделали?!");
                textBox1.Focus();
                return;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                string x1 = label5.Text;
                double y = 0;
                double x = Convert.ToDouble(x1);
                if (checkBox1.Checked)
                {
                    y = DoubleRes(x);
                }
                else
                {
                    y = x / 2;
                }
                label5.Text = "" + y;
            }
            catch (FormatException)
            {
                MessageBox.Show("Нечего удваивать!");
                checkBox1.Checked = false;
                return;
            }

        }
    }
}

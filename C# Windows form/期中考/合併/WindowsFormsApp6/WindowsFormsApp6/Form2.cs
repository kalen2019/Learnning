using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double x, a, b,y;
                x = double.Parse(textBox1.Text);
                a = double.Parse(textBox2.Text);
                b = double.Parse(textBox3.Text);
                y = a * Math.Pow(x, 4) + b * Math.Pow(x, 2) - x;
                Ans1.Text = y.ToString();
            }
            catch
            {
                MessageBox.Show("請重新輸入");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double x, a, b, y;
                x = double.Parse(textBox4.Text);
                a = double.Parse(textBox5.Text);
                b = double.Parse(textBox6.Text);
                y = Math.Abs(a * Math.Pow(x, 3) - b * Math.Pow(x, 2)) + Math.Pow(x,0.5);
                Ans2.Text = y.ToString();
            }
            catch
            {
                MessageBox.Show("請重新輸入");
            }
        }
    }
}

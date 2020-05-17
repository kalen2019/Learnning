using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int a, b, c;
            Random random = new Random();
            a = random.Next(1, 7);
            b = random.Next(1, 7);
            c = random.Next(1, 7);
            label1.Text = a.ToString();
            label2.Text = b.ToString();
            label3.Text = c.ToString();
            label6.Text = "Total: " + (a + b + c).ToString();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            label6.Text = "Total: ";
            int a, b, c;
            Random random = new Random();
            a = random.Next(1, 7);
            b = random.Next(1, 7);
            c = random.Next(1, 7);
            label1.Text = a.ToString();
            label2.Text = b.ToString();
            label3.Text = c.ToString();
            if (a == b && b == c)
            {
                label7.Text = "Result: " + "豹子或一色";
            }
            else if (a == b || b == c || a == c)
            {
                if (a == b) label7.Text = "Result: " + c.ToString();
                if (a == c) label7.Text = "Result: " + b.ToString();
                if (b == c) label7.Text = "Result: " + a.ToString();
            }
            else if (a <= 3 && b <= 3 && c <= 3)
            {
                label7.Text = "Result: " + "逼機";
            }
            else label7.Text = "Result: 0";
        }
    }
}

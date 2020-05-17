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
        private int data1 = 0;
        private int op = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //Button button = (Button)sender;
            Button button = sender as Button;

            /*if (button.Text == "1") textBox1.Text += "1";
            if (button.Text == "2") textBox1.Text += "2";
            if (button.Text == "3") textBox1.Text += "3";*/

            if (button.Text == ".")
            {
                if (textBox1.Text.IndexOf('.') == -1)
                {
                    textBox1.Text += button.Text;
                }
                else textBox1.Text += button.Text;
            }
            else textBox1.Text += button.Text;
        }

        private void Button17_Click(object sender, EventArgs e)
        {
            /*string data = textBox1.Text;
            if (data.Length > 0)
            {
                data = data.Remove(data.Length - 1);
                textBox1.Text = data;
            }*/

            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            try
            {
                Button button = sender as Button;

                if (button.Text == "+") op = 1;
                if (button.Text == "*") op = 3;

                int data2 = int.Parse(textBox1.Text);
                if (op == 1) data1 += data2;
                if (op == 3)
                {
                    if (data1 == 0) data1 = data2;
                    else data1 *= data2;
                    
                }

                textBox1.Text = "";
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            try
            {
                int data2 = int.Parse(textBox1.Text);
                if (op == 1) data1 += data2;
                if (op == 3) data1 *= data2;
                textBox1.Text = data1.ToString();
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void Button18_Click(object sender, EventArgs e)
        {
            data1 = 0;
            textBox1.Text = "";
        }
    }
}

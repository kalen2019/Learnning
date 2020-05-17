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

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
            label4.Text = "";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // undo exception detect
            /*double result = double.Parse(textBox1.Text) + double.Parse(textBox2.Text);
            label4.Text = result.ToString();*/

            // exception detect using simple check
            /*string input1 = textBox1.Text;
            string input2 = textBox2.Text;

            double value1 = 0, value2 = 0;
            if (input1 != "") value1 = double.Parse(input1);
            if (input2 != "") value2 = double.Parse(input2);

            double value3 = value1 + value2;
            label4.Text = value3.ToString();*/

            // exception detect using TryParse
            /*string input1 = textBox1.Text;
            string input2 = textBox2.Text;

            int value1;
            bool conv1 = int.TryParse(input1, out value1);
            if(!conv1) //if(conv1 == false)
            {
                //label4.Text = "input format error.";
                MessageBox.Show("input format error.", "Error Message");
                return;
            }

            int value2;
            bool conv2 = int.TryParse(input2, out value2);
            if (!conv2) //if(conv1 == false)
            {
                //label4.Text = "input format error.";
                MessageBox.Show("input format error.", "Error Message");
                return;
            }

            int value3 = value1 + value2;
            label4.Text = value3.ToString();*/

            // exception detect using try catch
            try
            {
                string input1 = textBox1.Text;
                string input2 = textBox2.Text;

                double value1 = double.Parse(input1);
                double value2 = double.Parse(input2);

                double value3 = value1 + value2;
                label4.Text = value3.ToString();
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            double result = double.Parse(textBox1.Text) - double.Parse(textBox2.Text);
            label4.Text = result.ToString();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            double result = double.Parse(textBox1.Text) * double.Parse(textBox2.Text);
            label4.Text = result.ToString();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            double result = double.Parse(textBox1.Text) / double.Parse(textBox2.Text);
            label4.Text = result.ToString();
        }
    }
}

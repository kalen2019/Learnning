using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Calculator : Form
    {
        private float op = 0;
        private float data1 = 0;
        private float data2 = 0;
        private float data3 = 0;
        
        public Calculator()
        {
            InitializeComponent();

        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            Button button = sender as Button;

            if (button.Text == ".")
            {
                if (textBox1.Text.IndexOf('.') == -1)
                {
                    textBox1.Text += button.Text;
                }
                else textBox1.Text += "";
            }
            else if (button.Text == "0")
            {
                if (textBox1.Text == "0") { textBox1.Text += ""; }
                else textBox1.Text += "0";         
            }
            else if(textBox1.Text == "0"){ textBox1.Text = button.Text; }
            else { textBox1.Text += button.Text; }
            data2 = float.Parse(textBox1.Text);
        }

        private void back_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
        }

        private void sign_Click(object sender, EventArgs e)
        {
            try
            {
                
                data2 = float.Parse(textBox1.Text);
                data2 = data2 - 2 * data2;
                textBox1.Text = data2.ToString();
            }
            catch
            {
                textBox1.Text += "";
            }

        }

        private void plus_Click(object sender, EventArgs e)
        {
            try
            {
                if (data3 == 0)
                {
                    data2 = float.Parse(textBox1.Text);
                    data1 = data2;
                    data2 = 0;
                    data3 += 1;
                }
                if (op == 1) { data1 = data1 + data2; op = 0; }
                if (op == 2) { data1 = data1 - data2; op = 0; }
                if (op == 3) { data1 = data1 * data2; op = 0; }
                if (op == 4) { data1 = data1 / data2; op = 0; }
                Button button = sender as Button;
                if (data3 != 0)
                {
                    
                   
                    if (button.Text == "+")
                    {
                        if (textBox1.Text == "")
                        {
                            label2.Text = label2.Text + data2.ToString() + "+";
                        }
                        else
                        {
                            label2.Text += textBox1.Text + "+";
                        }
                            textBox1.Text = "";
                            op = 1;
                    }
                    if (button.Text == "-")
                    {
                        if (textBox1.Text == "")
                        {
                            label2.Text = label2.Text + data2.ToString() + "-";
                        }
                        else
                        {
                            label2.Text += textBox1.Text + "-";
                        }
                            textBox1.Text = "";
                            op = 2;
                    }
                    if (button.Text == "*")
                    {
                        if (textBox1.Text == "")
                        {
                            label2.Text = label2.Text + data2.ToString() + "*";
                        }
                        else
                        {
                            label2.Text += textBox1.Text + "*";
                        }
                            textBox1.Text = "";
                            op = 3;
                    }
                    if (button.Text == "/")
                    {
                        if (textBox1.Text == "")
                        {
                            label2.Text = label2.Text + data2.ToString() + "/";
                        }
                        else
                        {
                            label2.Text += textBox1.Text + "/";
                        }
                            textBox1.Text = "";
                            op = 4;
                    }
                label1.Text = "=" + data1.ToString();
                }
            }
            catch
            {
                textBox1.Text += "";
            }
        }
        private void equal_Click(object sender, EventArgs e)
        {
            try
            {
                Button button = sender as Button;
                if (button.Text == "=")
                {
                    if (op == 0) data1 = data2;
                    if (op == 1) data1 = data1 + data2;
                    if (op == 2) data1 = data1 - data2;
                    if (op == 3) data1 = data1 * data2;
                    if (op == 4) data1 = data1 / data2;
                    textBox1.Text = data1.ToString();
                    label1.Text = "";
                    label2.Text = "";
                    op = 0;
                    data3 = 0;
                }
            }
            catch
            {
                textBox1.Text += "";
            }

        }
            private void percent_Click(object sender, EventArgs e)
        {
            try
            {
                Button button = sender as Button;
                
                if (button.Text == "%")
                {
                    for(int i = 0;i < textBox1.Text.Length; i++)
                    {
                        if (textBox1.Text.Substring(i) == "%")
                        {
                            textBox1.Text = "";
                            break;
                        }
                        else
                        {
                            textBox1.Text += "%";
                            break;
                        }
                    }
                    data2 = data2 / 100;    
                }

                
            }
            catch
            {
                textBox1.Text += "";
            }
        }

        private void C_Click(object sender, EventArgs e)
        {
            data1 = 0;
            data2 = 0;
            data3 = 0;
            op = 0;
            label1.Text = "";
            label2.Text = "";
            textBox1.Text = "";
        }

        private void CE_Click(object sender, EventArgs e)
        {
                data2 = 0;
                textBox1.Text = "";
        }


    }
}

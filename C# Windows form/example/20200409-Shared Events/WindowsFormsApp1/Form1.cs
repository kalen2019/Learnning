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

        private void Button1_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            /*if (button.Text == "1") textBox1.Text += "1";
            if (button.Text == "2") textBox1.Text += "2";
            if (button.Text == "3") textBox1.Text += "3";*/
            textBox1.Text += button.Text;
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
    }
}

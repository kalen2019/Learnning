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
            string input1 = textBox1.Text;
            string input2 = textBox2.Text;
            int a = int.Parse(input1);
            int b = int.Parse(input2);
            int c = a + b;
            label3.Text = "Result: " + c.ToString();
        }
    }
}

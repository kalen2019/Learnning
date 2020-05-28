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


        private void button1_Click(object sender, EventArgs e)
        {
            if (label1.Text == "Red")
            {
                label1.Text = "Yellow";
                label1.ForeColor = Color.Yellow;
                label1.BackColor = Color.Blue;
                label2.Text = "Blue";
                label2.ForeColor = Color.Blue;
                label2.BackColor = Color.Red;
                label3.Text = "Red";
                label3.ForeColor = Color.Red;
                label3.BackColor = Color.Yellow;
            }
            else if (label1.Text == "Yellow")
            {
                label1.Text = "Blue";
                label1.ForeColor = Color.Blue;
                label1.BackColor = Color.Red;
                label2.Text = "Red";
                label2.ForeColor = Color.Red;
                label2.BackColor = Color.Yellow;
                label3.Text = "Yellow";
                label3.ForeColor = Color.Yellow;
                label3.BackColor = Color.Blue;
            }
            else if (label1.Text == "Blue")
            {
                label1.Text = "Red";
                label1.ForeColor = Color.Red;
                label1.BackColor = Color.Yellow;
                label2.Text = "Yellow";
                label2.ForeColor = Color.Yellow;
                label2.BackColor = Color.Blue;
                label3.Text = "Blue";
                label3.ForeColor = Color.Blue;
                label3.BackColor = Color.Red;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (label1.Text == "Red")
            {
                label1.Text = "Blue";
                label1.ForeColor = Color.Blue;
                label1.BackColor = Color.Red;
                label2.Text = "Red";
                label2.ForeColor = Color.Red;
                label2.BackColor = Color.Yellow;
                label3.Text = "Yellow";
                label3.ForeColor = Color.Yellow;
                label3.BackColor = Color.Blue;
            }
            else if (label1.Text == "Yellow")
            {
                label1.Text = "Red";
                label1.ForeColor = Color.Red;
                label1.BackColor = Color.Yellow;
                label2.Text = "Yellow";
                label2.ForeColor = Color.Yellow;
                label2.BackColor = Color.Blue;
                label3.Text = "Blue";
                label3.ForeColor = Color.Blue;
                label3.BackColor = Color.Red;
            }
            else if (label1.Text == "Blue")
            {
                label1.Text = "Yellow";
                label1.ForeColor = Color.Yellow;
                label1.BackColor = Color.Blue;
                label2.Text = "Blue";
                label2.ForeColor = Color.Blue;
                label2.BackColor = Color.Red;
                label3.Text = "Red";
                label3.ForeColor = Color.Red;
                label3.BackColor = Color.Yellow;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

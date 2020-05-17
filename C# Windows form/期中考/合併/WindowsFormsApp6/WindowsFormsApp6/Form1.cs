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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(label1.Text == "紅燈")
            {
                label1.Text = "綠燈";
                label1.ForeColor = Color.Green;
                label2.Text = "藍燈";
                label2.ForeColor = Color.Blue;
                label3.Text = "紅燈";
                label3.ForeColor = Color.Red;
            }
             else if(label1.Text == "綠燈")
            {
                label1.Text = "藍燈";
                label1.ForeColor = Color.Blue;
                label2.Text = "紅燈";
                label2.ForeColor = Color.Red;
                label3.Text = "綠燈";
                label3.ForeColor = Color.Green;
            }
            else if(label1.Text == "藍燈")
            {
                label1.Text = "紅燈";
                label1.ForeColor = Color.Red;
                label2.Text = "綠燈";
                label2.ForeColor = Color.Green;
                label3.Text = "藍燈";
                label3.ForeColor = Color.Blue;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(label1.Text == "紅燈")
            {
                label1.Text = "藍燈";
                label1.ForeColor = Color.Blue;
                label2.Text = "紅燈";
                label2.ForeColor = Color.Red;
                label3.Text = "綠燈";
                label3.ForeColor = Color.Green;
            }
            else if(label1.Text == "藍燈")
            {
                label1.Text = "綠燈";
                label1.ForeColor = Color.Green;
                label2.Text = "藍燈";
                label2.ForeColor = Color.Blue;
                label3.Text = "紅燈";
                label3.ForeColor = Color.Red;
            }
            else if (label1.Text == "綠燈")
            {
                label1.Text = "紅燈";
                label1.ForeColor = Color.Red;
                label2.Text = "綠燈";
                label2.ForeColor = Color.Green;
                label3.Text = "藍燈";
                label3.ForeColor = Color.Blue;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int a;
            a = random.Next(1, 6);
            if (a == 1)
            {
                label1.Text = "紅燈";
                label1.ForeColor = Color.Red;
                label2.Text = "綠燈";
                label2.ForeColor = Color.Green;
                label3.Text = "藍燈";
                label3.ForeColor = Color.Blue;
            }
            if (a == 2)
            {
                label1.Text = "紅燈";
                label1.ForeColor = Color.Red;
                label2.Text = "藍燈";
                label2.ForeColor = Color.Blue;
                label3.Text = "綠燈";
                label3.ForeColor = Color.Green;
            }
            if (a == 3)
            {
                label1.Text = "綠燈";
                label1.ForeColor = Color.Green;
                label2.Text = "紅燈";
                label2.ForeColor = Color.Red;
                label3.Text = "藍燈";
                label3.ForeColor = Color.Blue;
            }
            if (a == 4)
            {
                label1.Text = "綠燈";
                label1.ForeColor = Color.Green;
                label2.Text = "藍燈";
                label2.ForeColor = Color.Blue;
                label3.Text = "紅燈";
                label3.ForeColor = Color.Red;
            }
            if (a == 5)
            {
                label1.Text = "藍燈";
                label1.ForeColor = Color.Blue;
                label2.Text = "綠燈";
                label2.ForeColor = Color.Green;
                label3.Text = "紅燈";
                label3.ForeColor = Color.Red;
            }
            if (a == 6)
            {
                label1.Text = "藍燈";
                label1.ForeColor = Color.Blue;
                label2.Text = "紅燈";
                label2.ForeColor = Color.Red;
                label3.Text = "綠燈";
                label3.ForeColor = Color.Green;
            }
        }   
    }
}

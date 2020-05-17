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

        int count;

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label1.Text = "Speed:" + trackBar1.Value.ToString();
            timer1.Interval = trackBar1.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (timer1.Enabled == false || label3.Text == "Boom!!")
                {
                    count = int.Parse(textBox1.Text);
                    timer1.Enabled = true;
                }
                else MessageBox.Show("The time is not complete");
            }
            catch
            {
                MessageBox.Show("Please enter the time!!");
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (count > 0)
            {
                label3.Text = count.ToString();
                count--;
            }
            else label3.Text = "Boom!!";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
                if (count > 0)
                {
                    timer1.Enabled = true;
                }
        }
    }
}

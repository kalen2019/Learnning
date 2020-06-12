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
        private int count;

        public Form1()
        {
            InitializeComponent();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = count.ToString();
            if(count > 0) count--;
            else
            {
                Bitmap bitmap = new Bitmap(@"pic/boom.jpg");
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Image = bitmap;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            count = int.Parse(textBox1.Text);
            timer1.Enabled = true;
            pictureBox1.Image = null;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void TrackBar1_Scroll(object sender, EventArgs e)
        {
            label2.Text = trackBar1.Value.ToString();
            timer1.Interval = trackBar1.Value;
        }
    }
}

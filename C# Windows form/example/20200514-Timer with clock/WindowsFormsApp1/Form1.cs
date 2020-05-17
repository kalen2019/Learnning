using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private bool flag = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now.AddMinutes(10);
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss");

            if(DateTime.Now >= dateTimePicker1.Value && flag)
            {
                flag = false;

                Bitmap bitmap = new Bitmap(@"pic\boom.jpg");
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Image = bitmap;

                SoundPlayer soundPlayer = new SoundPlayer();
                soundPlayer.SoundLocation = @"sound/chaha.wav";
                soundPlayer.Play();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            flag = true;
        }
    }
}

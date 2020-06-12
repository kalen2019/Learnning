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
        int[] answer = new int[6] { 1, 1, 2, 2, 3, 3 };
        int perState = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void CardReset()
        {
            Bitmap bitmap = new Bitmap(@"images\Tarot.jpeg");
            pictureBox1.Image = bitmap;
            pictureBox2.Image = bitmap;
            pictureBox3.Image = bitmap;
            pictureBox4.Image = bitmap;
            pictureBox5.Image = bitmap;
            pictureBox6.Image = bitmap;
        }

        private void Shuffle()
        {
            Random random = new Random();
            for (int n = 0; n < 6; n++)
            {
                int k = random.Next(n);
                int value = answer[n];
                answer[n] = answer[k];
                answer[k] = value;
            }
        }

        private void ShowAnswer()
        {
            pictureBox1.Image = new Bitmap(@"images\" + answer[0] + ".jpg");
            pictureBox2.Image = new Bitmap(@"images\" + answer[1] + ".jpg");
            pictureBox3.Image = new Bitmap(@"images\" + answer[2] + ".jpg");
            pictureBox4.Image = new Bitmap(@"images\" + answer[3] + ".jpg");
            pictureBox5.Image = new Bitmap(@"images\" + answer[4] + ".jpg");
            pictureBox6.Image = new Bitmap(@"images\" + answer[5] + ".jpg");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Shuffle();
            CardReset();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            /*Bitmap bitmap = null;
            if (answer[0] == 1) bitmap = new Bitmap(@"images\1.jpg");
            else if (answer[0] == 2) bitmap = new Bitmap(@"images\2.jpg");
            else if (answer[0] == 3) bitmap = new Bitmap(@"images\3.jpg");*/

            /*Bitmap bitmap = null;
            PictureBox pictureBox = sender as PictureBox;
            if (pictureBox.Name == "pictureBox1") bitmap = new Bitmap(@"images\" + answer[0] + ".jpg");
            else if (pictureBox.Name == "pictureBox2") bitmap = new Bitmap(@"images\" + answer[1] + ".jpg");
            else if (pictureBox.Name == "pictureBox3") bitmap = new Bitmap(@"images\" + answer[2] + ".jpg");
            else if (pictureBox.Name == "pictureBox4") bitmap = new Bitmap(@"images\" + answer[3] + ".jpg");
            else if (pictureBox.Name == "pictureBox5") bitmap = new Bitmap(@"images\" + answer[4] + ".jpg");
            else if (pictureBox.Name == "pictureBox6") bitmap = new Bitmap(@"images\" + answer[5] + ".jpg");*/

            PictureBox pictureBox = sender as PictureBox;
            string number = pictureBox.Name.Substring(10, pictureBox.Name.Length-10);
            int index = int.Parse(number);
            Bitmap bitmap = new Bitmap(@"images\" + answer[index-1] + ".jpg");

            pictureBox.Image = bitmap;

            Application.DoEvents();
            System.Threading.Thread.Sleep(500);

            int nowState = answer[index - 1];

            if (perState != 0)
            {
                if (nowState != perState)
                {
                    CardReset();
                    perState = 0;
                }
            }

            perState = nowState;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CardReset();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Shuffle();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShowAnswer();
        }
    }
}

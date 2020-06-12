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
        private List<Bitmap> BitmapsList = new List<Bitmap>();
        private List<PictureBox> PictureBoxList = new List<PictureBox>();

        private int[] answer = new int[6] { 1, 1, 2, 2, 3, 3 };
        private int perState = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void CardReset()
        {
            for (int i = 0; i < PictureBoxList.Count; i++)
            {
                PictureBoxList[i].Image = BitmapsList[0];
            }
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
            for (int i = 0; i < PictureBoxList.Count; i++)
            {
                PictureBoxList[i].Image = BitmapsList[i+1];
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PictureBoxList.Add(pictureBox1);
            PictureBoxList.Add(pictureBox2);
            PictureBoxList.Add(pictureBox3);
            PictureBoxList.Add(pictureBox4);
            PictureBoxList.Add(pictureBox5);
            PictureBoxList.Add(pictureBox6);

            BitmapsList.Add(new Bitmap(@"images\Tarot.jpeg"));
            BitmapsList.Add(new Bitmap(@"images\1.jpg"));
            BitmapsList.Add(new Bitmap(@"images\2.jpg"));
            BitmapsList.Add(new Bitmap(@"images\3.jpg"));

            Shuffle();
            CardReset();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            string number = pictureBox.Name.Substring(10, pictureBox.Name.Length-10);
            int index = int.Parse(number);
            int ans = answer[index - 1];
            pictureBox.Image = BitmapsList[ans];

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

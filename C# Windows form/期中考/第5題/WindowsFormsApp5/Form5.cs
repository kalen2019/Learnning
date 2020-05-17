using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Bitmap player = new Bitmap(@"pic\player.png");
            pictureBox1.Image = player;
            Bitmap computer = new Bitmap(@"pic\computer.png");
            pictureBox2.Image = computer;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Button button = sender as Button;
            Random random = new Random();

            

            if (button.Name == "button1")//剪刀
            {
                int a = 1;
                int b = random.Next(1,4);
                if(b == 1) label2.Text = "Result:Draw!!";
                if(b == 2) label2.Text = "Result:You Loss!!";
                if(b == 3) label2.Text = "Result:You Win!!";
                Bitmap imageA = new Bitmap(@"pic\" + a.ToString() + ".png");
                Bitmap imageB = new Bitmap(@"pic\" + b.ToString() + ".png");
                pictureBox1.Image = imageA;
                pictureBox2.Image = imageB;
            }
            if (button.Name == "button2")//石頭
            {
                int a = 2;
                int b = random.Next(1, 4);
                if (b == 1) label2.Text = "Result:You Win!!";
                if (b == 2) label2.Text = "Result:Draw!!";
                if (b == 3) label2.Text = "Result:You Loss!!";
                Bitmap imageA = new Bitmap(@"pic\" + a.ToString() + ".png");
                Bitmap imageB = new Bitmap(@"pic\" + b.ToString() + ".png");
                pictureBox1.Image = imageA;
                pictureBox2.Image = imageB;
            }
            if (button.Name == "button3")//布
            {
                int a = 3;
                int b = random.Next(1, 4);
                if (b == 1) label2.Text = "Result:You Loss!!";
                if (b == 2) label2.Text = "Result:You Win!!";
                if (b == 3) label2.Text = "Result:Draw!!";
                Bitmap imageA = new Bitmap(@"pic\" + a.ToString() + ".png");
                Bitmap imageB = new Bitmap(@"pic\" + b.ToString() + ".png");
                pictureBox1.Image = imageA;
                pictureBox2.Image = imageB;
            }
            if (button.Name == "button4")//restart
            {
                Bitmap player = new Bitmap(@"pic\player.png");
                pictureBox1.Image = player;
                Bitmap computer = new Bitmap(@"pic\computer.png");
                pictureBox2.Image = computer;
                label2.Text = "Result:";
            }
        }


    }
}

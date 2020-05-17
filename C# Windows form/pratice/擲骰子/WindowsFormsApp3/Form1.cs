using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Image image1 = new Bitmap(@"dice/Q.png");
            pictureBox1.Image = image1;
            pictureBox2.Image = image1;
            pictureBox3.Image = image1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            int a = random.Next(1, 7);
            int b = random.Next(1, 7);
            int c = random.Next(1, 7);

            label1.Text = a.ToString();
            label2.Text = b.ToString();
            label3.Text = c.ToString();

            Image image1 = new Bitmap(@"dice/"+a.ToString()+".jpg");
            Image image2 = new Bitmap(@"dice/"+b.ToString()+".jpg");
            Image image3 = new Bitmap(@"dice/"+c.ToString()+".jpg");
            pictureBox1.Image = image1;
            pictureBox2.Image = image2;
            pictureBox3.Image = image3;


        }


    }
}

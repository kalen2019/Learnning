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
            int a, b, c;
            Random random = new Random();
            a = random.Next(1, 6);
            b = random.Next(1, 6);
            c = random.Next(1, 6);

            label1.Text = a.ToString();
            label2.Text = b.ToString();
            label3.Text = c.ToString();

            string filePath = @"dice\" + a.ToString() +  ".jpg";
            Bitmap bitmap = new Bitmap(filePath);
            pictureBox2.Image = bitmap;

            filePath = @"dice\" + b.ToString() + ".jpg";
            bitmap = new Bitmap(filePath);
            pictureBox3.Image = bitmap;

            filePath = @"dice\" + c.ToString() + ".jpg";
            bitmap = new Bitmap(filePath);
            pictureBox4.Image = bitmap;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\Public\Pictures\Sample Pictures\Koala.jpg";
            Bitmap bitmap = new Bitmap(filePath);
            pictureBox1.Image = bitmap;
        }
    }
}

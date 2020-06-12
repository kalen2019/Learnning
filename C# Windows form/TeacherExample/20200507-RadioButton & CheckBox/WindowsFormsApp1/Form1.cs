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

        private void Form1_Load(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(@"food\排骨飯.jpg");
            pictureBox1.Image = bitmap;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int price = 0;

            if(radioButton1.Checked == true) price = 75;
            else if(radioButton2.Checked == true) price = 80;
            else if(radioButton3.Checked == true) price = 70;
            else if(radioButton4.Checked == true) price = 50;

            if (checkBox1.Checked == true) price += 15;
            if (checkBox2.Checked == true) price += 20;
            if (checkBox3.Checked == true) price += 10;

            label1.Text = "價格：" + price.ToString() + "元";
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                Bitmap bitmap = new Bitmap(@"food\排骨飯.jpg");
                pictureBox1.Image = bitmap;
            }
            else if (radioButton2.Checked)
            {
                Bitmap bitmap = new Bitmap(@"food\雞腿飯.jpg");
                pictureBox1.Image = bitmap;
            }
            else if (radioButton3.Checked)
            {
                Bitmap bitmap = new Bitmap(@"food\魚排飯.jpg");
                pictureBox1.Image = bitmap;
            }
            else if (radioButton4.Checked)
            {
                Bitmap bitmap = new Bitmap(@"food\滷肉飯.jpg");
                pictureBox1.Image = bitmap;
            }

            /*RadioButton radioButton = sender as RadioButton;
            if (radioButton.Checked)
            {
                string fileName = radioButton.Text.Substring(0, 3);
                Bitmap bitmap = new Bitmap(@"food\" + fileName + ".jpg");
                pictureBox1.Image = bitmap;
            }*/
        }
    }
}

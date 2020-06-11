using AnimatedGif;
using ClassLibrary1;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MyMath myMath = new MyMath();
            int z = myMath.add(3, 4);
            MessageBox.Show(z.ToString());
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            int z = MyMath2.add(3, 4);
            MessageBox.Show(z.ToString());

            Math.Pow(2, 3);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Class1 class1 = new Class1();
            int z = class1.add(3, 4);
            MessageBox.Show(z.ToString());
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            string json = JsonConvert.SerializeObject(null);
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            using (var gif = AnimatedGif.AnimatedGif.Create("test.gif", 33))
            {
                var img1 = Image.FromFile("1.jpg");
                gif.AddFrame(img1, delay: -1, quality: GifQuality.Bit8);
                var img2 = Image.FromFile("2.jpg");
                gif.AddFrame(img2, delay: -1, quality: GifQuality.Bit8);
                var img3 = Image.FromFile("3.jpg");
                gif.AddFrame(img3, delay: -1, quality: GifQuality.Bit8);
            }
        }
    }
}

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
        private int index = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "jpg files (*.jpg)|*.jpg|bmp files (*.bmp)|*.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                listBox1.Items.Add(openFileDialog.FileName);
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (listBox1.Items.Count <= 0) return;

            timer1.Interval = hScrollBar1.Value;

            string fileName = listBox1.Items[index].ToString();
            Bitmap bitmap = new Bitmap(fileName);
            pictureBox1.Image = bitmap;
            index++;
            if (index > listBox1.Items.Count - 1) index = 0;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }
    }
}

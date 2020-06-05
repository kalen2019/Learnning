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
        private int coorX = 10;
        private bool flag = true;
        private bool sizeFlag = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            coorX = 10;
            label1.Font = new Font(label1.Font.FontFamily, 24);
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            label1.Location = new Point(coorX, 100);
            if (flag) coorX += 10;
            else coorX -= 10;

            if (coorX > 340) flag = false;
            if (coorX < 0) flag = true;

            if (checkBox1.Checked)
            {
                float size = label1.Font.Size;
                if (sizeFlag) size++;
                else size--;

                if (size > 48) sizeFlag = false;
                if (size < 24) sizeFlag = true;

                label1.Font = new Font(label1.Font.FontFamily, size);
            }

            if (checkBox2.Checked)
            {
                Random rand = new Random();
                label1.ForeColor = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            }
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

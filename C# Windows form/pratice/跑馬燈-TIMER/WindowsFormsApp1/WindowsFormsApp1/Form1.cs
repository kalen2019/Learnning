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
        private int SiteX = 150;
        private int SiteY = 150;
        private int op = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Location = new Point(SiteX,SiteY);
            if (SiteX <= 0 && SiteY <= 0) op = 0;
            if (SiteX >= 300 && SiteY <= 0) op = 1;
            if (SiteX >= 300 && SiteY >= 200) op = 2;
            if (SiteX <= 0 && SiteY >= 200) op = 3;

            if (op == 0) SiteX += 10;
            if (op == 1) SiteY += 10;
            if (op == 2) SiteX -= 10;
            if (op == 3) SiteY -= 10;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SiteX = 0;
            SiteY = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }
    }
}

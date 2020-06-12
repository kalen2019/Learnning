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
        private bool flag = false;
        private Point startPoint;

        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_MouseDown(object sender, MouseEventArgs e)
        {
            startPoint = e.Location;
            flag = true;
        }

        private void Button1_MouseMove(object sender, MouseEventArgs e)
        {
            if (flag)
            {
                int moveX = e.X - startPoint.X;
                int moveY = e.Y - startPoint.Y;
                button1.Location = new Point(button1.Location.X + moveX, button1.Location.Y + moveY);
            }
        }

        private void Button1_MouseUp(object sender, MouseEventArgs e)
        {
            flag = false;
        }
    }
}

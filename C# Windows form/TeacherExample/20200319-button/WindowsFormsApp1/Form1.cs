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

        private void Button1_MouseDown(object sender, MouseEventArgs e)
        {
            button1.Text = "DOWN";
        }

        private void Button1_MouseUp(object sender, MouseEventArgs e)
        {
            button1.Text = "UP";
        }

        private void Button1_MouseEnter(object sender, EventArgs e)
        {
            button1.Text = "ENTER";
        }

        private void Button1_MouseLeave(object sender, EventArgs e)
        {
            button1.Text = "LEAVE";
        }
    }
}

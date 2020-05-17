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

        private void Button2_Click(object sender, EventArgs e)
        {
            if (label1.Text == "Red")
            {
                label1.Text = "Yellow";
                label1.ForeColor = Color.Yellow;
                label2.Text = "Green";
                label2.ForeColor = Color.Green;
                label3.Text = "Red";
                label3.ForeColor = Color.Red;
            }
            else if (label1.Text == "Yellow")
            {
                label1.Text = "Green";
                label1.ForeColor = Color.Green;
                label2.Text = "Red";
                label2.ForeColor = Color.Red;
                label3.Text = "Yellow";
                label3.ForeColor = Color.Yellow;
            }
            else if (label1.Text == "Green")
            {
                label1.Text = "Red";
                label1.ForeColor = Color.Red;
                label2.Text = "Yellow";
                label2.ForeColor = Color.Yellow;
                label3.Text = "Green";
                label3.ForeColor = Color.Green;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
            for(int i=1;i<=10;i++)
            {
                chart1.Series[0].Points.AddXY(i+10, i);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.AddXY("國文", 1);
            chart1.Series[0].Points.AddXY("英文", 5);
            chart1.Series[0].Points.AddXY("數學", 10);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            for (int i = 1; i <= 10; i++)
            {
                chart1.Series[0].Points.Add(i);
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            for (double i=0;i<=2*Math.PI;i+=0.1)
            {
                double y = Math.Sin(i);
                chart1.Series[0].Points.AddXY(i, y);
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int d = rand.Next(100);
            chart1.Series[0].Points.Add(d);

            if(chart1.Series[0].Points.Count > 20)
            {
                chart1.Series[0].Points.RemoveAt(0);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp6;

namespace WindowsFormsApp6
{
    public partial class Form6 : Form
    {
        private Form form1;
        private Form form2;
        private Form form3;
        private Form form4;
        private Form form5;

        public Form6()
        {
            InitializeComponent();
        }
        private void Form6_Load(object sender, EventArgs e)
        {
            form1 = new Form1();
            form2 = new Form2();
            form3 = new Form3();
            form4 = new Form4();
            form5 = new Form5();
            form1.StartPosition = FormStartPosition.CenterScreen;
            form2.StartPosition = FormStartPosition.CenterScreen;
            form3.StartPosition = FormStartPosition.CenterScreen;
            form4.StartPosition = FormStartPosition.CenterScreen;
            form5.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.StartPosition = FormStartPosition.CenterScreen;
            form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.StartPosition = FormStartPosition.CenterScreen;
            form2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.StartPosition = FormStartPosition.CenterScreen;
            form3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.StartPosition = FormStartPosition.CenterScreen;
            form4.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.StartPosition = FormStartPosition.CenterScreen;
            form5.Show();
        }
    }
}

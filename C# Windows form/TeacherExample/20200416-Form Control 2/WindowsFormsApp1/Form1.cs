﻿using System;
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
        private Form2 form2;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            form2 = new Form2();
            form2.StartPosition = FormStartPosition.CenterScreen;
            form2.form1 = this;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            form2.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            form2.Hide();
        }
    }
}

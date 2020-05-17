using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string password = textBox1.Text.ToString();
                int [] a = { 0, 0, 0, 0};
                if (password.Length < 5) MessageBox.Show("請輸入至少5個字");
                else
                {
                    for(int i = 0; i < password.Length; i++)
                    {
                        if (password[i] >= 48 && password[i] <= 57)
                        {
                            a[0] = 1;
                        }
                        else if (password[i] >= 65 && password[i] <= 90)
                        {
                            a[1] = 1;
                        }
                        else if (password[i] >= 97 && password[i] <= 122)
                        {
                            a[2] = 1;
                        }
                        else a[3] = 1;
                    }
                    if (a[3] == 1) MessageBox.Show("錯誤");
                    else if (a[0] == 1 && a[1] == 1 && a[2] == 1) MessageBox.Show("通過");
                    else if (a[0] == 0) MessageBox.Show("至少填入一個數字");
                    else if (a[1] == 0) MessageBox.Show("至少填入一個大寫字母");
                    else if (a[2] == 0) MessageBox.Show("至少填入一個小寫字母");
                }
                

                
            }
            catch
            {
                MessageBox.Show("錯誤");
            }
        }
    }
}

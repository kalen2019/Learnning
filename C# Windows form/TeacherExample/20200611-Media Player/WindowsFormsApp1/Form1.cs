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

            axWindowsMediaPlayer1.URL = @"C:\Users\Public\Videos\Sample Videos\Wildlife.wmv";
            axWindowsMediaPlayer2.URL = @"C:\Users\Public\Videos\Sample Videos\Wildlife.wmv";
        }
    }
}

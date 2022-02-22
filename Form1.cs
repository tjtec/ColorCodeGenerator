using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    
    public partial class Form1 : Form
    {
        public bool isopen = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            colorDialog1.FullOpen = true;
            colorDialog1.ShowDialog();
            label1.Text = "#"+(colorDialog1.Color.ToArgb() & 0x00FFFFFF).ToString("X6");
            BackColor = colorDialog1.Color;
            button1.BackColor = colorDialog1.Color;
            if(0.5 > colorDialog1.Color.GetBrightness())
            {
                label1.ForeColor = Color.White;
                label2.ForeColor = Color.White;
                label3.ForeColor = Color.White;
                button1.ForeColor = Color.White;
                label4.ForeColor = Color.White;
            }
            if (0.5 < colorDialog1.Color.GetBrightness())
            {
                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
                label3.ForeColor = Color.Black;
                button1.ForeColor = Color.Black;
                label4.ForeColor = Color.Black;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(label1.Text);
        }

        private void notifyIcon1_Click(object sender, MouseEventArgs e)
        {
            if (isopen == false)
            {
                isopen = true;
                Show();
                this.WindowState = FormWindowState.Minimized;
                this.Show();
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                isopen = false;
                Hide();
            }

        }
    }
}

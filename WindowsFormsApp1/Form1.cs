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

        Random rnd = new Random();
        int deltx = 10;
        int delty = 10;
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.label1.Left += deltx;
            this.label1.Top += delty;
            if (this.label1.Top < 0 ||
                this.label1.Top + this.label1.Height > this.Height)
                delty = -delty;
            if (this.label1.Left < 0 ||
                this.label1.Left + this.label1.Width > this.Width)
                deltx = -deltx;
            this.BackColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            this.label1.BackColor= Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            this.label1.Text = e.X + "," + e.Y;
            this.label2.Text = this.label1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.timer1.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

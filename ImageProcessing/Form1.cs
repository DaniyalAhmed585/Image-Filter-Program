using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageProcessing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.Image = System.Drawing.Bitmap.FromFile(openFileDialog1.FileName);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            int x = bmp.Width;
            int y = bmp.Height;
            Color c;
            for(int i=0;i<y;i++)
            {
                for(int j=0;j<x;j++)
                {
                    c = bmp.GetPixel(j, i);
                    int r = 255-c.R;
                    int g = 255-c.G;
                    int b = 255-c.B;
                    int a = c.A;
                    bmp.SetPixel(j, i, Color.FromArgb(a, r, g, b));
                }
            }
            pictureBox2.Image = bmp;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            int x = bmp.Width;
            int y = bmp.Height;
            Color c;
            for (int i = 0; i < y; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    c = bmp.GetPixel(j, i);
                    int r = c.R;
                    int g = c.G;
                    int b = c.B;
                    int a = c.A;
                    int avg = (r + g + b) / 3;
                    bmp.SetPixel(j, i, Color.FromArgb(a,avg,avg,avg));
                }
            }
            pictureBox2.Image = bmp;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            int x = bmp.Width;
            int y = bmp.Height;
            Color c;
            for (int i = 0; i < y; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    c = bmp.GetPixel(j, i);
                    int r = 0;
                    int g = c.G;
                    int b = c.B;
                    int a = c.A;
                    bmp.SetPixel(j, i, Color.FromArgb(a, r, g, b));
                }
            }
            pictureBox2.Image = bmp;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            int x = bmp.Width;
            int y = bmp.Height;
            Color c;
            for (int i = 0; i < y; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    c = bmp.GetPixel(j, i);
                    int r = c.R;
                    int g = c.G;
                    int b = c.B;
                    int a = Convert.ToInt32(numericUpDown1.Value);
                    bmp.SetPixel(j, i, Color.FromArgb(a,r,g,b));
                }
            }
            pictureBox2.Image = bmp;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            Bitmap bmp = new Bitmap(pictureBox1.Image);
            int x = bmp.Width;
            int y = bmp.Height;
            Color c;
            for (int i = 0; i < y; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    c = bmp.GetPixel(j, i);
                }
            }
            //textBox1.Text = System.Drawing.Bitmap
        }
    }

}

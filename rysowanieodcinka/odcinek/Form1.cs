using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace odcinek
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            pictureBox1.Image = null;
            Bitmap obraz = new Bitmap(300, 300);
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
            {
                int ax = Convert.ToInt32(textBox1.Text);
                int ay = Convert.ToInt32(textBox2.Text);
                int bx = Convert.ToInt32(textBox3.Text);
                int by = Convert.ToInt32(textBox4.Text);
                if(ax>bx)
                {
                    int t = ax;
                    ax = bx;
                    bx = t;
                    t = ay;
                    ay = by;
                    by = t;

                }
                double x;
                double dy, dx, y, m;
                dy = by - ay;
                dx = bx - ax;
                if (bx-ax >= by-ay)
                {
                    m = dy / dx;
                    y = ay;
                    for (x = ax; x < bx; x++)
                    {
                        if (x < 300)
                        {
                            obraz.SetPixel(Convert.ToInt32(x), Convert.ToInt32(Math.Round(y + 0.5)), Color.Green);
                            y += m;
                            pictureBox1.Image = obraz;
                        }
                    }
                }
                else
                {
                    m = dx / dy;
                    x = ax;
                    for (y = ay; y < by; y++)
                    {
                        if (y < 300)
                        {
                            obraz.SetPixel(Convert.ToInt32(Math.Round(x + 0.5)), Convert.ToInt32(y), Color.Green);
                            x += m;
                            pictureBox1.Image = obraz;
                        }
                    }
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            Bitmap obraz = new Bitmap(300, 300);
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
            {
                int ax = Convert.ToInt32(textBox1.Text);
                int ay = Convert.ToInt32(textBox2.Text);
                int bx = Convert.ToInt32(textBox3.Text);
                int by = Convert.ToInt32(textBox4.Text);
                if (ax > bx)
                {
                    int t = ax;
                    ax = bx;
                    bx = t;
                    t = ay;
                    ay = by;
                    by = t;

                }

                if (by > ay)
                {
                    int dx, dy, incre, incrne, d, x, y;
                    dx = bx - ax;
                    dy = by - ay;
                    x = ax;
                    y = ay;
                    obraz.SetPixel(x, y, Color.Blue);
                    if (bx - ax >= by - ay)
                    {
                        d = dy * 2 - dx;
                        incre = dy * 2;
                        incrne = (dy - dx) * 2;
                        while (x < bx)
                        {
                            if (d <= 0)
                            {
                                d += incre;
                                x++;
                            }
                            else
                            {
                                d += incrne;
                                x++;
                                y++;
                            }
                            if (x < 300)
                                obraz.SetPixel(x, y, Color.Blue);
                        }
                    }
                    else
                    {
                        d = dx * 2 - dy;
                        incre = dx * 2;
                        incrne = (dx - dy) * 2;
                        while (y < by)
                        {
                            if (d <= 0)
                            {
                                d += incre;
                                y++;
                            }
                            else
                            {
                                d += incrne;
                                y++;
                                x++;
                            }
                            if (y < 300)
                                obraz.SetPixel(x, y, Color.Blue);
                        }

                    }
                }else
                {
                    int dx, dy, incre, incrne, d, x, y;
                    dx = bx - ax;
                    dy = ay - by;
                    x = bx;
                    y = by;
                    obraz.SetPixel(x, y, Color.Blue);
                    if (bx - ax >= ay - by)
                    {

                        d = dy * 2 - dx;
                        incre = dy * 2;
                        incrne = (dy - dx) * 2;
                        while (x > ax)
                        {
                            if (d <= 0)
                            {
                                d += incre;
                                x--;
                            }
                            else
                            {
                                d += incrne;
                                x--;
                                y++;
                            }
                            if (x > 0)
                                obraz.SetPixel(x, y, Color.Blue);
                        }
                    }
                    else
                    {
                        d = dx * 2 - dy;
                        incre = dx * 2;
                        incrne = (dx - dy) * 2;
                        while (y > ay)
                        {
                            if (d <= 0)
                            {
                                d += incre;
                                y--;
                            }
                            else
                            {
                                d += incrne;
                                y--;
                                x++;
                            }
                            if (y > 0)
                                obraz.SetPixel(x, y, Color.Blue);
                        }

                    }

                }
                pictureBox1.Image = obraz;
            }
        }
        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}

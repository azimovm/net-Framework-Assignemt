using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Bitmap bm;
        Graphics g;
        bool paint = false;
        Point px, py;
        Pen p = new Pen(Color.Black, 1);
        Pen eraser = new Pen(Color.White, 10);
        int index = 1;
        int x, y, sx, sy, cx, cy;

        Color nColor;
        ColorDialog cd = new ColorDialog();

        public Form1()
        {
            InitializeComponent();
            bm = new Bitmap(Pic.Width, Pic.Height);
            g = Graphics.FromImage(bm);
            g.Clear(Color.White);
            Pic.Image = bm;
            ColorPicker.BackColor = Color.Black;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            py = e.Location;

            cx = e.X;
            cy = e.Y;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Rectangle_MouseClick(object sender, MouseEventArgs e)
        {
            index = 4;
        }

        private void Line_MouseClick(object sender, MouseEventArgs e)
        {
            index = 5;
        }

        private void Pic_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (paint)
            {
                switch (index)
                {
                    case 3:
                        g.DrawEllipse(p, cx, cy, sx, sy);
                        break;
                    case 4:
                        g.DrawRectangle(p, cx, cy, sx, sy);
                        break;
                    case 5:
                        g.DrawLine(p, cx, cy, x, y);
                        break;
                }
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (paint)
            {
                switch (index)
                {
                    case 1:
                        px = e.Location;
                        g.DrawLine(p, px, py);
                        py = px;
                        break;
                    case 2:
                        px = e.Location;
                        g.DrawLine(eraser, px, py);
                        py = px;
                        break;
                }
            }
            Pic.Refresh();

            x = e.X;
            y = e.Y;
            sx = e.X - cx;
            sy = e.Y - cy;
        }

        private void saveToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            Pic.Image = bm;
            index = 1;
        }

        private void ColorPicker_Click(object sender, EventArgs e)
        {
            cd.ShowDialog();
            nColor = cd.Color;
            Pic.BackColor = nColor;
            p.Color = nColor;
            ColorPicker.BackColor = nColor;
        }

        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.Title = "Open Image";
            ofd.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                bm = new Bitmap(ofd.FileName);
                g = Graphics.FromImage(bm);
                Pic.Image = bm;
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;

            sx = x - cx;
            sy = y - cy;
            drawFigures(index);
        }

        private void Pencil_MouseClick(object sender, MouseEventArgs e)
        {
            index = 1;
        }

        private void Eraser_MouseClick(object sender, MouseEventArgs e)
        {
            index = 2;
        }

        private void Ellipse_MouseClick(object sender, MouseEventArgs e)
        {
            index = 3;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog();
            sfd.Filter = "Image(*.jpg)|*.jpg|(*.*)|*.*";
            if(sfd.ShowDialog() == DialogResult.OK)
            {
                Bitmap bmp = bm.Clone(new Rectangle(0, 0, Pic.Width, Pic.Height), bm.PixelFormat);
                bmp.Save(sfd.FileName, ImageFormat.Jpeg);
            }
        }

        private void drawFigures(int i)
        {
            switch (i)
            {
                case 3:
                    g.DrawEllipse(p, cx, cy, sx, sy);
                    break;
                case 4:
                    g.DrawRectangle(p, cx, cy, sx, sy);
                    break;
                case 5:
                    g.DrawLine(p, cx, cy, x, y);
                    break;
            }
        }
    }
}

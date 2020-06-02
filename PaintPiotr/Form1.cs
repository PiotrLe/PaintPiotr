using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintPiotr
{
    public partial class Form1 : Form
    {
        Bitmap bmap;
        int x = -1;
        int y = -1;
        bool moving = false;
        int size = 5;
        int tool = 1;
        Color paintColor = Color.Black;
        int sizeFigure = 10;


        Pen pen;

        public Form1()
        {
            InitializeComponent();
            bmap = new Bitmap(panel1.Width, panel1.Height);
            pen = new Pen(paintColor, size);
            pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }

        private void color_Click(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            paintColor = p.BackColor;
            pen.Color = p.BackColor;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {   
            moving = true;
            x = e.X;
            y = e.Y;
            panel1.Cursor = Cursors.Cross;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            using (Graphics gr = Graphics.FromImage(bmap))
            {
                if (moving && x != -1 && y != -1)
                {
                    if (tool == 1)
                    {
                        gr.DrawLine(pen, new Point(x, y), e.Location);
                    }



                    x = e.X;
                    y = e.Y;
                    panel1.Invalidate();
                }
            }
   
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            moving = false;
            x = -1;
            y = -1;
            panel1.Cursor = Cursors.Default;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            size = Int16.Parse(((Button)sender).Text) * 5;
            pen.Width = Int16.Parse(((Button)sender).Text) * 5;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            pen.Color = Color.White;
            paintColor = Color.White;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            switch (button.Text)
            {
                case "Gwiazdka":tool = 4;
                    break;
                case "Kwadrat":tool = 2;
                    break;
                case "Kolko": tool = 3;
                    break;
                default: tool = 1;
                    break;
            }
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            using (Graphics gr = Graphics.FromImage(bmap))
            {
                if (tool == 2)
                {
                    gr.FillRectangle(new SolidBrush(paintColor), x, y, sizeFigure * size, sizeFigure * size);
                }
                if (tool == 3)
                {
                    gr.FillEllipse(new SolidBrush(paintColor), x, y, sizeFigure * size, sizeFigure * size);
                }
                if (tool == 4)
                {
                    Point[] star = { new Point(x, y), new Point(x + (1 * size), y + (3 * size)), new Point(x + (2 * size), y), new Point(x + (5 * size), y - (1 * size)), new Point(x + (2 * size), y - (2 * size)), new Point(x + (1 * size), y - (5 * size)), new Point(x, y - (2 * size)), new Point(x - (3 * size), y - (1 * size)), new Point(x, y) };
                    gr.FillPolygon(new SolidBrush(paintColor), star);
                }
            }
            panel1.Invalidate();
        }

        private void wczytajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Graphics gr = Graphics.FromImage(bmap))
            {
                openFileDialog1.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    bmap = new Bitmap(openFileDialog1.FileName);
                    panel1.Invalidate();
                }
            }
        }

        private void plikToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void zapiszToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bmap.Save("File.jpg");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(bmap, Point.Empty);
        }

        private void zapiszJakoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "JPEG|*.jpg";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                bmap.Save(dialog.FileName);
            }
        }
    }
}
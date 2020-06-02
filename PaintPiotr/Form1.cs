using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Media;
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
            ToolStripButton p = (ToolStripButton)sender;
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
            size = Int16.Parse(((ToolStripButton)sender).Text) * 5;
            pen.Width = Int16.Parse(((ToolStripButton)sender).Text) * 5;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            tool = 1;
            pen.Color = Color.White;
            paintColor = Color.White;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ToolStripButton button = (ToolStripButton)sender;
            switch (button.Text)
            {
                case "Gwiazdka":tool = 4;
                    break;
                case "Kwadrat":tool = 2;
                    break;
                case "Kolko": tool = 3;
                    break;
                case "Olowek": tool = 1;
                    pen.Color = Color.Black;
                    paintColor = Color.Black;
                    break;
                default: tool = 1;
                    paintColor = Color.Black;
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

        private void zakończToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Na pewno chcesz zakończyć?", "Wyjście", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
            else
            {
                MessageBox.Show("To wracajmy do rysowania z muzyką !");
            }
        }

        private void informacjeOProgramieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Autor: Piotr Lewczuk\n" +
                "Muzyka: Piotr Lewczuk\n" +
                "Ze specjalnymi podziękowaniami dla prowadzącego przedmiot \nProgramowanie w C#");
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            try
            {
                SoundPlayer soundPlayer = new SoundPlayer(PaintPiotr.Properties.Resources.Death_dance);
                if (checkBox1.Checked) { 
                soundPlayer.Play();
                }
                else { 
                soundPlayer.Stop();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error message - " + ex.Message);
            }
        }

        private void drukujToolStripMenuItem_Click(object sender, EventArgs e)
        {

            PrintDocument doc = new PrintDocument();
            doc.PrintPage += this.Doc_PrintPage;

            printDialog1 = new PrintDialog();
            printDialog1.Document = doc;

            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                doc.Print();
            }
        }

        private void Doc_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font font = new Font("Arial", 30);

            float x = e.MarginBounds.Left;
            float y = e.MarginBounds.Top;

            float lineHeight = font.GetHeight(e.Graphics);


            e.Graphics.DrawString("Your orginal paint picture!", font, Brushes.Black, x, y);
            
            y += lineHeight;

            e.Graphics.DrawImage(bmap, x, y);

        }

        private void button8_Click(object sender, EventArgs e)
        {
            bmap.RotateFlip(RotateFlipType.Rotate90FlipNone);
            panel1.Invalidate();

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton26_Click(object sender, EventArgs e)
        {
            using (Graphics gfx = Graphics.FromImage(bmap))
            using (SolidBrush brush = new SolidBrush(paintColor))
            {
                gfx.FillRectangle(brush, 0, 0, panel1.Width, panel1.Height);
            }
            panel1.Invalidate();
        }
    }
}
using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Media;
using System.Windows.Forms;

namespace PaintPiotr
{
    public partial class Form1 : Form
    {

        // bitmap to store drawings
        Bitmap bitmap;
        // cordinates for painting
        int x = -1;
        int y = -1;
        // set to true if mouse click panel
        bool moving = false;
        // size of tools
        int size = 5;
        // chosen tool, starting value is pen
        int tool = 1;
        // chosen paint color, initial value is black
        Color paintColor = Color.Black;
        // standard size for figures it is multiplied by size while switching to larger size;
        readonly int basicFigureSize = 10;
        // pen declaration
        Pen pen;

        //Contains all buttons and panels for drawings.
        public Form1()
        {
            InitializeComponent();
            bitmap = new Bitmap(panel1.Width, panel1.Height);
            pen = new Pen(paintColor, size);
            // for drawing in round shape
            pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }

        // Method responsible for choosing color
        private void Color_Click(object sender, EventArgs e)
        {
            ToolStripButton p = (ToolStripButton)sender;
            paintColor = p.BackColor;
            pen.Color = p.BackColor;
        }

        //Method responsible for handling mouse down event
        private void Panel1MouseDown(object sender, MouseEventArgs e)
        {   
            moving = true;
            x = e.X;
            y = e.Y;
            panel1.Cursor = Cursors.Cross;
        }

        //Method responsible for drawing in case mouse is down and moving
        private void Panel1MouseMove(object sender, MouseEventArgs e)
        {
            using (Graphics gr = Graphics.FromImage(bitmap))
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

        //Method handles mouseUp event over panel1, it sets moving flag to false and sets coordinates to -1
        private void Panel1MouseUp(object sender, MouseEventArgs e)
        {
            moving = false;
            x = -1;
            y = -1;
            panel1.Cursor = Cursors.Default;
        }

        //Method handles change size buttons.
        private void ChangeSizeButton(object sender, EventArgs e)
        {
            size = Int16.Parse(((ToolStripButton)sender).Text) * 5;
            pen.Width = Int16.Parse(((ToolStripButton)sender).Text) * 5;
        }

        //Method allows to pick eraser tool, it is using pen but with white paint.
        private void EraserClick(object sender, EventArgs e)
        {
            tool = 1;
            pen.Color = Color.White;
            paintColor = Color.White;
        }

        //Method allows to chose tool:
        // 1 for pen
        // 2 for rectancle
        // 3 for circle
        // 4 for start
        // Keep in mind that it is based on the button text.
        private void ChooseToolButton(object sender, EventArgs e)
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

        // Method invoked draw shape only in case that appropriate tool was choosen
        private void Panel1Click(object sender, EventArgs e)
        {
            using (Graphics gr = Graphics.FromImage(bitmap))
            {
                if (tool == 2)
                {
                    gr.FillRectangle(new SolidBrush(paintColor), x, y, basicFigureSize * size, basicFigureSize * size);
                }
                if (tool == 3)
                {
                    gr.FillEllipse(new SolidBrush(paintColor), x, y, basicFigureSize * size, basicFigureSize * size);
                }
                if (tool == 4)
                {
                    Point[] star = { new Point(x, y), new Point(x + (1 * size), y + (3 * size)), new Point(x + (2 * size), y), new Point(x + (5 * size), y - (1 * size)), new Point(x + (2 * size), y - (2 * size)), new Point(x + (1 * size), y - (5 * size)), new Point(x, y - (2 * size)), new Point(x - (3 * size), y - (1 * size)), new Point(x, y) };
                    gr.FillPolygon(new SolidBrush(paintColor), star);
                }
            }
            panel1.Invalidate();
        }
        // Load a file
        private void LoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Graphics gr = Graphics.FromImage(bitmap))
            {
                openFileDialog1.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    bitmap = new Bitmap(openFileDialog1.FileName);
                    panel1.Invalidate();
                }
            }
        }
        //Saving always as File.jpg
        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bitmap.Save("File.jpg");
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, Point.Empty);
        }

        //Save as ... option
        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "JPEG|*.jpg";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                bitmap.Save(dialog.FileName);
            }
        }
        //Close application from droplist. 
        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
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

        //Information about program and so on
        private void InformationAboutProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Autor: Piotr Lewczuk\n" +
                "Muzyka: Piotr Lewczuk\n" +
                "Ze specjalnymi podziękowaniami dla prowadzącego przedmiot \nProgramowanie w C#");
        }

        //Plays and stops music
        private void MusicCheckBox_Click(object sender, EventArgs e)
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

        //Method responsible for handling print button
        private void PrintToolStripMenuItem_Click(object sender, EventArgs e)
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
        //Method responsible for printing page, it writes one sentence and then convert to document.
        private void Doc_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font font = new Font("Arial", 30);

            float x = e.MarginBounds.Left;
            float y = e.MarginBounds.Top;

            float lineHeight = font.GetHeight(e.Graphics);


            e.Graphics.DrawString("Your orginal paint picture!", font, Brushes.Black, x, y);
            
            y += lineHeight;

            e.Graphics.DrawImage(bitmap, x, y);

        }

        // Method rotates all bitmap with 90 deggres
        private void RotationButton_Click(object sender, EventArgs e)
        {
            bitmap.RotateFlip(RotateFlipType.Rotate90FlipNone);
            panel1.Invalidate();

        }

        // Method fills entire pane with picked color
        private void FillBucket_Click(object sender, EventArgs e)
        {
            using (Graphics gfx = Graphics.FromImage(bitmap))
            using (SolidBrush brush = new SolidBrush(paintColor))
            {
                gfx.FillRectangle(brush, 0, 0, panel1.Width, panel1.Height);
            }
            panel1.Invalidate();
        }

        // Method responsible for creating new file. It simply creating new bitmap.
        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bitmap = new Bitmap(panel1.Width, panel1.Height);
            panel1.Invalidate();
        }

        private void NotImplementedYetMessageClick(object sender, EventArgs e)
        {
            MessageBox.Show("Jescze nie zaimplementowano");
        }
    }
}
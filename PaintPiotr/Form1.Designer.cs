namespace PaintPiotr
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.Czarny = new System.Windows.Forms.ToolStripButton();
            this.Czerwony = new System.Windows.Forms.ToolStripButton();
            this.Pomaranczowy = new System.Windows.Forms.ToolStripButton();
            this.Zółty = new System.Windows.Forms.ToolStripButton();
            this.Zielony = new System.Windows.Forms.ToolStripButton();
            this.Wodny = new System.Windows.Forms.ToolStripButton();
            this.Niebieski = new System.Windows.Forms.ToolStripButton();
            this.Granatowy = new System.Windows.Forms.ToolStripButton();
            this.Różowy = new System.Windows.Forms.ToolStripButton();
            this.Magenta = new System.Windows.Forms.ToolStripButton();
            this.Fioletowy = new System.Windows.Forms.ToolStripButton();
            this.Szary = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.KubekZFarbą = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Wklej = new System.Windows.Forms.ToolStripButton();
            this.Kopiuj = new System.Windows.Forms.ToolStripButton();
            this.Wytnij = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Zaznacz = new System.Windows.Forms.ToolStripButton();
            this.Obróć = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton18 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton19 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton20 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton21 = new System.Windows.Forms.ToolStripButton();
            this.Gumka = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton23 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton24 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton25 = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nowyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wczytajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszJakoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drukujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informacjeOProgramieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zakończToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.toolStrip2);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(542, 494);
            this.panel1.TabIndex = 0;
            this.panel1.Click += new System.EventHandler(this.Panel1Click);
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel1MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel1MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Panel1MouseUp);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(467, 27);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(63, 17);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "Muzyka";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Click += new System.EventHandler(this.MusicCheckBox_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Czarny,
            this.Czerwony,
            this.Pomaranczowy,
            this.Zółty,
            this.Zielony,
            this.Wodny,
            this.Niebieski,
            this.Granatowy,
            this.Różowy,
            this.Magenta,
            this.Fioletowy,
            this.Szary,
            this.toolStripSeparator3,
            this.KubekZFarbą});
            this.toolStrip2.Location = new System.Drawing.Point(0, 51);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(30, 443);
            this.toolStrip2.TabIndex = 20;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // Czarny
            // 
            this.Czarny.AutoSize = false;
            this.Czarny.BackColor = System.Drawing.Color.Black;
            this.Czarny.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Czarny.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Czarny.Name = "Czarny";
            this.Czarny.Size = new System.Drawing.Size(29, 20);
            this.Czarny.Text = "Czarny";
            this.Czarny.Click += new System.EventHandler(this.Color_Click);
            // 
            // Czerwony
            // 
            this.Czerwony.AutoSize = false;
            this.Czerwony.BackColor = System.Drawing.Color.Red;
            this.Czerwony.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Czerwony.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Czerwony.Name = "Czerwony";
            this.Czerwony.Size = new System.Drawing.Size(29, 20);
            this.Czerwony.Text = "Czerwony";
            this.Czerwony.Click += new System.EventHandler(this.Color_Click);
            // 
            // Pomaranczowy
            // 
            this.Pomaranczowy.AutoSize = false;
            this.Pomaranczowy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Pomaranczowy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Pomaranczowy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Pomaranczowy.Name = "Pomaranczowy";
            this.Pomaranczowy.Size = new System.Drawing.Size(29, 20);
            this.Pomaranczowy.Text = "Pomarańczowy";
            this.Pomaranczowy.Click += new System.EventHandler(this.Color_Click);
            // 
            // Zółty
            // 
            this.Zółty.AutoSize = false;
            this.Zółty.BackColor = System.Drawing.Color.Yellow;
            this.Zółty.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Zółty.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Zółty.Name = "Zółty";
            this.Zółty.Size = new System.Drawing.Size(29, 20);
            this.Zółty.Text = "Zółty";
            this.Zółty.Click += new System.EventHandler(this.Color_Click);
            // 
            // Zielony
            // 
            this.Zielony.AutoSize = false;
            this.Zielony.BackColor = System.Drawing.Color.Lime;
            this.Zielony.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Zielony.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Zielony.Name = "Zielony";
            this.Zielony.Size = new System.Drawing.Size(29, 20);
            this.Zielony.Text = "Zielony";
            this.Zielony.Click += new System.EventHandler(this.Color_Click);
            // 
            // Wodny
            // 
            this.Wodny.AutoSize = false;
            this.Wodny.BackColor = System.Drawing.Color.Aqua;
            this.Wodny.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Wodny.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Wodny.Name = "Wodny";
            this.Wodny.Size = new System.Drawing.Size(29, 20);
            this.Wodny.Text = "Wodny";
            this.Wodny.Click += new System.EventHandler(this.Color_Click);
            // 
            // Niebieski
            // 
            this.Niebieski.AutoSize = false;
            this.Niebieski.BackColor = System.Drawing.Color.Blue;
            this.Niebieski.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Niebieski.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Niebieski.Name = "Niebieski";
            this.Niebieski.Size = new System.Drawing.Size(29, 20);
            this.Niebieski.Text = "Niebieski";
            this.Niebieski.Click += new System.EventHandler(this.Color_Click);
            // 
            // Granatowy
            // 
            this.Granatowy.AutoSize = false;
            this.Granatowy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Granatowy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Granatowy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Granatowy.Name = "Granatowy";
            this.Granatowy.Size = new System.Drawing.Size(29, 20);
            this.Granatowy.Text = "Granatowy";
            this.Granatowy.Click += new System.EventHandler(this.Color_Click);
            // 
            // Różowy
            // 
            this.Różowy.AutoSize = false;
            this.Różowy.BackColor = System.Drawing.Color.Fuchsia;
            this.Różowy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Różowy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Różowy.Name = "Różowy";
            this.Różowy.Size = new System.Drawing.Size(29, 20);
            this.Różowy.Text = "Magenta";
            this.Różowy.Click += new System.EventHandler(this.Color_Click);
            // 
            // Magenta
            // 
            this.Magenta.AutoSize = false;
            this.Magenta.BackColor = System.Drawing.Color.Purple;
            this.Magenta.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Magenta.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Magenta.Name = "Magenta";
            this.Magenta.Size = new System.Drawing.Size(29, 20);
            this.Magenta.Text = "Fioletowy";
            this.Magenta.Click += new System.EventHandler(this.Color_Click);
            // 
            // Fioletowy
            // 
            this.Fioletowy.AutoSize = false;
            this.Fioletowy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Fioletowy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Fioletowy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Fioletowy.Name = "Fioletowy";
            this.Fioletowy.Size = new System.Drawing.Size(29, 20);
            this.Fioletowy.Text = "CiemnyFioletowy";
            this.Fioletowy.Click += new System.EventHandler(this.Color_Click);
            // 
            // Szary
            // 
            this.Szary.AutoSize = false;
            this.Szary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Szary.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Szary.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Szary.Name = "Szary";
            this.Szary.Size = new System.Drawing.Size(29, 20);
            this.Szary.Text = "Szary";
            this.Szary.Click += new System.EventHandler(this.Color_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(29, 6);
            // 
            // KubekZFarbą
            // 
            this.KubekZFarbą.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.KubekZFarbą.Image = global::PaintPiotr.Properties.Resources.unnamed__1_;
            this.KubekZFarbą.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.KubekZFarbą.Name = "KubekZFarbą";
            this.KubekZFarbą.Size = new System.Drawing.Size(27, 24);
            this.KubekZFarbą.Text = "KubelekZFarba";
            this.KubekZFarbą.Click += new System.EventHandler(this.FillBucket_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Wklej,
            this.Kopiuj,
            this.Wytnij,
            this.toolStripSeparator1,
            this.Zaznacz,
            this.Obróć,
            this.toolStripSeparator4,
            this.toolStripLabel1,
            this.toolStripButton18,
            this.toolStripButton19,
            this.toolStripButton20,
            this.toolStripButton21,
            this.Gumka,
            this.toolStripLabel2,
            this.toolStripButton23,
            this.toolStripButton24,
            this.toolStripButton25});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(542, 27);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 19;
            this.toolStrip1.Text = "Kopiuj";
            // 
            // Wklej
            // 
            this.Wklej.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Wklej.Image = global::PaintPiotr.Properties.Resources.unnamed;
            this.Wklej.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Wklej.Name = "Wklej";
            this.Wklej.Size = new System.Drawing.Size(24, 24);
            this.Wklej.Text = "Wklej";
            this.Wklej.Click += new System.EventHandler(this.NotImplementedYetMessageClick);
            // 
            // Kopiuj
            // 
            this.Kopiuj.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Kopiuj.Image = global::PaintPiotr.Properties.Resources._88026;
            this.Kopiuj.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Kopiuj.Name = "Kopiuj";
            this.Kopiuj.Size = new System.Drawing.Size(24, 24);
            this.Kopiuj.Text = "Kopiuj";
            this.Kopiuj.Click += new System.EventHandler(this.NotImplementedYetMessageClick);
            // 
            // Wytnij
            // 
            this.Wytnij.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Wytnij.Image = global::PaintPiotr.Properties.Resources.pobrane__1_;
            this.Wytnij.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Wytnij.Name = "Wytnij";
            this.Wytnij.Size = new System.Drawing.Size(24, 24);
            this.Wytnij.Text = "Wytnij";
            this.Wytnij.Click += new System.EventHandler(this.NotImplementedYetMessageClick);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // Zaznacz
            // 
            this.Zaznacz.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Zaznacz.Image = global::PaintPiotr.Properties.Resources.pobrane;
            this.Zaznacz.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Zaznacz.Name = "Zaznacz";
            this.Zaznacz.Size = new System.Drawing.Size(24, 24);
            this.Zaznacz.Text = "Zaznacz";
            this.Zaznacz.Click += new System.EventHandler(this.NotImplementedYetMessageClick);
            // 
            // Obróć
            // 
            this.Obróć.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Obróć.Image = global::PaintPiotr.Properties.Resources.button_rotate_512;
            this.Obróć.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Obróć.Name = "Obróć";
            this.Obróć.Size = new System.Drawing.Size(24, 24);
            this.Obróć.Text = "Obróć";
            this.Obróć.Click += new System.EventHandler(this.RotationButton_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.AutoSize = false;
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(58, 24);
            this.toolStripLabel1.Text = "Narzędzia";
            // 
            // toolStripButton18
            // 
            this.toolStripButton18.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton18.Image = global::PaintPiotr.Properties.Resources._130188;
            this.toolStripButton18.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton18.Name = "toolStripButton18";
            this.toolStripButton18.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton18.Text = "Gwiazdka";
            this.toolStripButton18.Click += new System.EventHandler(this.ChooseToolButton);
            // 
            // toolStripButton19
            // 
            this.toolStripButton19.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton19.Image = global::PaintPiotr.Properties.Resources.pobrane__2_;
            this.toolStripButton19.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton19.Name = "toolStripButton19";
            this.toolStripButton19.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton19.Text = "Kolko";
            this.toolStripButton19.Click += new System.EventHandler(this.ChooseToolButton);
            // 
            // toolStripButton20
            // 
            this.toolStripButton20.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton20.Image = global::PaintPiotr.Properties.Resources.iconfinder_button_shape_rectangle_352896;
            this.toolStripButton20.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton20.Name = "toolStripButton20";
            this.toolStripButton20.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton20.Text = "Kwadrat";
            this.toolStripButton20.Click += new System.EventHandler(this.ChooseToolButton);
            // 
            // toolStripButton21
            // 
            this.toolStripButton21.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton21.Image = global::PaintPiotr.Properties.Resources.pen_2;
            this.toolStripButton21.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton21.Name = "toolStripButton21";
            this.toolStripButton21.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton21.Text = "Olowek";
            this.toolStripButton21.Click += new System.EventHandler(this.ChooseToolButton);
            // 
            // Gumka
            // 
            this.Gumka.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Gumka.Image = global::PaintPiotr.Properties.Resources.pobrane__3_;
            this.Gumka.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Gumka.Name = "Gumka";
            this.Gumka.Size = new System.Drawing.Size(24, 24);
            this.Gumka.Text = "Gumka";
            this.Gumka.Click += new System.EventHandler(this.EraserClick);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(54, 24);
            this.toolStripLabel2.Text = "Wielkość";
            // 
            // toolStripButton23
            // 
            this.toolStripButton23.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton23.Image = global::PaintPiotr.Properties.Resources._1;
            this.toolStripButton23.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton23.Name = "toolStripButton23";
            this.toolStripButton23.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton23.Text = "1";
            this.toolStripButton23.Click += new System.EventHandler(this.ChangeSizeButton);
            // 
            // toolStripButton24
            // 
            this.toolStripButton24.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton24.Image = global::PaintPiotr.Properties.Resources._2;
            this.toolStripButton24.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton24.Name = "toolStripButton24";
            this.toolStripButton24.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton24.Text = "2";
            this.toolStripButton24.Click += new System.EventHandler(this.ChangeSizeButton);
            // 
            // toolStripButton25
            // 
            this.toolStripButton25.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton25.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton25.Image")));
            this.toolStripButton25.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton25.Name = "toolStripButton25";
            this.toolStripButton25.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton25.Text = "3";
            this.toolStripButton25.Click += new System.EventHandler(this.ChangeSizeButton);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(542, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nowyToolStripMenuItem,
            this.wczytajToolStripMenuItem,
            this.zapiszToolStripMenuItem,
            this.zapiszJakoToolStripMenuItem,
            this.drukujToolStripMenuItem,
            this.informacjeOProgramieToolStripMenuItem,
            this.zakończToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // nowyToolStripMenuItem
            // 
            this.nowyToolStripMenuItem.Name = "nowyToolStripMenuItem";
            this.nowyToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.nowyToolStripMenuItem.Text = "Nowy";
            this.nowyToolStripMenuItem.Click += new System.EventHandler(this.NewToolStripMenuItem_Click);
            // 
            // wczytajToolStripMenuItem
            // 
            this.wczytajToolStripMenuItem.Name = "wczytajToolStripMenuItem";
            this.wczytajToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.wczytajToolStripMenuItem.Text = "Wczytaj";
            this.wczytajToolStripMenuItem.Click += new System.EventHandler(this.LoadToolStripMenuItem_Click);
            // 
            // zapiszToolStripMenuItem
            // 
            this.zapiszToolStripMenuItem.Name = "zapiszToolStripMenuItem";
            this.zapiszToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.zapiszToolStripMenuItem.Text = "Zapisz";
            this.zapiszToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // zapiszJakoToolStripMenuItem
            // 
            this.zapiszJakoToolStripMenuItem.Name = "zapiszJakoToolStripMenuItem";
            this.zapiszJakoToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.zapiszJakoToolStripMenuItem.Text = "Zapisz jako...";
            this.zapiszJakoToolStripMenuItem.Click += new System.EventHandler(this.SaveAsToolStripMenuItem_Click);
            // 
            // drukujToolStripMenuItem
            // 
            this.drukujToolStripMenuItem.Name = "drukujToolStripMenuItem";
            this.drukujToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.drukujToolStripMenuItem.Text = "Drukuj";
            this.drukujToolStripMenuItem.Click += new System.EventHandler(this.PrintToolStripMenuItem_Click);
            // 
            // informacjeOProgramieToolStripMenuItem
            // 
            this.informacjeOProgramieToolStripMenuItem.Name = "informacjeOProgramieToolStripMenuItem";
            this.informacjeOProgramieToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.informacjeOProgramieToolStripMenuItem.Text = "Informacje o programie";
            this.informacjeOProgramieToolStripMenuItem.Click += new System.EventHandler(this.InformationAboutProgramToolStripMenuItem_Click);
            // 
            // zakończToolStripMenuItem
            // 
            this.zakończToolStripMenuItem.Name = "zakończToolStripMenuItem";
            this.zakończToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.zakończToolStripMenuItem.Text = "Zakończ";
            this.zakończToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 494);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "PaintWithMusic";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wczytajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapiszToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drukujToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informacjeOProgramieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zakończToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem zapiszJakoToolStripMenuItem;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Wklej;
        private System.Windows.Forms.ToolStripButton Kopiuj;
        private System.Windows.Forms.ToolStripButton Wytnij;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton Zaznacz;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton Czarny;
        private System.Windows.Forms.ToolStripButton Czerwony;
        private System.Windows.Forms.ToolStripButton Pomaranczowy;
        private System.Windows.Forms.ToolStripButton Zółty;
        private System.Windows.Forms.ToolStripButton Zielony;
        private System.Windows.Forms.ToolStripButton Wodny;
        private System.Windows.Forms.ToolStripButton Niebieski;
        private System.Windows.Forms.ToolStripButton Granatowy;
        private System.Windows.Forms.ToolStripButton Różowy;
        private System.Windows.Forms.ToolStripButton Magenta;
        private System.Windows.Forms.ToolStripButton Fioletowy;
        private System.Windows.Forms.ToolStripButton Szary;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton Obróć;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton18;
        private System.Windows.Forms.ToolStripButton toolStripButton19;
        private System.Windows.Forms.ToolStripButton toolStripButton20;
        private System.Windows.Forms.ToolStripButton toolStripButton21;
        private System.Windows.Forms.ToolStripButton Gumka;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton toolStripButton23;
        private System.Windows.Forms.ToolStripButton toolStripButton24;
        private System.Windows.Forms.ToolStripButton toolStripButton25;
        private System.Windows.Forms.ToolStripButton KubekZFarbą;
        private System.Windows.Forms.ToolStripMenuItem nowyToolStripMenuItem;
    }
}


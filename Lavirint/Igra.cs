using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lavirint.Properties;

namespace Lavirint
{
    public partial class Igra : Form
    {
        Karakter karakter;
        Image img;
        Image borderImage;
        Image pathImage;
        public int MazeDimensions { get; set; }
        public Labyrinth lavirint { get; set; }
        public static int goleminaPole = 40;
        Form1 parent;
        public int PocetokX { get; set; }
        public int PocetokY { get; set; }

        private new Image Resize(Image img, int iWidth, int iHeight)
        {
            Bitmap bmp = new Bitmap(iWidth, iHeight);
            Graphics graphic = Graphics.FromImage((Image)bmp);
            graphic.DrawImage(img, 0, 0, iWidth, iHeight);

            return (Image)bmp;
        }

        public Igra(string ime,Form1 parent, int MazeDimensions=40)
        {
            InitializeComponent();
            DoubleBuffered = true;

            this.parent = parent;
            this.MazeDimensions = MazeDimensions;
            lavirint = new Labyrinth(MazeDimensions);
            karakter = new Karakter(ime, -5, -5);

            if (karakter.Ime.Equals("Lidia"))
            {
                img = Resources.lidia_dole_desno;
            }
            else if (karakter.Ime.Equals("Sara"))
            {
                img = Resources.Sara_dole_desno;
            }
           
            borderImage = Resources.border;
            pathImage = Resources.path;
            borderImage = Resize(borderImage, goleminaPole, goleminaPole);
            pathImage = Resize(pathImage, goleminaPole, goleminaPole);
        }

        private void Igra_Paint(object sender, PaintEventArgs e)
        {
            Graphics g1 = e.Graphics;
            g1.Clear(Color.White);
            for (int i = 0; i < lavirint.Maze.Length; i++)
            {
                for (int j = 0; j < lavirint.Maze[i].Length; j++)
                {
                    if (lavirint.Maze[i][j])
                    {
                        g1.DrawImageUnscaled(pathImage, PocetokX+ pathImage.Width * j, PocetokY +pathImage.Height * i);
                    }
                    else
                    {
                        g1.DrawImageUnscaled(borderImage, PocetokX + borderImage.Width * j, PocetokY + borderImage.Height * i);
                    }
                }
            }
            g1.DrawImageUnscaled(img, karakter.X, karakter.Y);
        }

        private void pomestiEkran(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right && karakter.X >= 350 && PocetokX>(600 - (1 + MazeDimensions) * goleminaPole))
            {
                    PocetokX =Math.Max (PocetokX-Karakter.pridvizuvanje,600-(1+MazeDimensions)*goleminaPole);
                    karakter.X -= Karakter.pridvizuvanje;
            }
            if (e.KeyCode == Keys.Left && karakter.X >= 150 && PocetokX < 0)
            {
                    PocetokX = Math.Min(PocetokX + Karakter.pridvizuvanje, 0);
                    karakter.X += Karakter.pridvizuvanje;
            }
            if (e.KeyCode == Keys.Down && karakter.Y >= 350  && PocetokY> 600 - (MazeDimensions +2) * goleminaPole)
            {
                PocetokY =Math.Max(PocetokY - Karakter.pridvizuvanje, 600 - ( MazeDimensions+2) * goleminaPole);
                karakter.Y -= Karakter.pridvizuvanje;
            }
            if (e.KeyCode == Keys.Up && karakter.Y >= 150 && PocetokY < 0)
            {
                    PocetokY = Math.Min(PocetokY + Karakter.pridvizuvanje, 0);
                    karakter.Y += Karakter.pridvizuvanje;
            }
        }

        private void Igra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
                parent.Show();

            }

            if (karakter.Ime.Equals("Lidia"))
            {
                switch (e.KeyCode)
                {
                    case Keys.Down:
                        karakter.SmeniNasoka(Nasoka.Dole);
                        img = karakter.DesnaNoga ? Resources.lidia_dole_desno : Resources.lidia_dole_levo;

                        break;
                    case Keys.Up:
                        karakter.SmeniNasoka(Nasoka.Gore);
                        img = karakter.DesnaNoga ? Resources.lidia_gore_desno : Resources.lidia_gore_levo;

                        break;
                    case Keys.Left:
                        karakter.SmeniNasoka(Nasoka.Levo);
                        img = karakter.DesnaNoga ? Resources.lidia_levo_desno : Resources.lidia_levo_levo;

                        break;
                    case Keys.Right:
                        karakter.SmeniNasoka(Nasoka.Desno);
                        img = karakter.DesnaNoga ? Resources.lidia_desno_desno : Resources.lidia_desno_levo;

                        break;
                }
            } else if (karakter.Ime.Equals("Sara"))
            {
                switch (e.KeyCode)
                {
                    case Keys.Down:
                        karakter.SmeniNasoka(Nasoka.Dole);
                        img = karakter.DesnaNoga ? Resources.Sara_dole_desno : Resources.Sara_dole_levo;

                        break;
                    case Keys.Up:
                        karakter.SmeniNasoka(Nasoka.Gore);
                        img = karakter.DesnaNoga ? Resources.Sara_gore_desno : Resources.Sara_gore_levo;

                        break;
                    case Keys.Left:
                        karakter.SmeniNasoka(Nasoka.Levo);
                        img = karakter.DesnaNoga ? Resources.Sara_levo_desno : Resources.Sara_levo_levo;

                        break;
                    case Keys.Right:
                        karakter.SmeniNasoka(Nasoka.Desno);
                        img = karakter.DesnaNoga ? Resources.Sara_desno_desno : Resources.Sara_desno_levo;

                        break;
                }
            }
            if(karakter.Move(this))
                pomestiEkran(e);
           
            
            Invalidate();
        }

        private void Igra_Load(object sender, EventArgs e)
        {

        }
    }
}

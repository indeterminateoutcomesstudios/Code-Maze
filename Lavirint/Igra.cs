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
        Lybrinth lavirint = new Lybrinth(20);

        private new Image Resize(Image img, int iWidth, int iHeight)
        {
            Bitmap bmp = new Bitmap(iWidth, iHeight);
            Graphics graphic = Graphics.FromImage((Image)bmp);
            graphic.DrawImage(img, 0, 0, iWidth, iHeight);

            return (Image)bmp;
        }

        public Igra(string ime)
        {
            InitializeComponent();
            DoubleBuffered = true;
            karakter = new Karakter(ime, 1, 1);
            if (karakter.Ime.Equals("Lidia"))
            {
                img = Resources.lidia_gore_desno;
            }
            else if (karakter.Ime.Equals("Sara"))
            {
                img = Resources.Sara_gore_desno;
            }

            borderImage = Resources.border;
            pathImage = Resources.path;
            borderImage = Resize(borderImage, 30, 30);
            pathImage = Resize(pathImage, 30, 30);
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
                        g1.DrawImageUnscaled(pathImage, pathImage.Height * j, pathImage.Width * i);
                    }
                    else
                    {
                        g1.DrawImageUnscaled(borderImage, borderImage.Height * j, borderImage.Width * i);
                    }
                }
            }

         
            g1.DrawImageUnscaled(img, karakter.X, karakter.Y);


        }

        private void Igra_KeyDown(object sender, KeyEventArgs e)
        {
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

            karakter.Move();
            Invalidate();
        }

        private void Igra_Load(object sender, EventArgs e)
        {

        }
    }
}

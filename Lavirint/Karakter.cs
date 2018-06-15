using Lavirint.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lavirint
{
    [Serializable]
    public enum Nasoka
    {
        Gore,
        Dole,
        Levo,
        Desno
    };
    [Serializable]
    public class Karakter
    {
        public string Ime { get; set; }
        public Nasoka Nasoka { get; set; }
        public bool DesnaNoga { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public static int pridvizuvanje = 10;
        Image img;

        public Karakter(string ime, int x, int y)
        {
            Ime = ime;
            Nasoka = Nasoka.Gore;
            DesnaNoga = false;
            X = x;
            Y = y;

            if (Ime.Equals("Lidia"))
            {
                img = Resources.lidia_dole_desno;
            }
            else if (Ime.Equals("Sara"))
            {
                img = Resources.Sara_dole_desno;
            }
        }

        public void SmeniNasoka(Nasoka nasoka)
        {
            Nasoka = nasoka;
        }

        public void SmeniSlika(KeyEventArgs e)
        {
            if (Ime.Equals("Lidia"))
            {
                switch (e.KeyCode)
                {
                    case Keys.Down:
                        SmeniNasoka(Nasoka.Dole);
                        img = DesnaNoga ? Resources.lidia_dole_desno : Resources.lidia_dole_levo;

                        break;
                    case Keys.Up:
                        SmeniNasoka(Nasoka.Gore);
                        img = DesnaNoga ? Resources.lidia_gore_desno : Resources.lidia_gore_levo;

                        break;
                    case Keys.Left:
                        SmeniNasoka(Nasoka.Levo);
                        img = DesnaNoga ? Resources.lidia_levo_desno : Resources.lidia_levo_levo;

                        break;
                    case Keys.Right:
                        SmeniNasoka(Nasoka.Desno);
                        img = DesnaNoga ? Resources.lidia_desno_desno : Resources.lidia_desno_levo;

                        break;
                }
            }
            else if (Ime.Equals("Sara"))
            {
                switch (e.KeyCode)
                {
                    case Keys.Down:
                        SmeniNasoka(Nasoka.Dole);
                        img = DesnaNoga ? Resources.Sara_dole_desno : Resources.Sara_dole_levo;

                        break;
                    case Keys.Up:
                        SmeniNasoka(Nasoka.Gore);
                        img = DesnaNoga ? Resources.Sara_gore_desno : Resources.Sara_gore_levo;

                        break;
                    case Keys.Left:
                        SmeniNasoka(Nasoka.Levo);
                        img = DesnaNoga ? Resources.Sara_levo_desno : Resources.Sara_levo_levo;

                        break;
                    case Keys.Right:
                        SmeniNasoka(Nasoka.Desno);
                        img = DesnaNoga ? Resources.Sara_desno_desno : Resources.Sara_desno_levo;

                        break;
                }
            }
        }

        public Boolean Move(IgraDoc igra,KeyEventArgs e)
        {
            SmeniSlika(e);
            DesnaNoga = !DesnaNoga;

            if (e.KeyCode == Keys.Enter)
                return false;

            if (Nasoka == Nasoka.Desno)
            {
                if (igra.goalfound())
                    return false;
                
                int j = (X + 50 + pridvizuvanje - igra.lavirint.PocetokX) / Labyrinth.goleminaPole;
                int i = (Y + 70 - igra.lavirint.PocetokY) / Labyrinth.goleminaPole;
                    if (igra.lavirint.Maze[i][j])
                    {
                        X += pridvizuvanje;
                        return true;
                    }
            }
            else if (Nasoka == Nasoka.Levo)
            {
                int j = (X + 32 - pridvizuvanje - igra.lavirint.PocetokX) / Labyrinth.goleminaPole;
                int i = (Y + 70 - igra.lavirint.PocetokY) / Labyrinth.goleminaPole;

                if (j <= 0)
                    return false;

                if (igra.lavirint.Maze[i][j])
                {
                    X -= pridvizuvanje;
                    return true;
                }

            }
            else if (Nasoka == Nasoka.Gore)
            {
                int j = (X + 32 - igra.lavirint.PocetokX) / Labyrinth.goleminaPole;
                int i = (Y + 70 - pridvizuvanje - igra.lavirint.PocetokY) / Labyrinth.goleminaPole;
                if (igra.lavirint.Maze[i][j])
                {
                    Y -= pridvizuvanje;
                    return true;
                }
            }
            else if (Nasoka == Nasoka.Dole)
            {
                int j = (X + 32 - igra.lavirint.PocetokX) / Labyrinth.goleminaPole;
                int i = (Y + 70 + pridvizuvanje - igra.lavirint.PocetokY) / Labyrinth.goleminaPole;
                if (igra.lavirint.Maze[i][j]) { 
                    Y += pridvizuvanje;
                    return true;
                }
            }
            return false;
        }

        public void Draw(Graphics g1)
        {
            g1.DrawImageUnscaled(img, X, Y);
        }

       
    }
}

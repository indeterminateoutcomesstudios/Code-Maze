using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace Lavirint
{
    public enum Nasoka
    {
        Gore,
        Dole,
        Levo,
        Desno
    };

    public class Karakter
    {
        public string Ime { get; set; }
        public Nasoka Nasoka { get; set; }
        public bool DesnaNoga { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public static int pridvizuvanje = 10;

        public Karakter(string ime, int x, int y)
        {
            Ime = ime;
            Nasoka = Nasoka.Gore;
            DesnaNoga = false;
            X = x;
            Y = y;
        }

        public void SmeniNasoka(Nasoka nasoka)
        {
            Nasoka = nasoka;
        }

        public Boolean Move(Igra igra)
        {
            DesnaNoga = !DesnaNoga;
            if (Nasoka == Nasoka.Desno)
            {
                int j = (X + 50 + pridvizuvanje - igra.PocetokX) / Igra.goleminaPole;
                int i = (Y + 70 - igra.PocetokY) / Igra.goleminaPole;
                if (igra.lavirint.Maze[i][j])
                {
                    X += pridvizuvanje;
                    return true;
                }

            }
            else if (Nasoka == Nasoka.Levo)
            {
                int j = (X + 32 - pridvizuvanje - igra.PocetokX) / Igra.goleminaPole;
                int i = (Y + 70 - igra.PocetokY) / Igra.goleminaPole;
                if (igra.lavirint.Maze[i][j])
                {
                    X -= pridvizuvanje;
                    return true;
                }

            }
            else if (Nasoka == Nasoka.Gore)
            {
                int j = (X + 32 - igra.PocetokX) / Igra.goleminaPole;
                int i = (Y + 70 - pridvizuvanje - igra.PocetokY) / Igra.goleminaPole;
                if (igra.lavirint.Maze[i][j])
                {
                    Y -= pridvizuvanje;
                    return true;
                }
            }
            else if (Nasoka == Nasoka.Dole)
            {
                int j = (X + 32 - igra.PocetokX) / Igra.goleminaPole;
                int i = (Y + 70 + pridvizuvanje - igra.PocetokY) / Igra.goleminaPole;
                if (igra.lavirint.Maze[i][j]) { 
                    Y += pridvizuvanje;
                    return true;
                }
            }
            return false;
        }
    }
}

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

        public void Move()
        {
            DesnaNoga = !DesnaNoga;

            switch (Nasoka)
            {
                case Nasoka.Desno:
                    X += 16;
                    break;
                case Nasoka.Levo:
                    X -= 16;
                    break;
                case Nasoka.Gore:
                    Y -= 16;
                    break;
                case Nasoka.Dole:
                    Y += 16;
                    break;
            }
        }
    }
}

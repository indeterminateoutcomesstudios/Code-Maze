using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lavirint
{
    [Serializable]
    public class IgraDoc
    {
        public int sec { get; set; }
        public int min { get; set; }
        public int correctAnswers { get; set; }
        public int wrongAnswers { get; set; }

        public Karakter karakter;
        public Labyrinth lavirint { get; set; }
        public string playerName {get;set;}

        //da se cuvaat tuka za koga ke se load-a igra da se znae do koe prasanje sme
        //public List<Prasanje> prasanja{get;set;}
        //public int slednoPrasanje{get;set;}
        public IgraDoc(string ime, string playerName,  int size)
        {
            this.sec = 0;
            this.min = 0;
            this.correctAnswers = 0;
            this.wrongAnswers = 0;
            lavirint = new Labyrinth(size);
            karakter = new Karakter(ime, 12, -5);
            this.playerName = playerName;
        }

        public void Draw(Graphics g1)
        {
            lavirint.Draw(g1);
            karakter.Draw(g1);
        }
        public Boolean goalfound()
        {
            return getCurrentNode().IsEqual(lavirint.Goal);
        }
        public void updatTime()
        {
            sec++;
            if (sec == 60)
            {
                sec = 0;
                min++;
            }
        }

        public void Move(KeyEventArgs e)
        {
            if (karakter.Move(this,e))
                pomestiEkran(e, karakter.Nasoka);

            if (goalfound())
            {
                MessageBox.Show("Congrats!");
                return;
            }
        }

        public void postaviPrasanje()
        {
            //ako tocno odgovoril
            //correctAnswers++
            //hint();
            //ako ne
            //wrongAnswers
            //MessageBox.Show("nesto");

        }


        public Node getCurrentNode()
        {
            int j = (karakter.X + 50 - lavirint.PocetokX) / Labyrinth.goleminaPole;
            int i = (karakter.Y + 70 - lavirint.PocetokY) / Labyrinth.goleminaPole;
            return lavirint.MazeofNodes[i][j];
        }

        public void hint()
        {
            lavirint.makeNodes();
            lavirint.Curret = getCurrentNode();
            
            var astar = new Astar(lavirint.Curret, lavirint.Goal);
            var state = astar.Run();

            MessageBox.Show(String.Format("{0}", Labyrinth.GetDirections(astar.GetPath())));
        }

        private void pomestiEkran(KeyEventArgs e, Nasoka nasoka)
        {
            if (nasoka == Nasoka.Desno && karakter.X >= 350 && lavirint.PocetokX > (600 - lavirint.cols * Labyrinth.goleminaPole))
            {
                lavirint.PocetokX = Math.Max(lavirint.PocetokX - Karakter.pridvizuvanje, 600 - lavirint.cols * Labyrinth.goleminaPole);
                karakter.X -= Karakter.pridvizuvanje;
            }
            if (nasoka == Nasoka.Levo && karakter.X <= 250 && lavirint.PocetokX < 0)
            {
                lavirint.PocetokX = Math.Min(lavirint.PocetokX + Karakter.pridvizuvanje, 0);
                karakter.X += Karakter.pridvizuvanje;
            }
            if (nasoka == Nasoka.Dole && karakter.Y >= 350 && lavirint.PocetokY > (600 - (lavirint.rows) * Labyrinth.goleminaPole))
            {
                lavirint.PocetokY = Math.Max(lavirint.PocetokY - Karakter.pridvizuvanje, 600 - lavirint.rows * Labyrinth.goleminaPole);
                karakter.Y -= Karakter.pridvizuvanje;
            }
            if (nasoka == Nasoka.Gore && karakter.Y <= 250 && lavirint.PocetokY < 0)
            {
                lavirint.PocetokY = Math.Min(lavirint.PocetokY + Karakter.pridvizuvanje, 0);
                karakter.Y += Karakter.pridvizuvanje;
            }
        }
    }
}

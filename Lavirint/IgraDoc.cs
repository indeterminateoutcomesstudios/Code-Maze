using Lavirint.Properties;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Resources;
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
        public int size { get; set; }
        public int lastsave { get; set; }

        public Karakter karakter;
        public Labyrinth lavirint { get; set; }
        public string playerName {get;set;}

        public List<QuestionClass> prasanja { get; set; }
        public bool gameOver { get; set; }
       // public Igra parent { get; set; }

        public IgraDoc(string playerName, int size)
        {
            this.playerName = playerName;
            this.size = size;
        }

        public IgraDoc(string ime, string playerName,  int size)
        {
            this.lastsave = 0;
            this.sec = 0;
            this.min = 0;
            this.correctAnswers = 0;
            this.wrongAnswers = 0;
            lavirint = new Labyrinth(size);
            this.size = size;
            karakter = new Karakter(ime, 12, -5);
            this.playerName = playerName;
            Random rnd = new Random();
            var images = Resources.ResourceManager
                       .GetResourceSet(CultureInfo.CurrentCulture, true, true)
                       .Cast<DictionaryEntry>()
                       .Where(x => x.Value.GetType() == typeof(Bitmap) && x.Key.ToString().StartsWith("q"))
                       .Select(x => new { Name = x.Key.ToString(), Image = x.Value })
                       .OrderBy(x => rnd.Next())
                       .ToList();
            prasanja = new List<QuestionClass>();
            if (size == 20)
            {
                for(int i = 0; i<10; i++)
                {
                    prasanja.Add(new QuestionClass(images[i].Image as Image, images[i].Name[3]));
                }
            }
            else if(size == 30)
            {
                for (int i = 0; i < 15; i++)
                {
                    prasanja.Add(new QuestionClass(images[i].Image as Image, images[i].Name[3]));
                }
            }
            else
            {
                foreach (var img in images)
                    prasanja.Add(new QuestionClass(img.Image as Image, img.Name[3]));
            }
            gameOver = false;
            //parent = p;
        }
 
        public void Draw(Graphics g1)
        {
            lavirint.Draw(g1);
            karakter.Draw(g1);
        }

        public Boolean goalfound()
        {
            if (getCurrentNode().IsEqual(lavirint.Goal))
            {
                gameOver = true;
                return true;
            }
            return false;
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
        }

        public bool postaviPrasanje()
        {
            if(prasanja.Count != 0)
            {
                Questions q = new Questions(prasanja.First(), this);
                q.ShowDialog();
                prasanja.RemoveAt(0);
                return true;
            }
            else
            {
                MessageBox.Show("Game over","GAME OVER\nGet back to school!");
               
                return false;
            }
            
        }

        public int getPoints()
        {
            return min * 60 + sec + wrongAnswers * 10;
        }

        public override string ToString()
        {
            return playerName + " " + size + " " + min + " " + sec + " " + correctAnswers + " " + wrongAnswers;
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

            MessageBox.Show(String.Format("{0}", Labyrinth.GetDirections(astar.GetPath())), "Correct!!!");
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

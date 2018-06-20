using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lavirint.Properties;

namespace Lavirint
{
    public partial class Igra : Form
    {
       
        Form1 parent;
        IgraDoc game;
        bool isHighScore;
        int level;

        public string FileName { get; set; }

        public Igra(Form1 parent, string ime="", string playerName="", int size=10)
        {
            InitializeComponent();
            DoubleBuffered = true;
            game = new IgraDoc(ime, playerName, size);
            this.parent = parent;
            timer.Start();
            toolStripStatusLabel1.Text="Time :00:00";
            toolStripStatusLabel2.Text = String.Format("Correct: {0}",game.correctAnswers);
            toolStripStatusLabel3.Text = String.Format("Inorrect: {0}", game.wrongAnswers);
            toolStripStatusLabel4.Text = "Player: " + game.playerName;
            isHighScore = false;
            if (size == 30)
                level = 1;
            else if (size == 40)
                level = 2;
            else level = 0;
        }

        private void Igra_Paint(object sender, PaintEventArgs e)
        {
            Graphics g1 = e.Graphics;
            g1.Clear(Color.White);
            game.Draw(g1);
        }

        private void Igra_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Escape)
            {
                if ((game.min * 60 + game.sec > (game.lastsave + 2)) || game.lastsave==0)
                {
                    timer.Stop();
                    DialogResult dr = MessageBox.Show("Do you want to save the game?", "Save game", MessageBoxButtons.YesNoCancel);
                    if (dr == DialogResult.Yes)
                    {
                        DialogResult d = saveFile();
                        if (d == DialogResult.OK)
                        {
                            this.Close();
                            timer.Stop();
                            parent.Show();
                        }
                        else
                        {
                            timer.Start();
                        }
                    }

                    if (dr == DialogResult.No)
                    {
                        this.Close();
                        timer.Stop();
                        parent.Show();
                    }
                    if (dr == DialogResult.Cancel)
                        timer.Start();
                }
                else
                {
                    this.Close();
                    timer.Stop();
                    parent.Show();
                }
            }
           
            if(e.KeyCode== Keys.S)
            {
                timer.Stop();
                DialogResult d=saveFile();
                if (d == DialogResult.OK)
                {
                    timer.Start();
                }
                else
                    timer.Start();
            }

            if(e.KeyCode == Keys.Up || e.KeyCode == Keys.Down || e.KeyCode == Keys.Left || e.KeyCode == Keys.Right)
            {
                game.Move(e);
                Invalidate();
            }
 
        }
        public void updatStatusStrip()
        {
            toolStripStatusLabel1.Text = string.Format("Time: {0:D2}:{1:D2}", game.min, game.sec);
            toolStripStatusLabel2.Text = String.Format("Correct: {0}", game.correctAnswers);
            toolStripStatusLabel3.Text = String.Format("Inorrect: {0}", game.wrongAnswers);
            toolStripStatusLabel4.Text = "Player: " + game.playerName;
        }

        private DialogResult saveFile()
        {
            if (FileName == null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Labyrinth doc file (*.lbr)|*.lbr";
                saveFileDialog.Title = "Save labyrinth doc";
                saveFileDialog.FileName = FileName;
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    FileName = saveFileDialog.FileName;
                    return DialogResult.OK;
                }
                return DialogResult.Cancel;
            }
            if (FileName != null)
            {
                using (FileStream fileStream = new FileStream(FileName, FileMode.Create))
                {
                    game.lastsave = game.min * 60 + game.sec;
                    IFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(fileStream, game);
                    
                }
                return DialogResult.OK;
            }
            return DialogResult.Cancel;
           

        }

        public Boolean openFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Labyrinth doc file (*.lbr)|*.lbr";
            openFileDialog.Title = "Open labyrinth doc file";
           
            if (openFileDialog.ShowDialog()== DialogResult.OK)
            {
                FileName = openFileDialog.FileName;
                
                    using (FileStream fileStream = new FileStream(FileName, FileMode.Open))
                    {
                        IFormatter formater = new BinaryFormatter();
                        game = (IgraDoc)formater.Deserialize(fileStream);
                    }
                
                Invalidate(true);
                return true;
            }
            
            return false;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            game.updatTime();
            updatStatusStrip();
            if (game.sec == 30 || (game.sec == 0 && game.min != 0))
            {
                timer.Stop();
                bool temp=game.postaviPrasanje();
                if (temp)
                    timer.Start();
                else
                    this.Close();
            }
            if (game.gameOver)
            {
                timer.Stop();
                updateScores();
                if (isHighScore)
                {
                    MessageBox.Show("Congratulations!!!\nYou've just won a place at Hall of Fame!", "You won!");
                    HighScores hs = new HighScores(parent, level);
                    this.Close();
                    timer.Stop();
                    hs.Show();
                }
                else
                {
                    MessageBox.Show(String.Format("Time: {0}:{1}\nCorrect Answers: {2}\nWrong Answers: {3}", game.min, game.sec, game.correctAnswers, game.wrongAnswers),"You won!");
                    this.Close();
                    timer.Stop();
                    parent.Show();
                }
            }
        }

        public void updateScores()
        {
            string path = (Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/Scores.txt");
            string line = game.ToString();
            if (File.Exists(path))
            {
                StreamReader reader = null;
                reader = new StreamReader(path);
                List<IgraDoc> games = new List<IgraDoc>();
                string[] txtLine;
                string str;
                while ((str = reader.ReadLine()) != null)
                {
                    txtLine = str.Split(' ');
                    games.Add(new IgraDoc(txtLine[0], Convert.ToInt32(txtLine[1]))
                    {
                        min = Convert.ToInt32(txtLine[2]),
                        sec = Convert.ToInt32(txtLine[3]),
                        correctAnswers = Convert.ToInt32(txtLine[4]),
                        wrongAnswers = Convert.ToInt32(txtLine[5])
                    });
                }
                reader.Close();

                games.Add(game);
                games.Sort(delegate (IgraDoc ig1, IgraDoc ig2)
                {
                    return ig1.getPoints().CompareTo(ig2.getPoints());
                });

                List<IgraDoc> easy = new List<IgraDoc>();
                List<IgraDoc> meddium = new List<IgraDoc>();
                List<IgraDoc> hard = new List<IgraDoc>();

                foreach (IgraDoc g in games)
                {
                    if (g.size == 20)
                        easy.Add(g);
                    if (g.size == 30)
                        meddium.Add(g);
                    if (g.size == 40)
                        hard.Add(g);
                }

                if (easy.Count > 3)
                {
                    easy = easy.GetRange(0, 3);
                }
                if (easy.Contains(game))
                    isHighScore = true;

                if (meddium.Count > 3)
                {
                    meddium = meddium.GetRange(0, 3);
                }
                if (meddium.Contains(game))
                    isHighScore = true;

                if (hard.Count > 3)
                {
                    hard = hard.GetRange(0, 3);
                }
                if (hard.Contains(game))
                    isHighScore = true;

                StringBuilder sb = new StringBuilder();
                foreach (IgraDoc ig in easy)
                    sb.AppendLine(ig.ToString());
                foreach (IgraDoc ig in meddium)
                    sb.AppendLine(ig.ToString());
                foreach (IgraDoc ig in hard)
                    sb.AppendLine(ig.ToString());

                StreamWriter sw = new StreamWriter(path,false);
                sw.Write(sb.ToString());
                sw.Close();
            }
            else
            {
                StreamWriter sw = File.CreateText(path);
                sw.Close();
                sw = File.AppendText(path);
                sw.WriteLine(line);
                isHighScore = true;
                sw.Close();
            }
        }
    }
}

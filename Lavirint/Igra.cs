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
        int sec;
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
                timer.Stop();
                DialogResult dr = MessageBox.Show("Do you want to save the game ?", "Save game", MessageBoxButtons.YesNoCancel);
                if (dr == DialogResult.Yes)
                {
                    saveFile();
                    parent.Show();
                }

                if (dr == DialogResult.No)
                {
                    this.Close();
                    parent.Show();
                }
                if (dr == DialogResult.Cancel)
                    timer.Start();

                
            }
            if(e.KeyCode == Keys.H)
            {
                game.hint();
            }

            game.Move(e);
            Invalidate();
        }
        public void updatStatusStrip()
        {
            toolStripStatusLabel1.Text = string.Format("Time: {0:D2}:{1:D2}", game.min, game.sec);
            toolStripStatusLabel2.Text = String.Format("Correct: {0}", game.correctAnswers);
            toolStripStatusLabel3.Text = String.Format("Inorrect: {0}", game.wrongAnswers);
            toolStripStatusLabel4.Text = "Player: " + game.playerName;
        }

        private void saveFile()
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
                }
            }
            if (FileName != null)
            {
                using (FileStream fileStream = new FileStream(FileName, FileMode.Create))
                {
                    IFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(fileStream, game);
                }
            }
            this.Close();
            parent.Show();
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
            /*if (game.sec == 30)
            {
                timer.Stop();
                game.postaviPrasanje();
                timer.Start();
            }*/
        }
    }
}

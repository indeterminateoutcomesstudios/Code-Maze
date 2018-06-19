using Lavirint.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lavirint
{
    public partial class HighScores : Form
    {
        Form1 parent;
        List<IgraDoc> easy;
        List<IgraDoc> meddium;
        List<IgraDoc> hard;
        Label[] arr;
        int level;

        public HighScores(Form1 p, int l=0)
        {
            InitializeComponent();
            parent = p;
            level = l;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            string path = (Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/Scores.txt");
            if (File.Exists(path))
            {
                StreamReader reader = null;
                reader = new StreamReader(path);
                List<IgraDoc> games = new List<IgraDoc>();
                string[] txtLine;
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    txtLine = line.Split(' ');
                    games.Add(new IgraDoc(txtLine[0], Convert.ToInt32(txtLine[1]))
                    {
                        min = Convert.ToInt32(txtLine[2]),
                        sec = Convert.ToInt32(txtLine[3]),
                        correctAnswers = Convert.ToInt32(txtLine[4]),
                        wrongAnswers = Convert.ToInt32(txtLine[5])
                    });
                }
                reader.Close();

                easy = new List<IgraDoc>();
                meddium = new List<IgraDoc>();
                hard = new List<IgraDoc>();

                foreach(IgraDoc g in games)
                {
                    if (g.size == 20)
                        easy.Add(g);
                    if (g.size == 30)
                        meddium.Add(g);
                    if (g.size == 40)
                        hard.Add(g);
                }

                arr = new Label[] { lblName1, lblTime1, lblCorrect1, lblWrong1,
                    lblName2, lblTime2, lblCorrect2, lblWrong2,
                    lblName3, lblTime3, lblCorrect3, lblWrong3 };
                lstLevel.SelectedIndex = level;
                loadItems();
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            parent.Show();
            this.Close();
        }

        private void btnBack_MouseEnter(object sender, EventArgs e)
        {
            this.btnBack.BackgroundImage = Resources.No_hover;
        }

        private void btnBack_MouseLeave(object sender, EventArgs e)
        {
            this.btnBack.BackgroundImage = Resources.No;
        }

        private void loadItems()
        {
            foreach (Label a in arr)
                a.Text = "";
            int i = 0;
            if (lstLevel.SelectedIndex == 0)
            {
                foreach (IgraDoc game in easy)
                {
                    arr[i++].Text = game.playerName;
                    arr[i++].Text = game.min + ":" + game.sec;
                    arr[i++].Text = game.correctAnswers.ToString();
                    arr[i++].Text = game.wrongAnswers.ToString();
                }
            }
            if (lstLevel.SelectedIndex == 1)
            {
                foreach (IgraDoc game in meddium)
                {
                    arr[i++].Text = game.playerName;
                    arr[i++].Text = game.min + ":" + game.sec;
                    arr[i++].Text = game.correctAnswers.ToString();
                    arr[i++].Text = game.wrongAnswers.ToString();
                }
            }
            if (lstLevel.SelectedIndex == 2)
            {
                foreach (IgraDoc game in hard)
                {
                    arr[i++].Text = game.playerName;
                    arr[i++].Text = game.min + ":" + game.sec;
                    arr[i++].Text = game.correctAnswers.ToString();
                    arr[i++].Text = game.wrongAnswers.ToString();
                }
            }
        }

        private void lstLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadItems();
        }
    }
}

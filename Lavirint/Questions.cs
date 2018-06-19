using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lavirint
{
    public partial class Questions : Form {

        public char answer;
        IgraDoc game;
        int sec;
        Igra parent;

        public Questions(QuestionClass prasanje, IgraDoc g, Igra p)
        {
            InitializeComponent();
            sec = 0;
            timer1.Start();
            this.BackgroundImage = prasanje.Img;
            answer = prasanje.Answer;
            game = g;
            parent = p;
        }

        private void buttonA_Click(object sender, EventArgs e)
        {
            if (answer.Equals('A'))
            {
                game.correctAnswers++;
                game.hint();
            }
            else game.wrongAnswers++;
            parent.timer.Start();
            this.Close();
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            if (answer.Equals('C'))
            {
                game.correctAnswers++;
                game.hint();
            }
            else game.wrongAnswers++;
            parent.timer.Start();
            this.Close();
        }

        private void buttonB_Click(object sender, EventArgs e)
        {
            if (answer.Equals('B'))
            {
                game.correctAnswers++;
                game.hint();
            }
            else game.wrongAnswers++;
            parent.timer.Start();
            this.Close();
        }

        private void buttonD_Click(object sender, EventArgs e)
        {
            if (answer.Equals('D'))
            {
                game.correctAnswers++;
                game.hint();
            }
            else game.wrongAnswers++;
            parent.timer.Start();
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(sec == 30)
            {
                game.wrongAnswers++;
                parent.timer.Start();
                this.Close();
            }
        }
    }
}

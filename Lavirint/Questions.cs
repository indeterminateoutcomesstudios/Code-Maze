using Lavirint.Properties;
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
            this.Close();
            if (answer.Equals('A'))
            {
                game.correctAnswers++;
                game.hint();
            }
            else game.wrongAnswers++;
            parent.timer.Start();
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            this.Close();
            if (answer.Equals('C'))
            {
                game.correctAnswers++;
                game.hint();
            }
            else game.wrongAnswers++;

            parent.timer.Start();
        }

        private void buttonB_Click(object sender, EventArgs e)
        {
            this.Close();
            if (answer.Equals('B'))
            {
                game.correctAnswers++;
                game.hint();
            }
            else game.wrongAnswers++;
            parent.timer.Start();
        }

        private void buttonD_Click(object sender, EventArgs e)
        {
            this.Close();
            if (answer.Equals('D'))
            {
                game.correctAnswers++;
                game.hint();
            }
            else game.wrongAnswers++;
            parent.timer.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(sec == 30)
            {
                game.wrongAnswers++;
                this.Close();
                parent.timer.Start();
            }
            sec++;
        }

        private void buttonA_MouseEnter(object sender, EventArgs e)
        {
            buttonA.BackgroundImage = Resources.Yes_hover;
        }

        private void buttonA_MouseLeave(object sender, EventArgs e)
        {
            buttonA.BackgroundImage = Resources.Yes;
        }

        private void buttonC_MouseEnter(object sender, EventArgs e)
        {
            buttonC.BackgroundImage = Resources.Yes_hover;
        }

        private void buttonC_MouseLeave(object sender, EventArgs e)
        {
            buttonC.BackgroundImage = Resources.Yes;
        }

        private void buttonB_MouseEnter(object sender, EventArgs e)
        {
            buttonB.BackgroundImage = Resources.Yes_hover;
        }

        private void buttonB_MouseLeave(object sender, EventArgs e)
        {
            buttonB.BackgroundImage = Resources.Yes;
        }

        private void buttonD_MouseEnter(object sender, EventArgs e)
        {
            buttonD.BackgroundImage = Resources.Yes_hover;
        }

        private void buttonD_MouseLeave(object sender, EventArgs e)
        {
            buttonD.BackgroundImage = Resources.Yes;
        }
    }
}

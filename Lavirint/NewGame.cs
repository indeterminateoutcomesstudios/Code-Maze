using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lavirint.Properties;

namespace Lavirint
{
    public partial class NewGame : Form
    {
        public NewGame()
        {
            InitializeComponent();
            btnStart.Enabled = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Close();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Igra igra = new Igra(lblPlayer.Text);
            igra.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox2.BorderStyle = BorderStyle.None;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            lblPlayer.Text = "Sara";
            btnStart.Enabled = true;
            btnStart.BackgroundImage = Resources.Yes;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox1.BorderStyle = BorderStyle.None;
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            lblPlayer.Text = "Lidia";
            btnStart.Enabled = true;
            btnStart.BackgroundImage = Resources.Yes;
        }

        private void btnBack_MouseEnter(object sender, EventArgs e)
        {
            this.btnBack.BackgroundImage = Resources.No_hover;
        }

        private void btnBack_MouseLeave(object sender, EventArgs e)
        {
            this.btnBack.BackgroundImage = Resources.No;
        }

        private void btnStart_MouseEnter(object sender, EventArgs e)
        {
            this.btnStart.BackgroundImage = Resources.Yes_hover;
        }

        private void btnStart_MouseLeave(object sender, EventArgs e)
        {
            this.btnStart.BackgroundImage = Resources.Yes;
        }
    }
}

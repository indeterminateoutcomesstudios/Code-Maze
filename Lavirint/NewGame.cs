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
        Form1 parent;
        private bool player;
        private String name;
        private String playerName;
        private int size;

        public NewGame(Form1 parent)
        {
            this.parent = parent;
            InitializeComponent();
            btnStart.Enabled = false;
            player = false;
            name = "";
            playerName = "";
            size = 20;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            parent.Show();
            this.Close();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Igra igra = new Igra(parent, playerName,name,size);
            igra.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox2.BorderStyle = BorderStyle.None;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            player = true;
            playerName = "Sara";
            check();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox1.BorderStyle = BorderStyle.None;
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            player = true;
            playerName = "Lidia";
            check();
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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            check();
            size = 20;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            check();
            size = 30;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            check();
            size = 40;
        }

        private void check()
        {
            name = tbName.Text.Trim();
            if (player && (radioButton1.Checked || radioButton2.Checked || radioButton3.Checked) && name.Length > 1)
            {
                btnStart.Enabled = true;
                btnStart.BackgroundImage = Resources.Yes;
            }
            else
            {
                btnStart.Enabled = false;
                btnStart.BackgroundImage = Resources.Yes_locked;
            }
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {
            check();
        }
    }
}

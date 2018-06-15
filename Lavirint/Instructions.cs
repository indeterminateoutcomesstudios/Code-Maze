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
    public partial class Instructions : Form
    {
        private Form1 parent;
        public Instructions(Form1 p)
        {
            InitializeComponent();
            parent = p;
        }

        private void Instructions_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            parent.Show();
            this.Close();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackgroundImage = Resources.No_hover;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackgroundImage = Resources.No;
        }
    }
}

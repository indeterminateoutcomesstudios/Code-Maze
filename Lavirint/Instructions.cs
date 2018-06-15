using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lavirint
{
    public partial class Instructions : Form
    {
        public Instructions()
        {
            InitializeComponent();
            lblIns.Text = "Lavirint is a single player game with one goal: to get from start to finish.";
        }
    }
}

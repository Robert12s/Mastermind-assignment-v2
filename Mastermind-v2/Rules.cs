using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mastermind_v2
{
    public partial class Rules : Form
    {
        public Rules()
        {
            InitializeComponent();
        }
        private void startGame_Click(object sender, EventArgs e)
        {
            Military military = new Military();
            this.Hide();
            military.Show();
        }

        private void Rules_Load(object sender, EventArgs e)
        {

        }
    }
}

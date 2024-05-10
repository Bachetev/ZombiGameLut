using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameLut
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            LEVEL1 lEVEL1 = new LEVEL1();

            lEVEL1.Show();

            this.Hide();
        }

        private void btnLevels_Click(object sender, EventArgs e)
        {
            Levels levels = new Levels();

            levels.Show();

            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnControl_Click(object sender, EventArgs e)
        {
            Set set = new Set();
            set.Show();
            this.Hide();
        }
    }
}

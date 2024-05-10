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
    public partial class Levels : Form
    {
        public Levels()
        {
            InitializeComponent();
        }

        private void btnLevel1_Click(object sender, EventArgs e)
        {
            LEVEL1 lEVEL = new LEVEL1();

            lEVEL.Show();

            this.Hide();
        }

        private void btnLevel2_Click(object sender, EventArgs e)
        {
            LEVEL2 lEVEL2 = new LEVEL2();

            lEVEL2.Show();

            this.Hide();
        }

        private void btnLevel3_Click(object sender, EventArgs e)
        {
            LEVEL3 lEVEL3 = new LEVEL3();
            lEVEL3.Show();
            this.Hide();
        }


        private void btnMenu_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();

            menu.Show();

            this.Hide();
        }
    }
}

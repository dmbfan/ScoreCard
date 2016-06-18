using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScoreCard
{
    public partial class Hit : Form
    {
        protected int hitSingle;
        protected int hitDouble;
        protected int hitTriple;
        protected int hitHomeRun;
        protected string fieldersChoice;
        public Hit()
        {
            InitializeComponent();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            hitHomeRun = 4;
        }

        private void rdioSingle_CheckedChanged(object sender, EventArgs e)
        {
            hitSingle = 1;
        }

        private void rdioDouble_CheckedChanged(object sender, EventArgs e)
        {
            hitDouble = 2;
        }

        private void rdioTriple_CheckedChanged(object sender, EventArgs e)
        {
            hitTriple = 3;
        }

        private void rdioFielderChoice_CheckedChanged(object sender, EventArgs e)
        {
            fieldersChoice = Convert.ToString(txtBoxHitFC.Text);
        }


    }
}

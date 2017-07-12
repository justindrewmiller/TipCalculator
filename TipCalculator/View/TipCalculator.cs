using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TipCalculator
{
    public partial class TipCalculator : Form
    {
        public TipCalculator()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void contactInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Applicated created by Justin Miller. Sends issues with application at justindrewmiller@gmail.com", "About Creator");
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TipCalculator resetForm = new TipCalculator();
            resetForm.Show();
            this.Dispose(false);
        }
    }
}

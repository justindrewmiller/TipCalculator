using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TipCalculator.Model;

namespace TipCalculator
{
    public partial class TipCalculator : Form
    {
        private Bill theBill;

        private static double TAXRATE = 1.06;

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
            this.theBill = null;
            this.txtInput.Clear();
            this.lblResult.Text = String.Empty;
        }

        private void btnTax_Click(object sender, EventArgs e)
        {
            try
            {
                string input = txtInput.Text;
                this.theBill = this.errorCheck(input);
                lblResult.Text = this.theBill.getBillSum().ToString("#.00");
            }
            catch (Exception)
            {
                this.resetToolStripMenuItem_Click(sender, e);
            }

        }

        private Bill errorCheck(string input)
        {
            try
            {
                Bill newBill = new Bill(Convert.ToDouble(input), TAXRATE);
                return newBill;
            } catch (Exception)
            {
                MessageBox.Show("Invalid input", "Invalid");
                return null;
            }
        }
    }
}

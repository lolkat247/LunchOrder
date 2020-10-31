using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LunchOrder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void rbHam_CheckedChanged(object sender, EventArgs e)
        {
            if (rbHam.Checked)
            {
                gbAdd.Text = "Add-on items ($.75/each)";
                cbAdd1.Text = "Lettuce, tomato, and onions";
                cbAdd2.Text = "Ketchup, mustard, and mayo";
                cbAdd3.Text = "French fries";
            }
        }

        private void rbPizza_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPizza.Checked)
            {
                gbAdd.Text = "Add-on items ($.50/each)";
                cbAdd1.Text = "Pepperoni";
                cbAdd2.Text = "Sausage";
                cbAdd3.Text = "Olives";
            }
        }

        private void rbSalad_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSalad.Checked)
            {
                gbAdd.Text = "Add-on items ($.25/each)";
                cbAdd1.Text = "Croutons";
                cbAdd2.Text = "Bacon bits";
                cbAdd3.Text = "Bread sticks";
            }
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            double dec = 0.0;
            int addonCount = 0;
            if (cbAdd1.Checked) { addonCount++; }
            if (cbAdd2.Checked) { addonCount++; }
            if (cbAdd3.Checked) { addonCount++; }
            
            if (rbHam.Checked) { dec = 6.95 + (0.75 * addonCount); }
            if (rbPizza.Checked) { dec = 5.95 + (0.50 * addonCount); }
            if (rbSalad.Checked) { dec = 4.95 + (0.25 * addonCount); }

            lblSubtotal.Text = Convert.ToString(dec);
        }
    }
}
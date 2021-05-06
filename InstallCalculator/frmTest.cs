using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstallCalculator
{
    public partial class frmTest : Form
    {
        public frmTest()
        {
            InitializeComponent();
            radioUpTo2hours.Checked = true;
            //this.Icon = Properties.Resources.
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //many many variables
            int singleIncludingSR1AndSR2 = 0, doubleIncludingSR1AndSR2 = 0, singleIncludingSR1andSR2WithPanel = 0, doubleIncludingSR1AndSR2WithPanel = 0, singleSR3AndSR3WithPanels = 0, doubleSR3AndSR3WithPanels = 0, travelCost = 0,panels = 0;
            double singleIncludingSR1AndSR2Total = 0, doubleIncludingSR1AndSR2Total = 0, singleIncludingSR1andSR2WithPanelTotal = 0, doubleIncludingSR1AndSR2WithPanelTotal = 0, singleSR3AndSR3WithPanelsTotal = 0, doubleSR3AndSR3WithPanelsTotal = 0,panelsTotal = 0;

            if (String.IsNullOrEmpty(txtSingleInludingSR1andSR2.Text))
                singleIncludingSR1AndSR2 = 0;
            else
                singleIncludingSR1AndSR2 = Convert.ToInt32(txtSingleInludingSR1andSR2.Text);

            if (String.IsNullOrEmpty(txtDoubleIncludingSR1AndSR2.Text))
                doubleIncludingSR1AndSR2 = 0;
            else
                doubleIncludingSR1AndSR2 = Convert.ToInt32(txtDoubleIncludingSR1AndSR2.Text);

            if (String.IsNullOrEmpty(txtSingleIncludingSR1AndSR2WithPanel.Text))
                singleIncludingSR1andSR2WithPanel = 0;
            else
                singleIncludingSR1andSR2WithPanel = Convert.ToInt32(txtSingleIncludingSR1AndSR2WithPanel.Text);

            if (String.IsNullOrEmpty(txtDoubleIncludingSR1AndSR2WithPanel.Text))
                doubleIncludingSR1AndSR2WithPanel = 0;
            else
                doubleIncludingSR1AndSR2WithPanel = Convert.ToInt32(txtDoubleIncludingSR1AndSR2WithPanel.Text);

            if (String.IsNullOrEmpty(txtSingleSR3AndSR3WithPanels.Text))
                singleSR3AndSR3WithPanels = 0;
            else
                singleSR3AndSR3WithPanels = Convert.ToInt32(txtSingleSR3AndSR3WithPanels.Text);

            if (String.IsNullOrEmpty(txtDoubleSR3AndSR3WithPanels.Text))
                doubleSR3AndSR3WithPanels = 0;
            else
                doubleSR3AndSR3WithPanels = Convert.ToInt32(txtDoubleSR3AndSR3WithPanels.Text);

            if (String.IsNullOrEmpty(txtPanels.Text))
                panels = 0;
            else
                panels = Convert.ToInt32(txtPanels.Text);

            if (radioOver2Hours.Checked == true)
                travelCost = 500;
            else
                travelCost = 400;

           // double singleIncludingSR1AndSR2Total = 0, doubleIncludingSR1AndSR2Total = 0, singleIncludingSR1andSR2WithPanelTotal = 0, doubleIncludingSR1AndSR2WithPanelTotal = 0, singleSR3AndSR3WithPanelsTotal = 0, doubleSR3AndSR3WithPanelsTotal = 0;
            singleIncludingSR1AndSR2Total = ((travelCost / 3) * singleIncludingSR1AndSR2);
            //vv^^ panels copy the same as a normal single door
            panelsTotal = ((travelCost / 3) * panels); //except with panels ofc

            doubleIncludingSR1AndSR2Total = ((travelCost / 2) * doubleIncludingSR1AndSR2);
            singleIncludingSR1andSR2WithPanelTotal = ((travelCost / 3) * singleIncludingSR1andSR2WithPanel * 1.3);
            doubleIncludingSR1AndSR2WithPanelTotal = ((travelCost / 2 * doubleIncludingSR1AndSR2WithPanel) * 1.3);
            singleSR3AndSR3WithPanelsTotal = ((travelCost / 3) * singleSR3AndSR3WithPanels * 1.5);
            doubleSR3AndSR3WithPanelsTotal = ((travelCost / 2) * doubleSR3AndSR3WithPanels * 1.5);




            txtSingleIncludingSR1andSr2Total.Text = singleIncludingSR1AndSR2Total.ToString();
            //vv^^ this is same again
            txtPanelTotal.Text = panelsTotal.ToString(); //again with panels ofc

            txtDoubleIncludingSR1andSr2Total.Text = doubleIncludingSR1AndSR2Total.ToString();
            txtSingleIncludingSR1AndSR2WithPanelTotal.Text = singleIncludingSR1andSR2WithPanelTotal.ToString();
            txtDoubleIncludingSR1AndSR2WithPanelTotal.Text = doubleIncludingSR1AndSR2WithPanelTotal.ToString();
            txtSingleSR3AndSR3WithPanelsTotal.Text = singleSR3AndSR3WithPanelsTotal.ToString();
            txtDoubleSR3AndSR3WithPanelsTotal.Text = doubleSR3AndSR3WithPanelsTotal.ToString();



            double total = 0, multiplyValue = 0;
            if (radioOver2Hours.Checked == true)
                multiplyValue = 1.85;
            else
                multiplyValue = 1.85;
            total = (singleIncludingSR1AndSR2Total + doubleIncludingSR1AndSR2Total + singleIncludingSR1andSR2WithPanelTotal + doubleIncludingSR1AndSR2WithPanelTotal + singleSR3AndSR3WithPanelsTotal + doubleSR3AndSR3WithPanelsTotal + panelsTotal) * multiplyValue;
            if (radioOver2Hours.Checked == true)
            {
                if (total < 750)
                    total = 750;
            }
            if (total < 500)
                total = 500;
            txtTotal.Text = total.ToString() ;

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtPanels.Text = "";
            txtSingleInludingSR1andSR2.Text = "";
            txtDoubleIncludingSR1AndSR2.Text = "";
            txtSingleIncludingSR1AndSR2WithPanel.Text = "";
            txtDoubleIncludingSR1AndSR2WithPanel.Text = "";
            txtSingleSR3AndSR3WithPanels.Text = "";
            txtDoubleSR3AndSR3WithPanels.Text = "";
            btnCalculate.PerformClick();
        }

        private void txtPanels_KeyPress(object sender, KeyPressEventArgs e) //stops people from entering anything other than digits
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSingleIncludingSR1AndSR2WithPanel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDoubleIncludingSR1AndSR2WithPanel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSingleSR3AndSR3WithPanels_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDoubleSR3AndSR3WithPanels_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSingleInludingSR1andSR2_KeyDown(object sender, KeyEventArgs e) //makes life a bit easier 
        {
            if (e.KeyCode == Keys.Enter)
                btnCalculate.PerformClick();
        }

        private void txtDoubleIncludingSR1AndSR2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnCalculate.PerformClick();
        }

        private void txtPanels_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnCalculate.PerformClick();
        }

        private void txtSingleIncludingSR1AndSR2WithPanel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnCalculate.PerformClick();
        }

        private void txtDoubleIncludingSR1AndSR2WithPanel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnCalculate.PerformClick();
        }

        private void txtSingleSR3AndSR3WithPanels_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnCalculate.PerformClick();
        }

        private void txtDoubleSR3AndSR3WithPanels_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnCalculate.PerformClick();
        }

        private void radioUpTo2hours_CheckedChanged(object sender, EventArgs e)
        {
            btnCalculate.PerformClick(); //prevents people from not realising they needed to click calculate after hitting this
        }
    }
}

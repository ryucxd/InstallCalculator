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
            //txtWarning.BackColor = System.Drawing.Color.Transparent;
            //this.Icon = Properties.Resources.
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //many many variables
            int singleIncludingSR1AndSR2 = 0, doubleIncludingSR1AndSR2 = 0, singleIncludingSR1andSR2WithPanel = 0, doubleIncludingSR1AndSR2WithPanel = 0, singleSR4 = 0, doubleSR4 = 0, travelCost = 0, panels = 0, singleSR3Flood = 0, doubleSR3Flood = 0;
            double singleIncludingSR1AndSR2Total = 0, doubleIncludingSR1AndSR2Total = 0, singleIncludingSR1andSR2WithPanelTotal = 0, doubleIncludingSR1AndSR2WithPanelTotal = 0, singleSR4Total = 0, doubleSR4Total = 0, panelsTotal = 0, singleSR3FloodTotal = 0, doubleSR3FloodTotal = 0;

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

            if (String.IsNullOrEmpty(txtSingleSR4.Text))
                singleSR4 = 0;
            else
                singleSR4 = Convert.ToInt32(txtSingleSR4.Text);

            if (String.IsNullOrEmpty(txtDoubleSR4.Text))
                doubleSR4 = 0;
            else
                doubleSR4 = Convert.ToInt32(txtDoubleSR4.Text);

            if (String.IsNullOrEmpty(txtDoubleSR4.Text))
                doubleSR4 = 0;
            else
                doubleSR4 = Convert.ToInt32(txtDoubleSR4.Text);

            if (String.IsNullOrEmpty(txtSingleSR3Flood.Text))
                singleSR3Flood = 0;
            else
                singleSR3Flood = Convert.ToInt32(txtSingleSR3Flood.Text);

            if (String.IsNullOrEmpty(txtDoubleSR3Flood.Text))
                doubleSR3Flood = 0;
            else
                doubleSR3Flood = Convert.ToInt32(txtDoubleSR3Flood.Text);

            if (String.IsNullOrEmpty(txtPanels.Text))
                panels = 0;
            else
                panels = Convert.ToInt32(txtPanels.Text);

            if (radioOver2Hours.Checked == true)
                travelCost = 575;
            else
                travelCost = 425;

            // double singleIncludingSR1AndSR2Total = 0, doubleIncludingSR1AndSR2Total = 0, singleIncludingSR1andSR2WithPanelTotal = 0, doubleIncludingSR1AndSR2WithPanelTotal = 0, singleSR3AndSR3WithPanelsTotal = 0, doubleSR3AndSR3WithPanelsTotal = 0;
            singleIncludingSR1AndSR2Total = ((travelCost / 3) * singleIncludingSR1AndSR2);
            //vv^^ panels copy the same as a normal single door
            panelsTotal = ((travelCost / 3) * panels); //except with panels ofc

            doubleIncludingSR1AndSR2Total = ((travelCost / 2) * doubleIncludingSR1AndSR2);
            singleIncludingSR1andSR2WithPanelTotal = ((travelCost / 3) * singleIncludingSR1andSR2WithPanel * 1.3);
            doubleIncludingSR1AndSR2WithPanelTotal = ((travelCost / 2 * doubleIncludingSR1AndSR2WithPanel) * 1.3);

            //vvv these are being revamped to be more static costs
            //singleSR3AndSR3WithPanelsTotal = ((travelCost / 3) * singleSR3AndSR3WithPanels * 1.5);
            //doubleSR3AndSR3WithPanelsTotal = ((travelCost / 2) * doubleSR3AndSR3WithPanels *2.25);
            //rework start

            double SR4_base_cost = 0;

            double SR4_single_price = 0;
            double SR4_double_price = 0;
            if (radioOver2Hours.Checked == true)
            {
                SR4_base_cost = 1700;
                SR4_single_price = 570;
                SR4_double_price = 850;
            }
            else
            {
                SR4_base_cost = 1300;
                SR4_single_price = 440;
                SR4_double_price = 750;
            }
            //single is rounded to 3
            if (singleSR4 > 0)
                SR4_single_price = singleSR4 * SR4_single_price;
            else
                SR4_single_price = 0;

            //double is rounded to 2
            if (doubleSR4 > 0)
                SR4_double_price = doubleSR4 * SR4_double_price;
            else
                SR4_double_price = 0;

            singleSR4Total = SR4_single_price + SR4_double_price;


            //if they are below the min amnount set them to this
            if (singleSR4Total != 0)
            {
                if (singleSR4Total < SR4_base_cost)
                    singleSR4Total = SR4_base_cost;
            }
               

            //SR4_single_quantity = Math.Ceiling(Math.Round((SR4_single_quantity + SR4_double_quantity) / 3, 2));
            //singleSR4Total = SR4_base_cost * SR4_single_quantity;
            // rework end


            //SR3 / Flood  > works the same as the above sr4 rework code

            double SR3_base_cost = 0;
            if (radioOver2Hours.Checked == true)
                SR3_base_cost = 1320;
            else
                SR3_base_cost = 790;

            double SR3_single_quantity = 0;
            double SR3_double_quantity = 0;

            //single is rounded to 3
            if (singleSR3Flood > 0)
            {
                double single_multiply = 0;
                SR3_single_quantity = singleSR3Flood;
            }
            //double is rounded to 2
            if (doubleSR3Flood > 0)
            {
                SR3_double_quantity = doubleSR3Flood * 2;//Math.Ceiling(Math.Round(Convert.ToDouble(doubleSR3Flood) / 2, 2));
                //doubleSR3FloodTotal = SR3_base_cost * double_multiply;
            }

            SR3_single_quantity =  Math.Ceiling(Math.Round((SR3_single_quantity + SR3_double_quantity) / 3, 2));
          singleSR3FloodTotal = SR3_base_cost * SR3_single_quantity;
            /////////////////////////////////////////////////////



            txtSingleIncludingSR1andSr2Total.Text = singleIncludingSR1AndSR2Total.ToString();
            //vv^^ this is same again
            txtPanelTotal.Text = panelsTotal.ToString(); //again with panels ofc

            txtDoubleIncludingSR1andSr2Total.Text = doubleIncludingSR1AndSR2Total.ToString();
            txtSingleIncludingSR1AndSR2WithPanelTotal.Text = singleIncludingSR1andSR2WithPanelTotal.ToString();
            txtDoubleIncludingSR1AndSR2WithPanelTotal.Text = doubleIncludingSR1AndSR2WithPanelTotal.ToString();
            txtSingleSR4Total.Text = singleSR4Total.ToString();
            //txtDoubleSR4Total.Text = doubleSR4Total.ToString();
            txtSingleDoubleSR3FloodTotal.Text = singleSR3FloodTotal.ToString();
           // txtDoubleSR3FloodTotal.Text = doubleSR3FloodTotal.ToString();



            double total = 0, multiplyValue = 0;
            if (radioOver2Hours.Checked == true)
                multiplyValue = 1.45;
            else
                multiplyValue = 1.45;
            total = (singleIncludingSR1AndSR2Total + doubleIncludingSR1AndSR2Total + singleIncludingSR1andSR2WithPanelTotal + doubleIncludingSR1AndSR2WithPanelTotal  + panelsTotal) * multiplyValue + singleSR4Total + /*doubleSR4Total +*/ singleSR3FloodTotal /*+ doubleSR3FloodTotal*/;
            if (radioOver2Hours.Checked == true)
            {
                if (total < 825)
                    total = 825;
            }
            if (total < 525)
                total = 525;
            txtTotal.Text = total.ToString();

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
            txtSingleSR4.Text = "";
            txtDoubleSR4.Text = "";
            txtSingleSR3Flood.Text = "";
            txtDoubleSR3Flood.Text = "";

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

        private void txtSingleSR3Flood_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnCalculate.PerformClick();
        }

        private void txtSingleSR3Flood_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDoubleSR3Flood_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDoubleSR3Flood_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnCalculate.PerformClick();
        }
    }
}

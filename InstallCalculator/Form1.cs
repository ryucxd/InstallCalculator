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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

            //total cost of doors 
            int singleQuantity = 0, singleTotal = 0,doubleQuantity = 0, doubleTotal = 0,counter = 0;
            if (String.IsNullOrEmpty(txtSingle.Text))
                txtSingle.Text = "0";
            if (String.IsNullOrEmpty(txtDouble.Text))
                txtDouble.Text = "0";

            counter = Convert.ToInt32(txtSingle.Text);
            singleQuantity = Convert.ToInt32(txtSingle.Text);
            for (int i = 0; i < counter; i++)
            {
                if (i == 0)
                    singleTotal = 250;
                else
                    singleTotal = singleTotal + 110;
            }
            txtSingleTotal.Text = singleTotal.ToString();
            counter = Convert.ToInt32(txtDouble.Text);
            doubleQuantity = Convert.ToInt32(txtDouble.Text);
            for (int i = 0; i < counter; i++)
            {
                if (i == 0)
                    doubleTotal = 200;
                else
                    doubleTotal = doubleTotal + 130;
            }
            txtDoubleTotal.Text = doubleTotal.ToString();



            //lucas days
            double singleInstallTime = 0.33, doubleInstallTime = 0.5;
            int installDays = 0;
            installDays = Convert.ToInt32(((singleInstallTime * singleQuantity) + (doubleInstallTime * doubleQuantity)) + 0.4);
            txtInstallDays.Text = installDays.ToString();






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
    }
}

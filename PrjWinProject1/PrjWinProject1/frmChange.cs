using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjWinProject1
{
    public partial class frmChange : Form
    {
        public frmChange()
        {
            InitializeComponent();
        }

        struct Rate
        {
            public string Country;
            public string Currency;
            public string Conversion;
        }

        static Rate[] tabRates = new Rate[25];
        static Int16 nbRate;
        static string conv_rate;

        private void ReadFileToArray()
        {
            
        }
        private void frmChange_Load(object sender, EventArgs e)
        {
            StreamReader myfile = new StreamReader("Rates.txt");
            Int16 i = 0;
            while (myfile.EndOfStream == false)
            {
                tabRates[i].Country = myfile.ReadLine();
                tabRates[i].Currency = myfile.ReadLine();
                tabRates[i].Conversion = myfile.ReadLine();

                // at the same, fill the cboQuestions with theQuestion
                cboCountry.Items.Add(tabRates[i].Country);
                i++;
            }
            myfile.Close();
            nbRate = i;
        }

        private void radUsToFra_CheckedChanged(object sender, EventArgs e)
        {
            lblCurrency.Text = "USD";
            
        }

        private void radFraToUs_CheckedChanged(object sender, EventArgs e)
        {
            Int32 indx = cboCountry.SelectedIndex;
            lblCurrency.Text = tabRates[indx].Currency;
        }

        private void cboCountry_SelectedIndexChanged(object sender, EventArgs e)
        {

            
            Int32 indx = cboCountry.SelectedIndex;
            String tmp = tabRates[indx].Conversion;
            //MessageBox.Show(tmp);
            Single tmp1 = Convert.ToSingle(tmp);
            //MessageBox.Show(tmp1.ToString());
            lblUsToFra.Text = "1 USD = " + (1/tmp1) + " " + tabRates[indx].Currency;
            lblFraToUs.Text = "1" + tabRates[indx].Currency + "= " + tabRates[indx].Conversion + " USD";
            radUsToFra.Text = "USD to " + tabRates[indx].Currency;
            radFraToUs.Text = tabRates[indx].Currency + " to USD";
            conv_rate = tabRates[indx].Conversion;
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            Int32 indx = cboCountry.SelectedIndex;
            Double amount = Double.Parse(txtInput.Text);
            Single tmp = Convert.ToSingle(tabRates[indx].Conversion);
            switch (cboCountry.SelectedIndex)
            {
                case 0:
                    if (radFraToUs.Checked == true)
                    {
                        amount = amount * tmp;
                        lblResult.Text = amount.ToString("N3") + " USD";
                    }
                    else if (radUsToFra.Checked == true)
                    {
                        amount = amount * (1/tmp);
                        lblResult.Text = amount.ToString("N3") + " " + tabRates[indx].Currency;
                    }
                    break;
                case 1:
                    if (radFraToUs.Checked == true)
                    {
                        amount = amount * tmp;
                        lblResult.Text = amount.ToString("N3") + " USD";
                    }
                    else if (radUsToFra.Checked == true)
                    {
                        amount = amount * (1 / tmp);
                        lblResult.Text = amount.ToString("N3") + " " + tabRates[indx].Currency;
                    }
                    break;
                case 2:
                    if (radFraToUs.Checked == true)
                    {
                        amount = amount * tmp;
                        lblResult.Text = amount.ToString("N3") + " USD";
                    }
                    else if (radUsToFra.Checked == true)
                    {
                        amount = amount * (1 / tmp);
                        lblResult.Text = amount.ToString("N3") + " " + tabRates[indx].Currency;
                    }
                    break;
                case 3:
                    if (radFraToUs.Checked == true)
                    {
                        amount = amount * tmp;
                        lblResult.Text = amount.ToString("N3") + " USD";
                    }
                    else if (radUsToFra.Checked == true)
                    {
                        amount = amount * (1 / tmp);
                        lblResult.Text = amount.ToString("N3") + " " + tabRates[indx].Currency;
                    }
                    break;
                case 4:
                    if (radFraToUs.Checked == true)
                    {
                        amount = amount * tmp;
                        lblResult.Text = amount.ToString("N3") + " USD";
                    }
                    else if (radUsToFra.Checked == true)
                    {
                        amount = amount * (1 / tmp);
                        lblResult.Text = amount.ToString("N3") + " " + tabRates[indx].Currency;
                    }
                    break;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            lblFraToUs.Text = "";
            lblCurrency.Text = "";
            lblResult.Text = "";
            lblUsToFra.Text = "";
            txtInput.Text = "";
            
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void txtInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }
    }
}

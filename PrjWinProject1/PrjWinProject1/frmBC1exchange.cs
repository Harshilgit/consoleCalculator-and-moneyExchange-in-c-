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
    public partial class frmBC1exchange : Form
    {
        public frmBC1exchange()
        {
            InitializeComponent();
        }

        struct Rate
        {
            public string Country;
            public string Currency;
            public string Conversion;
        }

        static Rate[] tabRates = new Rate[100];
        static Int16 nbRate;
        static string conv_rate;

        private void frmBC1exchange_Load(object sender, EventArgs e)
        {
            lblWelcome.Text= "Welcome to the programme" + "\n" + DateTime.Today.ToShortDateString() + " " + DateTime.Now.ToLongTimeString();

            StreamReader myfile = new StreamReader("Allrates.txt");
            Int16 i = 0;
            while (myfile.EndOfStream == false)
            {
                tabRates[i].Country = myfile.ReadLine();
                tabRates[i].Currency = myfile.ReadLine();
                tabRates[i].Conversion = myfile.ReadLine();

                // at the same, fill the cboQuestions with theQuestion
                cboCountry1.Items.Add(tabRates[i].Country);
                cboCountry2.Items.Add(tabRates[i].Country);
                i++;
            }
            myfile.Close();
            nbRate = i;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnSwitch_Click(object sender, EventArgs e)
        {
            string tmpName1;

            tmpName1 = cboCountry1.Text;
            cboCountry1.Text = cboCountry2.Text;
            cboCountry2.Text = tmpName1;
            
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
           /* Int32 indx1 = cboCountry1.SelectedIndex;
            Int32 indx2 = cboCountry2.SelectedIndex;
            Double amount = Double.Parse(txtAmount.Text);
            Double converted = Double.Parse(txtConverted.Text);
            Single tmp1 = Convert.ToSingle(tabRates[indx1].Conversion);
            Single tmp2 = Convert.ToSingle(tabRates[indx2].Conversion);
            Single base1 = Convert.ToSingle(amount * tmp1); //usd

            MessageBox.Show(base1.ToString()); */
           
            
            
            
        }
    }
}

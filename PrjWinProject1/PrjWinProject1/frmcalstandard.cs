using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjWinProject1
{
    
    public partial class frmcalstandard : Form
    {
        Double result = 0;
        Decimal memory = 0;
        String operation = "";
        bool enter_value = false;
        public frmcalstandard()
        {
            InitializeComponent();
        }

        private void frmcalstandard_Load(object sender, EventArgs e)
        {
            btn_MC.Enabled = false;
            btn_MR.Enabled = false;
            btn_M.Enabled = false;
        }

        private void numbers(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if ((txtDisplay.Text == "0") || (enter_value))
                txtDisplay.Text = "";
            enter_value = false;

            if(b.Text == ".")
            {
                if (!txtDisplay.Text.Contains("."))
                    txtDisplay.Text = txtDisplay.Text + b.Text;
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + b.Text;

            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if(result != 0)
            {
                btn_ans.PerformClick();
                enter_value = true;
                operation = btn_add.Text;
                lblShowOperation.Text = Convert.ToString(result) + " " + operation;
            }
            else
            {
                operation = btn_add.Text;
                result = Double.Parse(txtDisplay.Text);
                txtDisplay.Text = "";
                lblShowOperation.Text = Convert.ToString(result) + " " + operation;
            }
            
        }

        private void btn_CE_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
        }

        private void btn_C_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            result = 0;
            lblShowOperation.Text = "";
        }

        private void btn_ans_Click(object sender, EventArgs e)
        {
            lblShowOperation.Text = ""; 
            switch (operation)
            {
                case "+":
                    txtDisplay.Text = (result + Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "-":
                    txtDisplay.Text = (result - Double.Parse(txtDisplay.Text)).ToString();
                    break ;
                case "x":
                    txtDisplay.Text = (result * Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "÷":
                    txtDisplay.Text = (result / Double.Parse(txtDisplay.Text)).ToString();
                    break;
            }
            
            result = Double.Parse(txtDisplay.Text);
            operation = "";
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 0)
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1,1);
            }
            if(txtDisplay.Text == "")
            {
                txtDisplay.Text = "0";
            }
        }

        private void btn_sub_Click(object sender, EventArgs e)
        {
            if (result != 0)
            {
                btn_ans.PerformClick();
                enter_value = true;
                operation = btn_sub.Text;
                lblShowOperation.Text = Convert.ToString(result) + " " + operation;
            }
            else
            {
                operation = btn_sub.Text;
                result = Double.Parse(txtDisplay.Text);
                txtDisplay.Text = "";
                lblShowOperation.Text = Convert.ToString(result) + " " + operation;
            }
        }

        private void btn_multi_Click(object sender, EventArgs e)
        {
            if (result != 0)
            {
                btn_ans.PerformClick();
                enter_value = true;
                operation = btn_multi.Text;
                lblShowOperation.Text = Convert.ToString(result) + " " + operation;
            }
            else
            {
                operation = btn_multi.Text;
                result = Double.Parse(txtDisplay.Text);
                txtDisplay.Text = "";
                lblShowOperation.Text = Convert.ToString(result) + " " + operation;
            }
        }

        private void btn_division_Click(object sender, EventArgs e)
        {
            if (result != 0)
            {
                btn_ans.PerformClick();
                enter_value = true;
                operation = btn_division.Text;
                lblShowOperation.Text = Convert.ToString(result) + " " + operation;
            }
            else
            {
                operation = btn_division.Text;
                result = Double.Parse(txtDisplay.Text);
                txtDisplay.Text = "";
                lblShowOperation.Text = Convert.ToString(result) + " " + operation;
            }
        }

        private void btn_MS_Click(object sender, EventArgs e)
        {
            btn_MC.Enabled = true;
            btn_MR.Enabled = true;
            btn_M.Enabled = true;

            memory = Decimal.Parse(txtDisplay.Text);
            lblShowOperation.Text = "";
            enter_value = true;
        }

        private void btnM_minus_Click(object sender, EventArgs e)
        {
            memory -= Convert.ToDecimal(result);
            result = Double.Parse(txtDisplay.Text);
            enter_value = true;
        }

        private void btnM_plus_Click(object sender, EventArgs e)
        {
            memory += Convert.ToDecimal(result);
            result = Double.Parse(txtDisplay.Text);
            enter_value = true;
        }

        private void btn_MC_Click(object sender, EventArgs e)
        {
            memory = 0;

            btn_MC.Enabled = false;
            btn_MR.Enabled = false;
            btn_M.Enabled = false;
        }

        private void btn_MR_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = memory.ToString();
        }

        private void btn_sign_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.StartsWith("-"))
            {
                //It's negative now, so strip the `-` sign to make it positive
                txtDisplay.Text = txtDisplay.Text.Substring(1);
            }
            else if (!string.IsNullOrEmpty(txtDisplay.Text) && decimal.Parse(txtDisplay.Text) != 0)
            {
                //It's positive now, so prefix the value with the `-` sign to make it negative
                txtDisplay.Text = "-" + txtDisplay.Text;
            }
        }

        private void btn_percentage_Click(object sender, EventArgs e)
        {
            if(operation == btn_add.Text)
            {
                txtDisplay.Text = (result *((Double.Parse(txtDisplay.Text)) / 100)).ToString();
                enter_value = true;
            }
            else if(operation == btn_sub.Text)
            {
                txtDisplay.Text = (result * ((Double.Parse(txtDisplay.Text)) / 100)).ToString();
                enter_value = true;
            }
            else if(operation == btn_multi.Text)
            {
                txtDisplay.Text = ((Double.Parse(txtDisplay.Text)) / 100).ToString();
                enter_value = true;
            }
            else if(operation == btn_division.Text)
            {
                txtDisplay.Text = ((Double.Parse(txtDisplay.Text)) / 100).ToString();
                enter_value = true;
            }

            
        }

        private void btn_root_Click(object sender, EventArgs e)
        {
            result = Double.Parse(txtDisplay.Text);
            txtDisplay.Text = Math.Sqrt(result).ToString();
            lblShowOperation.Text = "√" + Convert.ToString(result);
            enter_value = true;
        }

        private void btn_square_Click(object sender, EventArgs e)
        {
            result = Double.Parse(txtDisplay.Text);
            txtDisplay.Text = Math.Pow(result,2).ToString();
            lblShowOperation.Text = "Sqr(" + Convert.ToString(result) + ")";
            enter_value = true;
        }

        private void btn_inverse_Click(object sender, EventArgs e)
        {
            result = Double.Parse(txtDisplay.Text);
            txtDisplay.Text = (1 / result).ToString();
            lblShowOperation.Text = "1/" + Convert.ToString(result);
            enter_value = true;
        }

        private void btn_M_Click(object sender, EventArgs e)
        {

        }
    }
}

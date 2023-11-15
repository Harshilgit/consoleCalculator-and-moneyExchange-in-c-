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
    public partial class frmCalScientific : Form
    {
        Double result = 0;
        Decimal memory = 0;
        String operation = "";
        bool enter_value = false;
        Double answer, n1, n2;
        public frmCalScientific()
        {
            InitializeComponent();
        }

        private void btn_MS_Click(object sender, EventArgs e)
        {

        }

        private void numbers(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if ((txtDisplay.Text == "0") || (enter_value))
                txtDisplay.Text = "";
            enter_value = false;

            if (b.Text == ".")
            {
                if (!txtDisplay.Text.Contains("."))
                    txtDisplay.Text = txtDisplay.Text + b.Text;
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + b.Text;

            }
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
                    break;
                case "x":
                    txtDisplay.Text = (result * Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "÷":
                    txtDisplay.Text = (result / Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "mod":
                    txtDisplay.Text = (result % Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "x^y":
                    n2 = Double.Parse(txtDisplay.Text);
                    answer = Math.Pow(n1, n2);
                    txtDisplay.Text = answer.ToString();
                    break;
            }

            result = Double.Parse(txtDisplay.Text);
            operation = "";
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (result != 0)
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
            txtDisplay.Text = Math.Pow(result, 2).ToString();
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

        private void btn_C_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            result = 0;
            lblShowOperation.Text = "";
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 0)
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1, 1);
            }
            if (txtDisplay.Text == "")
            {
                txtDisplay.Text = "0";
            }
        }

        private void btn_MS_Click_1(object sender, EventArgs e)
        {
            btn_MC.Enabled = true;
            btn_MR.Enabled = true;
            btn_M.Enabled = true;

            memory = Decimal.Parse(txtDisplay.Text);
            lblShowOperation.Text = "";
            enter_value = true;
        }

        private void btnM_plus_Click(object sender, EventArgs e)
        {
            memory += Convert.ToDecimal(result);
            result = Double.Parse(txtDisplay.Text);
            enter_value = true;
        }

        private void btnM_minus_Click(object sender, EventArgs e)
        {
            memory -= Convert.ToDecimal(result);
            result = Double.Parse(txtDisplay.Text);
            enter_value = true;
        }

        private void btn_MR_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = memory.ToString();
        }

        private void btn_MC_Click(object sender, EventArgs e)
        {
            memory = 0;

            btn_MC.Enabled = false;
            btn_MR.Enabled = false;
            btn_M.Enabled = false;
        }

        private void frmCalScientific_Load(object sender, EventArgs e)
        {
            btn_MC.Enabled = false;
            btn_MR.Enabled = false;
            btn_M.Enabled = false;
        }

        private void btn_ln_Click(object sender, EventArgs e)
        {
            result = Double.Parse(txtDisplay.Text);
            txtDisplay.Text = Math.Log(result).ToString();
            lblShowOperation.Text = "ln(" + Convert.ToString(result) + ")";
            enter_value = true;
        }

        private void btn_log_Click(object sender, EventArgs e)
        {
            result = Double.Parse(txtDisplay.Text);
            txtDisplay.Text = Math.Log10(result).ToString();
            lblShowOperation.Text = "log(" + Convert.ToString(result) + ")";
            enter_value = true;
        }

        private void btn_10power_Click(object sender, EventArgs e)
        {
            result = Double.Parse(txtDisplay.Text);
            txtDisplay.Text = Math.Pow(10,result).ToString();
            lblShowOperation.Text = "10^(" + Convert.ToString(result) + ")";
            enter_value = true;
        }

        private void btn_XtoY_Click(object sender, EventArgs e)
        {

            n1 = Double.Parse(txtDisplay.Text);
            lblShowOperation.Text = Convert.ToString(n1) + "^";
            txtDisplay.Text = "";
            operation = btn_XtoY.Text;
            enter_value = true;
        }

        private void btn_pie_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = Math.PI.ToString();
            enter_value = true;
        }

        private void btn_e_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = Math.E.ToString();
            enter_value = true;
        }

        private void btn_modX_Click(object sender, EventArgs e)
        {
            result = Double.Parse(txtDisplay.Text);
            txtDisplay.Text = Math.Abs(result).ToString();
            lblShowOperation.Text = "abs(" + Convert.ToString(result) + ")";
            enter_value = true;
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

        private void btn_exp_Click(object sender, EventArgs e)
        {
            result = Double.Parse(txtDisplay.Text);
            txtDisplay.Text = Math.Exp(result).ToString();
            lblShowOperation.Text = "exp(" + Convert.ToString(result) + ")";
            enter_value = true;
        }

        private void btn_mod_Click(object sender, EventArgs e)
        {
            if (result != 0)
            {
                btn_ans.PerformClick();
                enter_value = true;
                operation = btn_mod.Text;
                lblShowOperation.Text = Convert.ToString(result) + " " + operation;
            }
            else
            {
                operation = btn_mod.Text;
                result = Double.Parse(txtDisplay.Text);
                txtDisplay.Text = "";
                lblShowOperation.Text = Convert.ToString(result) + " " + operation;
            }
        }

        private void btn_factorial_Click(object sender, EventArgs e)
        {
            Double fact = 1;
            result = Double.Parse(txtDisplay.Text);
            for (Int16 i = 1; i <= result; i++)
            {
                fact = Convert.ToDouble(fact* i);
            }
            txtDisplay.Text = fact.ToString();
            lblShowOperation.Text = "fact(" + Convert.ToString(result) + ")";
            enter_value = true;
        }

        private void btn_open_par_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "(";
        }

        private void btn_close_par_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = ")";
        }
    }
}

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
    public partial class frmUserMnl : Form
    {
        public frmUserMnl()
        {
            InitializeComponent();
        }

        

        private void txtMaindesc_TextChanged_1(object sender, EventArgs e)
        {

            //txtMaindesc.Text = main_desc;

        }

        private void txtStd_desc_TextChanged(object sender, EventArgs e)
        {
            //txtStd_desc.Text = std_desc;
        }

        private void frmUserMnl_Load(object sender, EventArgs e)
        {
            string main_desc;
            string nl = Environment.NewLine;
            main_desc = "This is the user guide for the main user form!" + nl +
                        "which contains 3 main options in menu bar" + nl +
                        "- Programme" + nl +
                        "   -calculator" + nl +
                        "   -beurau de change" + nl +
                        "   -Quit" + nl +
                        "- View" + nl +
                        "   -Toolbar" + nl +
                        "   -Status Bar" + nl +
                        "- Help" + nl +
                        "   -User Guide" + nl +
                        "   -About Us" + nl +
                        "Just below the menu bar you can see the toolbar which contains shortcut buttons for the calculator." + nl +
                        "And at the bottom of the application there is status bar.";
            txtMaindesc.Text = main_desc;

            string std_desc;
            //string nl = Environment.NewLine;

            std_desc = "This user guid will show you how to use standard calculator." + nl +
                        "You can use this standard calculator for basic arithmatic" + nl +
                        "operations like +,-,*,/,%, square-root, inverse etc." + nl + nl +
                        "user guide" + nl +
                        "button (0-9)" + nl +
                        "- when you press any of these button it will display the decimal number from 0 to 9" + nl + nl +
                        "button (.)" + nl +
                        "- This button is use to add decimal point between two numbers." + nl +
                        "ex = 5.9" + nl + nl +
                        "Button +,-,*,/,%" + nl +
                        "These are the button which is use to perform the basic arithmatic operations like to add, subtract, multiply or divide two numbers." + nl + nl +
                        "Button (+/-)" + nl +
                        "- The use of +/- button is to add the sign in front of the number" + nl +
                        "ex = (-2)" + nl + nl +
                        "Button (1/x)" + nl +
                        "This button will take the user number or answer and give the inverse of that number." + nl +
                        "-  user entered 10" + nl +
                        "-  ans >> 1/10 = 0.1" + nl + nl +
                        "Button (x^2)" + nl +
                        "This button is used to square the number." + nl +
                        "ex user entered 2" + nl +
                        "ans >> 2^2 = 4" + nl + nl +
                        "Button =" + nl +
                        "This button is use to display the result of the arithmatic operation." + nl + nl +
                        "Button CE" + nl +
                        "This button clears the most recent entry of the calculator, If you did mistake in calculation and you want to remove last digit just press CE." + nl + nl +
                        "Button C" + nl +
                        "This button is clear all the input to the calculator." + nl + nl +
                        "Button MS" + nl +
                        "This button is use to store the figure in memory of calculator." + nl + nl +
                        "Button M+" + nl +
                        "Press M+ button to add the presently displayed number to the value in memory." + nl + nl +
                        "Button M-" + nl +
                        "Press M- button to subtract the presently displayed number to the value in memory." + nl + nl +
                        "Button MR" + nl +
                        "This button is pressed when you want to recall the stored number." + nl + nl +
                        "Button MC" + nl +
                        "MC is used to clear the calculator's memory.";

            txtStd_desc.Text = std_desc;

            string sci_desc;
            //string nl = Environment.NewLine;

            sci_desc = "This user guid will show you how to use scientific calculator." + nl +
                        "You can use this scientific calculator for advanced arithmatic" + nl +
                        "operations like log, ln, |x|, n!, square-root, inverse etc." + nl + nl +
                        "user guide" + nl +
                        "button (0-9)" + nl +
                        "- when you press any of these button it will display the decimal number from 0 to 9" + nl + nl +
                        "button (.)" + nl +
                        "- This button is use to add decimal point between two numbers." + nl +
                        "ex = 5.9" + nl + nl +
                        "Button +,-,*,/,%" + nl +
                        "These are the button which is use to perform the basic arithmatic operations like to add, subtract, multiply or divide two numbers." + nl + nl +
                        "Button (+/-)" + nl +
                        "- The use of +/- button is to add the sign in front of the number" + nl +
                        "ex = (-2)" + nl + nl +
                        "Button (1/x)" + nl +
                        "This button will take the user number or answer and give the inverse of that number." + nl +
                        "-  user entered 10" + nl +
                        "-  ans >> 1/10 = 0.1" + nl + nl +
                        "Button (x^2)" + nl +
                        "This button is used to square the number." + nl +
                        "ex user entered 2" + nl +
                        "ans >> 2^2 = 4" + nl + nl +
                        "Button =" + nl +
                        "This button clears the most recent entry of the calculator, If you did mistake in calculation and you want to remove last digit just press CE." + nl + nl +
                        "Button C" + nl +
                        "This button is clear all the input to the calculator." + nl + nl +
                        "Button MS" + nl +
                        "This button is use to store the figure in memory of calculator." + nl + nl +
                        "Button M+" + nl +
                        "Press M+ button to add the presently displayed number to the value in memory." + nl + nl +
                        "Button M-" + nl +
                        "Press M- button to subtract the presently displayed number to the value in memory." + nl + nl +
                        "Button MR" + nl +
                        "This button is pressed when you want to recall the stored number." + nl + nl +
                        "Button MC" + nl +
                        "MC is used to clear the calculator's memory." + nl + nl +
                        "Button π" + nl +
                        "This button will display the constant pi number 3.14" + nl + nl +
                        "Button e" + nl +
                        "This buton is use to diaplay Euler's constant number 2.71" + nl + nl +
                        "Button 10^x" + nl +
                        "This button is use to calculate the power of 10 with user entered number." + nl +
                        "ex user entered 2 and then press this key" + nl +
                        "ans >> 10^2 = 100" + nl + nl +
                        "Button log" + nl +
                        "This button is used to calculate log with base of 10." + nl + nl +
                        "Button ln" + nl +
                        "This button is used to calculate natural log" + nl + nl +
                        "Button |x|" + nl +
                        "When user press this key it will display the absolute value of the number." + nl + nl +
                        "Button n!" + nl +
                        "This key is used to perform the factorial operation of that number." + nl +
                        "ex user entered 5" + nl +
                        "ans >> 5*4*3*2*1 = 120";

            txtSci_desc.Text = sci_desc;
        }

        private void txtSci_desc_TextChanged(object sender, EventArgs e)
        {
            //txtSci_desc.Text = sci_desc;
        }
    }
}

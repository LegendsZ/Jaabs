using ATMSimulationProject.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Login form fucntionality

namespace ATMSimulationProject
{
    public partial class LoginWithPINForm : Form
    {
        //ATM object
        private int count = 0;
        JAABS.ATMMachine.ATMMachine ATM;

        //Intilaize component
        public LoginWithPINForm(JAABS.ATMMachine.ATMMachine ATM)
        {
            InitializeComponent();
            this.ATM = ATM;
        }

        //Constructor
        public LoginWithPINForm()
        {
            InitializeComponent();
        }

        //Login button method
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //When logged in call main interface
            ATM.LogIn(txtboxPIN.Text);
            if (ATM.LoggedIn)
            {
                count = 0;
                MainInterface mainInterface = new MainInterface(ATM);
                mainInterface.Show();
                if (ATM.ActiveBank != ATM.Banks[0] && ATM.CardType == "Debit")
                {
                    mainInterface.ToggleSecondaryBankMode();
                }
                else if (ATM.CardType == "Credit")
                {
                    mainInterface.ToggleCreditCardMode();
                }
                else
                {
                    mainInterface.ToggleMainBank();
                }
                Hide();
            }
            else
            {
                if (count < 3)
                {
                    count++;
                }
                MessageBox.Show(
                    "You have used " + (count) + "/3 tries!",
                    "INVALID PIN",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
            }
        }

        private void lblAccountNumber_Click(object sender, EventArgs e)
        {

        }

        private void txtboxAccountNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPIN_Click(object sender, EventArgs e)
        {

        }

        private void grpboxLogin_Enter(object sender, EventArgs e)
        {

        }

        private void LoginWithPINForm_Load(object sender, EventArgs e)
        {

        }
    }
}

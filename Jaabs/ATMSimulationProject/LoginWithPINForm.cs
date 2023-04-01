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

namespace ATMSimulationProject
{
    public partial class LoginWithPINForm : Form
    {
        private int count = 0;
        JAABS.ATMMachine.ATMMachine ATM;
        public LoginWithPINForm()
        {
            InitializeComponent();
            ATM = new JAABS.ATMMachine.ATMMachine("TMBank", "30321758753", new JAABS.Bank.Bank("TMBank", "CustomerData.txt", "HashData.txt"));
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            ATM.CheckCard();
            if (ATM.CardIn)
            {
                ATM.LogIn(txtboxPIN.Text);
                if (ATM.LoggedIn)
                {
                    MainInterface mainInterface = new MainInterface(ATM);
                    mainInterface.Show();
                    Hide();
                }
            }



            /*string accountNumber = ""; //txtboxAccountNumber.Text;
            string pin = txtboxPIN.Text;

            Account account = new Account(
                            Convert.ToInt32(accountNumber.Trim()),
                            Convert.ToInt32(pin.Trim()),
                            Convert.ToDecimal(2000),
                            "User"
                            );*/

            
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

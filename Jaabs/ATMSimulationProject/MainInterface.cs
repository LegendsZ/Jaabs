using ATMSimulationProject.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Main interface functionality

namespace ATMSimulationProject
{
    public partial class MainInterface : Form
    {
        //Main interface and ATM objects
        public static MainInterface mainInterface;
        private JAABS.ATMMachine.ATMMachine ATM;

        //Intialize main interface
        public MainInterface(JAABS.ATMMachine.ATMMachine ATM)
        {
            InitializeComponent();
            this.ATM = ATM;
            //lblBalance.Text = Convert.ToString("");
            mainInterface = this;
        }
        public void ToggleSecondaryBankMode()
        {
            btnDeposit.Hide();
            btnTransfer.Hide();
        }
        public void ToggleMainBank()
        {
            btnDeposit.Show();
            btnTransfer.Show();
            CheckBalance.Show();
            btnWithdraw.Show();
        }

        public void ToggleCreditCardMode()
        {
            btnDeposit.Hide();
            btnTransfer.Hide();
            CheckBalance.Hide();
        }
        //Withdraw button method
        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            //Call the withdraw form
            WithdrawForm withdrawForm = new WithdrawForm(ATM);
            if (ATM.CardType == "Credit")
            {
                withdrawForm.CreditCardMode();
            }
            else if (ATM.CardType == "Debit")
            {
                withdrawForm.DebitCardMode();
            }
            withdrawForm.Show();
            this.Hide();
        }

        //Deposit button method
        private void btnDeposit_Click(object sender, EventArgs e)
        {
            //Call the deposit form
            new DepositForm(ATM).Show();
            this.Hide();
        }

        //Transfer button method
        private void btnTransfer_Click(object sender, EventArgs e)
        {
            //Call transfer form
            new TransferForm(ATM).Show();
            this.Hide();
        }

        //Logout button method
        private void btnLogout_Click(object sender, EventArgs e)
        {
            //Logout, return card, and display end screen
            ATM.LogOut();
            ATM.EjectCard();
            (new EndScreen()).Show();
            this.Hide();
        }

        //Check balance method
        private void CheckBalance_Click(object sender, EventArgs e)
        {
            //Call check balance form
            new CheckBalance(ATM).Show();
            this.Hide();
        }
    }
}

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

namespace ATMSimulationProject
{
    public partial class TransferForm : Form
    {
        private JAABS.ATMMachine.ATMMachine ATM;
        public TransferForm(JAABS.ATMMachine.ATMMachine ATM)
        {
            InitializeComponent();
            this.ATM = ATM;
            //lblBalance.Text = Convert.ToString("");
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            ATM.LogOut();
            this.Close();
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            /*
            decimal amount = Convert.ToDecimal(txtboxTransfer.Text);

            if (amount > account.Balance)
            {
                MessageBox.Show("You have insufficient funds to complete this transaction");
            }
            else
            {
                account.Balance -= amount;
                if (MessageBox.Show("Would you like a receipt for this transaction?", "Receipts", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    // Do something here
                    // this will generate a pdf that will be printed
                }
                // navigate to main screen
                new MainInterface(account).Show();
                this.Close();
            }*/
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            MainInterface.mainInterface.Show();
            this.Hide();
        }

        private void grpboxTransfer_Enter(object sender, EventArgs e)
        {

        }
    }
}


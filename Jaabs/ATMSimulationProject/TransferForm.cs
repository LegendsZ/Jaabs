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
        private Account account;
        public TransferForm(Account account)
        {
            InitializeComponent();
            this.account = account;
            lblBalance.Text = Convert.ToString(this.account.Balance);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginWithPINForm loginForm = new LoginWithPINForm();
            loginForm.Show();
            this.Close();
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
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
            }
        }
    }
}


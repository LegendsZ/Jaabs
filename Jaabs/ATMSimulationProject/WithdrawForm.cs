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
    public partial class WithdrawForm : Form
    {
        private Account account;
        public WithdrawForm(Account account)
        {
            InitializeComponent();
            this.account = account;
            lblBalance.Text = Convert.ToString(this.account.Balance);
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {


            decimal amount = Convert.ToDecimal(txtBoxWithdraw.Text);

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

        private void btnLogout_Click(object sender, EventArgs e)
        {
            new LoginWithPINForm().Show();
            Close();
        }

        private void grpboxWithdraw_Enter(object sender, EventArgs e)
        {

        }
    }
}

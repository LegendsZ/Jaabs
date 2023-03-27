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
    public partial class DepositForm : Form
    {

        private Account account;
        public DepositForm(Account account)
        {
            InitializeComponent();
            this.account = account;
            lblBalance.Text = Convert.ToString(this.account.Balance);
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {

            decimal amount = Convert.ToDecimal(txtboxDeposit.Text);
            account.Balance += amount;

            if (MessageBox.Show("Would you like a receipt for this transaction?", "Receipts", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // Do something here
            }

            // navigate back to main screen            
            new MainInterface(account).Show();
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            new LoginWithPINForm().Show();
            this.Close();
        }

        private void DepositForm_Load(object sender, EventArgs e)
        {





        }
    }
}

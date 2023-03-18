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
    public partial class MainInterface : Form
    {
        private Account account;
        public MainInterface(Account account)
        {
            InitializeComponent();
            this.account = account;
            lblBalance.Text = Convert.ToString(account.Balance);
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {

            new WithdrawForm(account).Show();
            this.Close();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            new DepositForm(account).Show();
            this.Close();
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            new TransferForm(account).Show();
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            new LoginWithPINForm().Show();
            this.Close();
        }
    }
}

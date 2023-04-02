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
        public static MainInterface mainInterface;
        private JAABS.ATMMachine.ATMMachine ATM;
        public MainInterface(JAABS.ATMMachine.ATMMachine ATM)
        {
            InitializeComponent();
            this.ATM = ATM;
            //lblBalance.Text = Convert.ToString("");
            mainInterface = this;
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            new WithdrawForm(ATM).Show();
            this.Hide();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            new DepositForm(ATM).Show();
            this.Hide();
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            new TransferForm(ATM).Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            ATM.LogOut();
            WaitingScreen.waitingScreen.Show();
            WaitingScreen.waitingScreen.WaitingScreen_Shown(null,null);
            this.Hide();
        }
    }
}

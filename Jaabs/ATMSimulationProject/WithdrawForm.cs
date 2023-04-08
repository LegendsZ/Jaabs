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
        private JAABS.ATMMachine.ATMMachine ATM;
        public WithdrawForm(JAABS.ATMMachine.ATMMachine ATM)
        {
            InitializeComponent();
            this.ATM = ATM;
            //lblBalance.Text = Convert.ToString("");
        }
        public void CreditCardMode()
        {
            cmbAccount.Hide();
            label1.Hide();
        }
        public void DebitCardMode()
        {
            cmbAccount.Show();
            label1.Show();
        }
        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            if (cmbAccount.Text.Equals("Chequing") || cmbAccount.Text.Equals("Savings"))
            {
                ATM.Withdraw(Convert.ToInt32(txtBoxWithdraw.Text), cmbAccount.Text);
                (new EndScreen()).Show();
                this.Close();
            }
            else if (ATM.CardType == "Credit")
            {
                ATM.Withdraw(Convert.ToInt32(txtBoxWithdraw.Text), "");
                (new EndScreen()).Show();
                this.Close();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            ATM.LogOut();
            this.Close();
        }

        private void grpboxWithdraw_Enter(object sender, EventArgs e)
        {

        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            MainInterface.mainInterface.Show();
            this.Close();
        }

        private void WithdrawForm_Load(object sender, EventArgs e)
        {

        }

        private void cmbAccount_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

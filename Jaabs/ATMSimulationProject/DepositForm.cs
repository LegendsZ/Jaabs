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

        private JAABS.ATMMachine.ATMMachine ATM;
        public DepositForm(JAABS.ATMMachine.ATMMachine ATM)
        {
            InitializeComponent();
            this.ATM = ATM;
            //lblBalance.Text = Convert.ToString("");
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            if (radioBtnCash.Checked)
            {
                ATM.DepositCash(combobxRecipients.Text);
            }
            else
            {
                JAABS.Bank.Cheque cheque = ATM.readCheque("cheque.txt");
                ATM.DepositCheques(cheque, combobxRecipients.Text);
            }
            ATM.LogOut();
            ATM.EjectCard();
            (new EndScreen()).Show();
            this.Close();
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            MainInterface.mainInterface.Show();
            this.Close();
        }

        private void radioBtnCash_Click(object sender, EventArgs e)
        {
            if (radioBtnCash.Checked == true)
            {
                radioBtnCheque.Checked = false;
            }
            else
            {
                radioBtnCheque.Checked = true;
            }
        }

        private void radioBtnCheque_Click(object sender, EventArgs e)
        {
            if (radioBtnCheque.Checked == true)
            {
                radioBtnCash.Checked = false;
            }
            else
            {
                radioBtnCash.Checked = true;
            }
        }
    }
}

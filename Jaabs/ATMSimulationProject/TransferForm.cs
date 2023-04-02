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
        private List<JAABS.Customer.Payee> payees = new List<JAABS.Customer.Payee>();
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
            int x;
            if (!int.TryParse(txtboxTransfer.Text,out x))
            {
                return;
            }
            ATM.ActiveBank.payPayee(payees[combobxRecipients.SelectedIndex].cust, int.Parse(txtboxTransfer.Text));
            ATM.LogOut();
            WaitingScreen.waitingScreen.Show();
            WaitingScreen.waitingScreen.WaitingScreen_Shown(null, null);
            this.Close();
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            MainInterface.mainInterface.Show();
            this.Close();
        }

        private void grpboxTransfer_Enter(object sender, EventArgs e)
        {

        }

        private void TransferForm_Load(object sender, EventArgs e)
        {
            int maxSize = -1;
            foreach (JAABS.Customer.Customer cust in ATM.ActiveBank.Customers)
            {
                if (cust.CardNumber.Equals(JAABS.Encryptioner.DecryptKey(ATM.CardNumber)))
                {
                    maxSize = cust.payees.Count;
                    foreach (JAABS.Customer.Payee payee in cust.payees)
                    {
                        payees.Add(payee);
                        combobxRecipients.Items.Add(payee.toString());
                    }
                }
            }
        }
    }
}


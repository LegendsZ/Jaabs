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

//Transfer functionality

namespace ATMSimulationProject
{
    public partial class TransferForm : Form
    {
        //Create ATM object and list of possible payees
        private JAABS.ATMMachine.ATMMachine ATM;
        private List<JAABS.Customer.Payee> payees = new List<JAABS.Customer.Payee>();

        //Transfer method for component
        public TransferForm(JAABS.ATMMachine.ATMMachine ATM)
        {
            InitializeComponent();
            this.ATM = ATM;
            //lblBalance.Text = Convert.ToString("");
        }

        //Method for logout button
        private void btnLogout_Click(object sender, EventArgs e)
        {
            //Logout of ATM
            ATM.LogOut();
            this.Close();
        }

        //Transfer button method
        private void btnTransfer_Click(object sender, EventArgs e)
        {
            //Failed transfer
            int x;
            if (!int.TryParse(txtboxTransfer.Text,out x))
            {
                return;
            }
            //Transfer from selected account to payee
            ATM.ActiveBank.payPayee(payees[combobxRecipients.SelectedIndex].cust, int.Parse(txtboxTransfer.Text));
            ATM.LogOut();
            ATM.EjectCard();
            (new EndScreen()).Show();
            this.Close();
        }


        //Go back method
        private void btnGoBack_Click(object sender, EventArgs e)
        {
            //Close form
            MainInterface.mainInterface.Show();
            this.Close();
        }

        private void grpboxTransfer_Enter(object sender, EventArgs e)
        {

        }

        //Transfer method
        private void TransferForm_Load(object sender, EventArgs e)
        {
            //for all payees decrypt account information
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


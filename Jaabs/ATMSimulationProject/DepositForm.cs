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

//Deposit Functionality

namespace ATMSimulationProject
{
    public partial class DepositForm : Form
    {

        private JAABS.ATMMachine.ATMMachine ATM;

        //Call deposit form
        public DepositForm(JAABS.ATMMachine.ATMMachine ATM)
        {
            InitializeComponent();
            this.ATM = ATM;
            //lblBalance.Text = Convert.ToString("");
        }

        //Functionality for deposit button
        private void btnDeposit_Click(object sender, EventArgs e)
        {
            //Cash chosen so deposit cash
            if (radioBtnCash.Checked)
            {
                ATM.DepositCash(combobxRecipients.Text);
            }
            //Cheque chosen so read cheque and deposit cheque
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

        //Go back function button
        private void btnGoBack_Click(object sender, EventArgs e)
        {
            MainInterface.mainInterface.Show();
            this.Close();
        }

        //Cash is chosen
        private void radioBtnCash_Click(object sender, EventArgs e)
        {
            //Set cash as true and set cheque as false
            if (radioBtnCash.Checked == true)
            {
                radioBtnCheque.Checked = false;
            }
            else
            {
                radioBtnCheque.Checked = true;
            }
        }

        //Cheque is chosen
        private void radioBtnCheque_Click(object sender, EventArgs e)
        {
            //Set cheque as true and set cash as false
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

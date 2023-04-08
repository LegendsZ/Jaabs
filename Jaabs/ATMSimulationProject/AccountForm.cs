﻿using ATMSimulationProject.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Interface

namespace ATMSimulationProject
{
    public partial class AccountForm : Form
    {
        Account currentAccount;
        public AccountForm(Account account)
        {
            InitializeComponent();
            currentAccount = account;

            // load all accounts
            loadAllAccounts();

        }

        private void loadAllAccounts()
        {
            // read csv file to show accounts
        }

        //Withdraw functionallity
        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            decimal amount = Convert.ToDecimal(txtBoxWithdraw.Text);

            if (amount > currentAccount.Balance)
            {
                // display dialogue
                MessageBox.Show("You have insufficient funds!");
            }
            else
            {
                lblBalance.Text = currentAccount.Balance.ToString();
                currentAccount.Balance = currentAccount.Balance - amount;
                // Ask for receipt
                if (MessageBox.Show("Would you like a receipt for this transaction?", "Receipts", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    // Do something here
                }
            }



        }

        //Deposit functionality
        private void btnDeposit_Click(object sender, EventArgs e)
        {
            currentAccount.Balance += Convert.ToDecimal(txtboxDeposit.Text);

            lblBalance.Text = currentAccount.Balance.ToString();
            if (MessageBox.Show("Would you like a receipt for this transaction?", "Receipts", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                
            }
        }

        //Transfer functionality
        private void btnTransfer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Would you like a receipt for this transaction?", "Receipts", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                
            }

        }

        //Logout functionality
        private void btnLogout_Click(object sender, EventArgs e)
        {
            //return to precious state
            this.Close();
            LoginWithPINForm loginWithPINForm = new LoginWithPINForm();
            loginWithPINForm.Show();
        }
    }
}

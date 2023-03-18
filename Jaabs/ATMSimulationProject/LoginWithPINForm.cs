﻿using ATMSimulationProject.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMSimulationProject
{
    public partial class LoginWithPINForm : Form
    {
        private int count = 0;
        public LoginWithPINForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string accountNumber = txtboxAccountNumber.Text;
            string pin = txtboxPIN.Text;

            Account account = new Account(
                            Convert.ToInt32(accountNumber.Trim()),
                            Convert.ToInt32(pin.Trim()),
                            Convert.ToDecimal(2000),
                            "User"
                            );

            MainInterface mainInterface = new MainInterface(account);
            mainInterface.Show();
            Hide();
        }
    }
}

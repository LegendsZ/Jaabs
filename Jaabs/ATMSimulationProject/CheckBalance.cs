using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Check balance form

namespace ATMSimulationProject
{
    public partial class CheckBalance : Form
    {
        //ATM object
        JAABS.ATMMachine.ATMMachine ATM;

        //Check balance functionality
        public CheckBalance(JAABS.ATMMachine.ATMMachine ATM)
        {
            //Display checking and saving balances
            InitializeComponent();
            this.ATM = ATM;
            lblSavings.Text += "$" + ATM.CheckBalance("Savings");
            lblChequing.Text += "$" + ATM.CheckBalance("Chequing");
        }

        //Go back button
        private void btnGoBack_Click(object sender, EventArgs e)
        {
            //Go back to previous state
            MainInterface.mainInterface.Show();
            this.Close();
        }
    }
}

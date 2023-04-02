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
    public partial class WaitingScreen : Form
    {
        public static WaitingScreen waitingScreen;
        JAABS.ATMMachine.ATMMachine ATM;
        public WaitingScreen()
        {
            InitializeComponent();
            ATM = new JAABS.ATMMachine.ATMMachine("TMBank", "30321758753", new JAABS.Bank.Bank("TMBank", "CustomerData.txt", "HashData.txt"));
            waitingScreen = this;
        }

        public void WaitingScreen_Shown(object sender, EventArgs e)
        {
            while (true)
            {
                this.Refresh();
                ATM.CheckCard();
                if (ATM.CardIn)
                {
                    (new LoginWithPINForm(ATM)).Show();
                    this.Hide();
                    return;
                }
                Thread.Sleep(500);
            }
        }
    }
}

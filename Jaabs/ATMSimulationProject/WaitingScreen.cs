using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Waiting Screen

namespace ATMSimulationProject
{
    public partial class WaitingScreen : Form
    {
        //Create waiting screen and ATM objects
        public static WaitingScreen waitingScreen;
        JAABS.ATMMachine.ATMMachine ATM;

        //Waiting Screen method
        public WaitingScreen()
        {
            //Create wating screen
            //Initalize ATM with the relevent txt information
            InitializeComponent();
            ATM = new JAABS.ATMMachine.ATMMachine("TMBank", "30321758753", new JAABS.Bank.Bank("TMBank", "CustomerData.txt", "HashData.txt"));
            waitingScreen = this;
        }

        //Display waiting screen
        public void WaitingScreen_Shown(object sender, EventArgs e)
        {
            //Loop until ATM card is read
            while (true)
            {
                this.Refresh();
                ATM.CheckCard();

                //When card found login
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

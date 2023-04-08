using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//End Screen

namespace ATMSimulationProject
{
    public partial class EndScreen : Form
    {
        //Create End Screen object
        public EndScreen()
        {
            InitializeComponent();
        }

        //End screen method
        private void EndScreen_Shown(object sender, EventArgs e)
        {
            //Display end screen
            this.Refresh();
            System.Threading.Thread.Sleep(3000);
            this.Close();
            WaitingScreen.waitingScreen.Show();
            WaitingScreen.waitingScreen.WaitingScreen_Shown(null, null);
        }

    }
}

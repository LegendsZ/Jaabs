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
    public partial class EndScreen : Form
    {
        public EndScreen()
        {
            InitializeComponent();
        }

        private void EndScreen_Shown(object sender, EventArgs e)
        {
            this.Refresh();
            System.Threading.Thread.Sleep(3000);
            this.Close();
            WaitingScreen.waitingScreen.Show();
            WaitingScreen.waitingScreen.WaitingScreen_Shown(null, null);
        }
    }
}

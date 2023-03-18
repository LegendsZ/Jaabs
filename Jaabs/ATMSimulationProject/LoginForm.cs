using ATMSimulationProject.models;

namespace ATMSimulationProject
{
    public partial class LoginForm : Form

    {
        public int count = 0;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (count < 3)
            {
                string accountNumber = txtboxAccountNumber.Text;
                string pin = txtboxPIN.Text;

                bool found = false;

                // check if account number and pin exist in file
                using (StreamReader sr = new StreamReader("accounts.csv"))
                {
                    string currentLine;
                    // currentLine will be null when the StreamReader reaches the end of file
                    while ((currentLine = sr.ReadLine()) != null)
                    {
                        // Search, case insensitive, if the currentLine contains the searched keyword
                        string[] accountDetails = currentLine.Split(",");
                        // accountnumber, pin, balance, fullname
                        if (accountDetails[0].Trim() == accountNumber && accountDetails[1].Trim() == pin)
                        {
                            // User found
                            Account account = new Account(
                                Convert.ToInt32(accountDetails[0].Trim()),
                                Convert.ToInt32(accountDetails[1].Trim()),
                                Convert.ToDecimal(accountDetails[2].Trim()),
                                accountDetails[2].Trim()
                                );

                            found = true;
                        }
                    }
                }

                if (!found)
                {
                    MessageBox.Show("You have entered the wrong pin too mant times. " + (2 - count) + " tries left");
                }
                count++;
            }
            else
            {
                MessageBox.Show("You have entered the wrong pin too many times. Try again later!");
                this.Close();
            }
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            // generate random account number
            Random rand = new Random();
            int accountNumber = rand.Next(10000, 99999);

            string fullName = txtboxFullName.Text;
            int PIN = Convert.ToInt32(txtboxNewPIN.Text);

            Account account = new Account(accountNumber, PIN, 0, fullName);

            // append to csv file
            string newFileName = "accounts.csv";
            string clientDetails = accountNumber + "," + PIN + "," + 0 + "," + fullName;
            File.AppendAllText(newFileName, clientDetails);

            MessageBox.Show("Your Account number is " + accountNumber);

            AccountForm accountForm = new AccountForm(account);
            this.Visible = false;
            accountForm.Show();
        }
    }
}
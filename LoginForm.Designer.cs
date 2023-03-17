namespace ATMSimulationProject
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpboxLogin = new GroupBox();
            btnLogin = new Button();
            txtboxPIN = new TextBox();
            txtboxAccountNumber = new TextBox();
            lblPIN = new Label();
            lblAccountNumber = new Label();
            grpboxCreateAccount = new GroupBox();
            lblAccount = new Label();
            btnCreateAccount = new Button();
            txtboxNewPIN = new TextBox();
            txtboxFullName = new TextBox();
            lblCreatePin = new Label();
            lblFullName = new Label();
            grpboxLogin.SuspendLayout();
            grpboxCreateAccount.SuspendLayout();
            SuspendLayout();
            // 
            // grpboxLogin
            // 
            grpboxLogin.Controls.Add(btnLogin);
            grpboxLogin.Controls.Add(txtboxPIN);
            grpboxLogin.Controls.Add(txtboxAccountNumber);
            grpboxLogin.Controls.Add(lblPIN);
            grpboxLogin.Controls.Add(lblAccountNumber);
            grpboxLogin.Location = new Point(12, 12);
            grpboxLogin.Name = "grpboxLogin";
            grpboxLogin.Size = new Size(259, 261);
            grpboxLogin.TabIndex = 0;
            grpboxLogin.TabStop = false;
            grpboxLogin.Text = "Login";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(6, 136);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(235, 23);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtboxPIN
            // 
            txtboxPIN.Location = new Point(6, 92);
            txtboxPIN.Name = "txtboxPIN";
            txtboxPIN.Size = new Size(235, 23);
            txtboxPIN.TabIndex = 4;
            // 
            // txtboxAccountNumber
            // 
            txtboxAccountNumber.Location = new Point(6, 37);
            txtboxAccountNumber.Name = "txtboxAccountNumber";
            txtboxAccountNumber.Size = new Size(235, 23);
            txtboxAccountNumber.TabIndex = 3;
            // 
            // lblPIN
            // 
            lblPIN.AutoSize = true;
            lblPIN.Location = new Point(6, 74);
            lblPIN.Name = "lblPIN";
            lblPIN.Size = new Size(26, 15);
            lblPIN.TabIndex = 1;
            lblPIN.Text = "PIN";
            // 
            // lblAccountNumber
            // 
            lblAccountNumber.AutoSize = true;
            lblAccountNumber.Location = new Point(6, 19);
            lblAccountNumber.Name = "lblAccountNumber";
            lblAccountNumber.Size = new Size(99, 15);
            lblAccountNumber.TabIndex = 0;
            lblAccountNumber.Text = "Account Number";
            // 
            // grpboxCreateAccount
            // 
            grpboxCreateAccount.Controls.Add(lblAccount);
            grpboxCreateAccount.Controls.Add(btnCreateAccount);
            grpboxCreateAccount.Controls.Add(txtboxNewPIN);
            grpboxCreateAccount.Controls.Add(txtboxFullName);
            grpboxCreateAccount.Controls.Add(lblCreatePin);
            grpboxCreateAccount.Controls.Add(lblFullName);
            grpboxCreateAccount.Location = new Point(299, 12);
            grpboxCreateAccount.Name = "grpboxCreateAccount";
            grpboxCreateAccount.Size = new Size(264, 261);
            grpboxCreateAccount.TabIndex = 1;
            grpboxCreateAccount.TabStop = false;
            grpboxCreateAccount.Text = "Create Account";
            // 
            // lblAccount
            // 
            lblAccount.ForeColor = Color.Blue;
            lblAccount.Location = new Point(7, 173);
            lblAccount.Name = "lblAccount";
            lblAccount.Size = new Size(234, 64);
            lblAccount.TabIndex = 7;
            lblAccount.Text = "After creating your account, you will be provided with an account number. Kindly memorize it or save it somewhere as it will be used to log you in.";
            // 
            // btnCreateAccount
            // 
            btnCreateAccount.Location = new Point(6, 136);
            btnCreateAccount.Name = "btnCreateAccount";
            btnCreateAccount.Size = new Size(235, 23);
            btnCreateAccount.TabIndex = 6;
            btnCreateAccount.Text = "Create Account";
            btnCreateAccount.UseVisualStyleBackColor = true;
            btnCreateAccount.Click += btnCreateAccount_Click;
            // 
            // txtboxNewPIN
            // 
            txtboxNewPIN.Location = new Point(6, 92);
            txtboxNewPIN.Name = "txtboxNewPIN";
            txtboxNewPIN.Size = new Size(235, 23);
            txtboxNewPIN.TabIndex = 6;
            // 
            // txtboxFullName
            // 
            txtboxFullName.Location = new Point(6, 37);
            txtboxFullName.Name = "txtboxFullName";
            txtboxFullName.Size = new Size(235, 23);
            txtboxFullName.TabIndex = 5;
            // 
            // lblCreatePin
            // 
            lblCreatePin.AutoSize = true;
            lblCreatePin.Location = new Point(6, 74);
            lblCreatePin.Name = "lblCreatePin";
            lblCreatePin.Size = new Size(53, 15);
            lblCreatePin.TabIndex = 2;
            lblCreatePin.Text = "New PIN";
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Location = new Point(6, 19);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(61, 15);
            lblFullName.TabIndex = 0;
            lblFullName.Text = "Full Name";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(575, 285);
            Controls.Add(grpboxCreateAccount);
            Controls.Add(grpboxLogin);
            MaximizeBox = false;
            Name = "LoginForm";
            Text = "ATM SImulation";
            grpboxLogin.ResumeLayout(false);
            grpboxLogin.PerformLayout();
            grpboxCreateAccount.ResumeLayout(false);
            grpboxCreateAccount.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpboxLogin;
        private GroupBox grpboxCreateAccount;
        private Label lblPIN;
        private Label lblAccountNumber;
        private Label lblCreatePin;
        private Label lblFullName;
        private Button btnLogin;
        private TextBox txtboxPIN;
        private TextBox txtboxAccountNumber;
        private Button btnCreateAccount;
        private TextBox txtboxNewPIN;
        private TextBox txtboxFullName;
        private Label lblAccount;
    }
}
namespace ATMSimulationProject
{
    partial class CreateAccountForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpboxCreateAccount = new GroupBox();
            lblAccount = new Label();
            btnCreateAccount = new Button();
            txtboxNewPIN = new TextBox();
            txtboxFullName = new TextBox();
            lblCreatePin = new Label();
            lblFullName = new Label();
            grpboxAccountType = new GroupBox();
            radioBtnChecking = new RadioButton();
            radioBtnSavings = new RadioButton();
            grpboxCreateAccount.SuspendLayout();
            grpboxAccountType.SuspendLayout();
            SuspendLayout();
            // 
            // grpboxCreateAccount
            // 
            grpboxCreateAccount.Controls.Add(grpboxAccountType);
            grpboxCreateAccount.Controls.Add(lblAccount);
            grpboxCreateAccount.Controls.Add(btnCreateAccount);
            grpboxCreateAccount.Controls.Add(txtboxNewPIN);
            grpboxCreateAccount.Controls.Add(txtboxFullName);
            grpboxCreateAccount.Controls.Add(lblCreatePin);
            grpboxCreateAccount.Controls.Add(lblFullName);
            grpboxCreateAccount.Location = new Point(12, 12);
            grpboxCreateAccount.Name = "grpboxCreateAccount";
            grpboxCreateAccount.Size = new Size(264, 261);
            grpboxCreateAccount.TabIndex = 2;
            grpboxCreateAccount.TabStop = false;
            grpboxCreateAccount.Text = "Create Account";
            // 
            // lblAccount
            // 
            lblAccount.ForeColor = Color.Blue;
            lblAccount.Location = new Point(6, 194);
            lblAccount.Name = "lblAccount";
            lblAccount.Size = new Size(234, 64);
            lblAccount.TabIndex = 7;
            lblAccount.Text = "After creating your account, you will be provided with an account number. Kindly memorize it or save it somewhere as it will be used to log you in.";
            // 
            // btnCreateAccount
            // 
            btnCreateAccount.Location = new Point(5, 168);
            btnCreateAccount.Name = "btnCreateAccount";
            btnCreateAccount.Size = new Size(235, 23);
            btnCreateAccount.TabIndex = 6;
            btnCreateAccount.Text = "Create Account";
            btnCreateAccount.UseVisualStyleBackColor = true;
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
            // grpboxAccountType
            // 
            grpboxAccountType.Controls.Add(radioBtnSavings);
            grpboxAccountType.Controls.Add(radioBtnChecking);
            grpboxAccountType.Location = new Point(6, 121);
            grpboxAccountType.Name = "grpboxAccountType";
            grpboxAccountType.Size = new Size(234, 41);
            grpboxAccountType.TabIndex = 8;
            grpboxAccountType.TabStop = false;
            grpboxAccountType.Text = "Account Type";
            // 
            // radioBtnChecking
            // 
            radioBtnChecking.AutoSize = true;
            radioBtnChecking.Location = new Point(9, 16);
            radioBtnChecking.Name = "radioBtnChecking";
            radioBtnChecking.Size = new Size(75, 19);
            radioBtnChecking.TabIndex = 0;
            radioBtnChecking.TabStop = true;
            radioBtnChecking.Text = "Checking";
            radioBtnChecking.UseVisualStyleBackColor = true;
            // 
            // radioBtnSavings
            // 
            radioBtnSavings.AutoSize = true;
            radioBtnSavings.Location = new Point(144, 16);
            radioBtnSavings.Name = "radioBtnSavings";
            radioBtnSavings.Size = new Size(65, 19);
            radioBtnSavings.TabIndex = 1;
            radioBtnSavings.TabStop = true;
            radioBtnSavings.Text = "Savings";
            radioBtnSavings.UseVisualStyleBackColor = true;
            // 
            // CreateAccountForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(292, 295);
            Controls.Add(grpboxCreateAccount);
            MaximizeBox = false;
            Name = "CreateAccountForm";
            Text = "CreateAccountForm";
            grpboxCreateAccount.ResumeLayout(false);
            grpboxCreateAccount.PerformLayout();
            grpboxAccountType.ResumeLayout(false);
            grpboxAccountType.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpboxCreateAccount;
        private Label lblAccount;
        private Button btnCreateAccount;
        private TextBox txtboxNewPIN;
        private TextBox txtboxFullName;
        private Label lblCreatePin;
        private Label lblFullName;
        private GroupBox grpboxAccountType;
        private RadioButton radioBtnSavings;
        private RadioButton radioBtnChecking;
    }
}
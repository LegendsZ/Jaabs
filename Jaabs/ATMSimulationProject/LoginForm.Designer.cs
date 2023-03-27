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
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtboxPIN = new System.Windows.Forms.TextBox();
            this.txtboxAccountNumber = new System.Windows.Forms.TextBox();
            this.lblPIN = new System.Windows.Forms.Label();
            this.lblAccountNumber = new System.Windows.Forms.Label();
            this.grpboxCreateAccount = new System.Windows.Forms.GroupBox();
            this.grpboxAccountType = new System.Windows.Forms.GroupBox();
            this.radioBtnSavings = new System.Windows.Forms.RadioButton();
            this.radioBtnChecking = new System.Windows.Forms.RadioButton();
            this.lblAccount = new System.Windows.Forms.Label();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.txtboxNewPIN = new System.Windows.Forms.TextBox();
            this.txtboxFullName = new System.Windows.Forms.TextBox();
            this.lblCreatePin = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpboxCreateAccount.SuspendLayout();
            this.grpboxAccountType.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(12, 193);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(235, 23);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // txtboxPIN
            // 
            this.txtboxPIN.Location = new System.Drawing.Point(12, 148);
            this.txtboxPIN.Name = "txtboxPIN";
            this.txtboxPIN.Size = new System.Drawing.Size(235, 23);
            this.txtboxPIN.TabIndex = 4;
            this.txtboxPIN.TextChanged += new System.EventHandler(this.txtboxPIN_TextChanged);
            // 
            // txtboxAccountNumber
            // 
            this.txtboxAccountNumber.Location = new System.Drawing.Point(12, 78);
            this.txtboxAccountNumber.Name = "txtboxAccountNumber";
            this.txtboxAccountNumber.Size = new System.Drawing.Size(235, 23);
            this.txtboxAccountNumber.TabIndex = 3;
            // 
            // lblPIN
            // 
            this.lblPIN.AutoSize = true;
            this.lblPIN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(207)))), ((int)(((byte)(240)))));
            this.lblPIN.Location = new System.Drawing.Point(12, 112);
            this.lblPIN.Name = "lblPIN";
            this.lblPIN.Size = new System.Drawing.Size(26, 15);
            this.lblPIN.TabIndex = 1;
            this.lblPIN.Text = "PIN";
            // 
            // lblAccountNumber
            // 
            this.lblAccountNumber.AutoSize = true;
            this.lblAccountNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(207)))), ((int)(((byte)(240)))));
            this.lblAccountNumber.Location = new System.Drawing.Point(12, 49);
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.Size = new System.Drawing.Size(99, 15);
            this.lblAccountNumber.TabIndex = 0;
            this.lblAccountNumber.Text = "Account Number";
            // 
            // grpboxCreateAccount
            // 
            this.grpboxCreateAccount.Controls.Add(this.grpboxAccountType);
            this.grpboxCreateAccount.Controls.Add(this.lblAccount);
            this.grpboxCreateAccount.Controls.Add(this.btnCreateAccount);
            this.grpboxCreateAccount.Controls.Add(this.txtboxNewPIN);
            this.grpboxCreateAccount.Controls.Add(this.txtboxFullName);
            this.grpboxCreateAccount.Controls.Add(this.lblCreatePin);
            this.grpboxCreateAccount.Controls.Add(this.lblFullName);
            this.grpboxCreateAccount.Location = new System.Drawing.Point(299, 12);
            this.grpboxCreateAccount.Name = "grpboxCreateAccount";
            this.grpboxCreateAccount.Size = new System.Drawing.Size(264, 261);
            this.grpboxCreateAccount.TabIndex = 1;
            this.grpboxCreateAccount.TabStop = false;
            this.grpboxCreateAccount.Text = "Create Account";
            // 
            // grpboxAccountType
            // 
            this.grpboxAccountType.Controls.Add(this.radioBtnSavings);
            this.grpboxAccountType.Controls.Add(this.radioBtnChecking);
            this.grpboxAccountType.Location = new System.Drawing.Point(8, 121);
            this.grpboxAccountType.Name = "grpboxAccountType";
            this.grpboxAccountType.Size = new System.Drawing.Size(234, 41);
            this.grpboxAccountType.TabIndex = 9;
            this.grpboxAccountType.TabStop = false;
            this.grpboxAccountType.Text = "Account Type";
            // 
            // radioBtnSavings
            // 
            this.radioBtnSavings.AutoSize = true;
            this.radioBtnSavings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(207)))), ((int)(((byte)(240)))));
            this.radioBtnSavings.Location = new System.Drawing.Point(144, 16);
            this.radioBtnSavings.Name = "radioBtnSavings";
            this.radioBtnSavings.Size = new System.Drawing.Size(65, 19);
            this.radioBtnSavings.TabIndex = 1;
            this.radioBtnSavings.TabStop = true;
            this.radioBtnSavings.Text = "Savings";
            this.radioBtnSavings.UseVisualStyleBackColor = true;
            // 
            // radioBtnChecking
            // 
            this.radioBtnChecking.AutoSize = true;
            this.radioBtnChecking.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(207)))), ((int)(((byte)(240)))));
            this.radioBtnChecking.Location = new System.Drawing.Point(9, 16);
            this.radioBtnChecking.Name = "radioBtnChecking";
            this.radioBtnChecking.Size = new System.Drawing.Size(75, 19);
            this.radioBtnChecking.TabIndex = 0;
            this.radioBtnChecking.TabStop = true;
            this.radioBtnChecking.Text = "Checking";
            this.radioBtnChecking.UseVisualStyleBackColor = true;
            // 
            // lblAccount
            // 
            this.lblAccount.ForeColor = System.Drawing.Color.Yellow;
            this.lblAccount.Location = new System.Drawing.Point(7, 194);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(234, 64);
            this.lblAccount.TabIndex = 7;
            this.lblAccount.Text = "After creating your account, you will be provided with an account number. Kindly " +
    "memorize it or save it somewhere as it will be used to log you in.";
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.Location = new System.Drawing.Point(7, 168);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(235, 23);
            this.btnCreateAccount.TabIndex = 6;
            this.btnCreateAccount.Text = "Create Account";
            this.btnCreateAccount.UseVisualStyleBackColor = true;
            // 
            // txtboxNewPIN
            // 
            this.txtboxNewPIN.Location = new System.Drawing.Point(6, 92);
            this.txtboxNewPIN.Name = "txtboxNewPIN";
            this.txtboxNewPIN.Size = new System.Drawing.Size(235, 23);
            this.txtboxNewPIN.TabIndex = 6;
            // 
            // txtboxFullName
            // 
            this.txtboxFullName.Location = new System.Drawing.Point(6, 37);
            this.txtboxFullName.Name = "txtboxFullName";
            this.txtboxFullName.Size = new System.Drawing.Size(235, 23);
            this.txtboxFullName.TabIndex = 5;
            // 
            // lblCreatePin
            // 
            this.lblCreatePin.AutoSize = true;
            this.lblCreatePin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(207)))), ((int)(((byte)(240)))));
            this.lblCreatePin.Location = new System.Drawing.Point(6, 74);
            this.lblCreatePin.Name = "lblCreatePin";
            this.lblCreatePin.Size = new System.Drawing.Size(53, 15);
            this.lblCreatePin.TabIndex = 2;
            this.lblCreatePin.Text = "New PIN";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(207)))), ((int)(((byte)(240)))));
            this.lblFullName.Location = new System.Drawing.Point(6, 19);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(61, 15);
            this.lblFullName.TabIndex = 0;
            this.lblFullName.Text = "Full Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(207)))), ((int)(((byte)(240)))));
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Login";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(637, 321);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.grpboxCreateAccount);
            this.Controls.Add(this.txtboxPIN);
            this.Controls.Add(this.txtboxAccountNumber);
            this.Controls.Add(this.lblAccountNumber);
            this.Controls.Add(this.lblPIN);
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.Text = "ATM SImulation";
            this.grpboxCreateAccount.ResumeLayout(false);
            this.grpboxCreateAccount.PerformLayout();
            this.grpboxAccountType.ResumeLayout(false);
            this.grpboxAccountType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private GroupBox grpboxAccountType;
        private RadioButton radioBtnSavings;
        private RadioButton radioBtnChecking;
        private Label label1;
    }
}
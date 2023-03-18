namespace ATMSimulationProject
{
    partial class LoginWithPINForm
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
            grpboxLogin = new GroupBox();
            btnLogin = new Button();
            txtboxPIN = new TextBox();
            txtboxAccountNumber = new TextBox();
            lblPIN = new Label();
            lblAccountNumber = new Label();
            grpboxLogin.SuspendLayout();
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
            grpboxLogin.TabIndex = 1;
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
            txtboxPIN.MaxLength = 4;
            txtboxPIN.Name = "txtboxPIN";
            txtboxPIN.PasswordChar = '*';
            txtboxPIN.Size = new Size(235, 23);
            txtboxPIN.TabIndex = 4;
            txtboxPIN.UseSystemPasswordChar = true;
            // 
            // txtboxAccountNumber
            // 
            txtboxAccountNumber.Location = new Point(6, 37);
            txtboxAccountNumber.MaxLength = 3;
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
            // LoginWithPINForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(281, 296);
            Controls.Add(grpboxLogin);
            MaximizeBox = false;
            Name = "LoginWithPINForm";
            Text = "LoginWithPINForm";
            grpboxLogin.ResumeLayout(false);
            grpboxLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpboxLogin;
        private Button btnLogin;
        private TextBox txtboxPIN;
        private TextBox txtboxAccountNumber;
        private Label lblPIN;
        private Label lblAccountNumber;
    }
}
namespace ATMSimulationProject
{
    partial class AccountForm
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
            lblWelcome = new Label();
            lbltxtBalance = new Label();
            lblBalance = new Label();
            grpboxWithdraw = new GroupBox();
            btnWithdraw = new Button();
            txtBoxWithdraw = new TextBox();
            lblWithdraw = new Label();
            grpboxDeposit = new GroupBox();
            grpboxType = new GroupBox();
            radioButton1 = new RadioButton();
            radiobtnCash = new RadioButton();
            btnDeposit = new Button();
            txtboxDeposit = new TextBox();
            lblDeposit = new Label();
            grpboxTransfer = new GroupBox();
            lblRecipientAccount = new Label();
            combobxRecipients = new ComboBox();
            btnTransfer = new Button();
            txtboxTransfer = new TextBox();
            lblTransfer = new Label();
            btnLogout = new Button();
            grpboxWithdraw.SuspendLayout();
            grpboxDeposit.SuspendLayout();
            grpboxType.SuspendLayout();
            grpboxTransfer.SuspendLayout();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblWelcome.Location = new Point(12, 9);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(93, 25);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome";
            // 
            // lbltxtBalance
            // 
            lbltxtBalance.AutoSize = true;
            lbltxtBalance.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbltxtBalance.Location = new Point(492, 9);
            lbltxtBalance.Name = "lbltxtBalance";
            lbltxtBalance.RightToLeft = RightToLeft.Yes;
            lbltxtBalance.Size = new Size(80, 25);
            lbltxtBalance.TabIndex = 1;
            lbltxtBalance.Text = "Balance";
            lbltxtBalance.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblBalance.Location = new Point(678, 9);
            lblBalance.Name = "lblBalance";
            lblBalance.RightToLeft = RightToLeft.Yes;
            lblBalance.Size = new Size(23, 25);
            lblBalance.TabIndex = 2;
            lblBalance.Text = "0";
            lblBalance.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // grpboxWithdraw
            // 
            grpboxWithdraw.Controls.Add(btnWithdraw);
            grpboxWithdraw.Controls.Add(txtBoxWithdraw);
            grpboxWithdraw.Controls.Add(lblWithdraw);
            grpboxWithdraw.Location = new Point(12, 47);
            grpboxWithdraw.Name = "grpboxWithdraw";
            grpboxWithdraw.Size = new Size(200, 234);
            grpboxWithdraw.TabIndex = 3;
            grpboxWithdraw.TabStop = false;
            grpboxWithdraw.Text = "Withdraw";
            // 
            // btnWithdraw
            // 
            btnWithdraw.Location = new Point(13, 205);
            btnWithdraw.Name = "btnWithdraw";
            btnWithdraw.Size = new Size(169, 23);
            btnWithdraw.TabIndex = 2;
            btnWithdraw.Text = "Withdraw";
            btnWithdraw.UseVisualStyleBackColor = true;
            btnWithdraw.Click += btnWithdraw_Click;
            // 
            // txtBoxWithdraw
            // 
            txtBoxWithdraw.Location = new Point(13, 47);
            txtBoxWithdraw.Name = "txtBoxWithdraw";
            txtBoxWithdraw.Size = new Size(169, 23);
            txtBoxWithdraw.TabIndex = 1;
            // 
            // lblWithdraw
            // 
            lblWithdraw.AutoSize = true;
            lblWithdraw.Location = new Point(10, 23);
            lblWithdraw.Name = "lblWithdraw";
            lblWithdraw.Size = new Size(149, 15);
            lblWithdraw.TabIndex = 0;
            lblWithdraw.Text = "Enter Amount to Withdraw";
            // 
            // grpboxDeposit
            // 
            grpboxDeposit.Controls.Add(grpboxType);
            grpboxDeposit.Controls.Add(btnDeposit);
            grpboxDeposit.Controls.Add(txtboxDeposit);
            grpboxDeposit.Controls.Add(lblDeposit);
            grpboxDeposit.Location = new Point(232, 47);
            grpboxDeposit.Name = "grpboxDeposit";
            grpboxDeposit.Size = new Size(200, 234);
            grpboxDeposit.TabIndex = 4;
            grpboxDeposit.TabStop = false;
            grpboxDeposit.Text = "Deposit";
            // 
            // grpboxType
            // 
            grpboxType.Controls.Add(radioButton1);
            grpboxType.Controls.Add(radiobtnCash);
            grpboxType.Location = new Point(7, 90);
            grpboxType.Name = "grpboxType";
            grpboxType.Size = new Size(179, 86);
            grpboxType.TabIndex = 4;
            grpboxType.TabStop = false;
            grpboxType.Text = "Type";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(11, 49);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(66, 19);
            radioButton1.TabIndex = 1;
            radioButton1.Text = "Cheque";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radiobtnCash
            // 
            radiobtnCash.AutoSize = true;
            radiobtnCash.Checked = true;
            radiobtnCash.Location = new Point(11, 24);
            radiobtnCash.Name = "radiobtnCash";
            radiobtnCash.Size = new Size(51, 19);
            radiobtnCash.TabIndex = 0;
            radiobtnCash.TabStop = true;
            radiobtnCash.Text = "Cash";
            radiobtnCash.UseVisualStyleBackColor = true;
            // 
            // btnDeposit
            // 
            btnDeposit.Location = new Point(6, 205);
            btnDeposit.Name = "btnDeposit";
            btnDeposit.Size = new Size(169, 23);
            btnDeposit.TabIndex = 3;
            btnDeposit.Text = "Deposit";
            btnDeposit.UseVisualStyleBackColor = true;
            btnDeposit.Click += btnDeposit_Click;
            // 
            // txtboxDeposit
            // 
            txtboxDeposit.Location = new Point(6, 47);
            txtboxDeposit.Name = "txtboxDeposit";
            txtboxDeposit.Size = new Size(169, 23);
            txtboxDeposit.TabIndex = 2;
            // 
            // lblDeposit
            // 
            lblDeposit.AutoSize = true;
            lblDeposit.Location = new Point(6, 23);
            lblDeposit.Name = "lblDeposit";
            lblDeposit.Size = new Size(138, 15);
            lblDeposit.TabIndex = 1;
            lblDeposit.Text = "Enter Amount to Deposit";
            // 
            // grpboxTransfer
            // 
            grpboxTransfer.Controls.Add(lblRecipientAccount);
            grpboxTransfer.Controls.Add(combobxRecipients);
            grpboxTransfer.Controls.Add(btnTransfer);
            grpboxTransfer.Controls.Add(txtboxTransfer);
            grpboxTransfer.Controls.Add(lblTransfer);
            grpboxTransfer.Location = new Point(463, 47);
            grpboxTransfer.Name = "grpboxTransfer";
            grpboxTransfer.Size = new Size(200, 234);
            grpboxTransfer.TabIndex = 5;
            grpboxTransfer.TabStop = false;
            grpboxTransfer.Text = "Transfer";
            // 
            // lblRecipientAccount
            // 
            lblRecipientAccount.AutoSize = true;
            lblRecipientAccount.Location = new Point(6, 90);
            lblRecipientAccount.Name = "lblRecipientAccount";
            lblRecipientAccount.Size = new Size(104, 15);
            lblRecipientAccount.TabIndex = 6;
            lblRecipientAccount.Text = "Recipient Account";
            // 
            // combobxRecipients
            // 
            combobxRecipients.FormattingEnabled = true;
            combobxRecipients.Location = new Point(6, 113);
            combobxRecipients.Name = "combobxRecipients";
            combobxRecipients.Size = new Size(169, 23);
            combobxRecipients.TabIndex = 5;
            // 
            // btnTransfer
            // 
            btnTransfer.Location = new Point(6, 205);
            btnTransfer.Name = "btnTransfer";
            btnTransfer.Size = new Size(169, 23);
            btnTransfer.TabIndex = 4;
            btnTransfer.Text = "Transfer";
            btnTransfer.UseVisualStyleBackColor = true;
            btnTransfer.Click += btnTransfer_Click;
            // 
            // txtboxTransfer
            // 
            txtboxTransfer.Location = new Point(6, 47);
            txtboxTransfer.Name = "txtboxTransfer";
            txtboxTransfer.Size = new Size(169, 23);
            txtboxTransfer.TabIndex = 3;
            // 
            // lblTransfer
            // 
            lblTransfer.AutoSize = true;
            lblTransfer.Location = new Point(6, 23);
            lblTransfer.Name = "lblTransfer";
            lblTransfer.Size = new Size(139, 15);
            lblTransfer.TabIndex = 2;
            lblTransfer.Text = "Enter Amount to Transfer";
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(469, 296);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(194, 23);
            btnLogout.TabIndex = 10;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // AccountForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(716, 331);
            Controls.Add(btnLogout);
            Controls.Add(grpboxTransfer);
            Controls.Add(grpboxDeposit);
            Controls.Add(grpboxWithdraw);
            Controls.Add(lblBalance);
            Controls.Add(lbltxtBalance);
            Controls.Add(lblWelcome);
            MaximizeBox = false;
            Name = "AccountForm";
            Text = "ATM Simulation";
            grpboxWithdraw.ResumeLayout(false);
            grpboxWithdraw.PerformLayout();
            grpboxDeposit.ResumeLayout(false);
            grpboxDeposit.PerformLayout();
            grpboxType.ResumeLayout(false);
            grpboxType.PerformLayout();
            grpboxTransfer.ResumeLayout(false);
            grpboxTransfer.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWelcome;
        private Label lbltxtBalance;
        private Label lblBalance;
        private GroupBox grpboxWithdraw;
        private TextBox txtBoxWithdraw;
        private Label lblWithdraw;
        private GroupBox grpboxDeposit;
        private TextBox txtboxDeposit;
        private Label lblDeposit;
        private GroupBox grpboxTransfer;
        private TextBox txtboxTransfer;
        private Label lblTransfer;
        private Button btnWithdraw;
        private GroupBox grpboxType;
        private Button btnDeposit;
        private Button btnTransfer;
        private RadioButton radioButton1;
        private RadioButton radiobtnCash;
        private Label lblRecipientAccount;
        private ComboBox combobxRecipients;
        private Button btnLogout;
    }
}
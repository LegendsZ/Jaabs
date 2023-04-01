namespace ATMSimulationProject
{
    partial class DepositForm
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
            grpboxType = new GroupBox();
            radioButton1 = new RadioButton();
            radiobtnCash = new RadioButton();
            btnDeposit = new Button();
            txtboxDeposit = new TextBox();
            lblDeposit = new Label();
            lbltxtBalance = new Label();
            lblBalance = new Label();
            btnLogout = new Button();
            combobxRecipients = new ComboBox();
            lblRecipientAccount = new Label();
            button2 = new Button();
            grpboxType.SuspendLayout();
            SuspendLayout();
            // 
            // grpboxType
            // 
            grpboxType.Controls.Add(radioButton1);
            grpboxType.Controls.Add(radiobtnCash);
            grpboxType.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            grpboxType.ForeColor = Color.Yellow;
            grpboxType.Location = new Point(41, 170);
            grpboxType.Name = "grpboxType";
            grpboxType.Size = new Size(179, 86);
            grpboxType.TabIndex = 4;
            grpboxType.TabStop = false;
            grpboxType.Text = "Type";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.ForeColor = Color.FromArgb(137, 207, 240);
            radioButton1.Location = new Point(11, 49);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(95, 29);
            radioButton1.TabIndex = 1;
            radioButton1.Text = "Cheque";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radiobtnCash
            // 
            radiobtnCash.AutoSize = true;
            radiobtnCash.Checked = true;
            radiobtnCash.ForeColor = Color.FromArgb(137, 207, 240);
            radiobtnCash.Location = new Point(11, 24);
            radiobtnCash.Name = "radiobtnCash";
            radiobtnCash.Size = new Size(71, 29);
            radiobtnCash.TabIndex = 0;
            radiobtnCash.TabStop = true;
            radiobtnCash.Text = "Cash";
            radiobtnCash.UseVisualStyleBackColor = true;
            // 
            // btnDeposit
            // 
            btnDeposit.BackColor = Color.FromArgb(137, 207, 240);
            btnDeposit.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDeposit.ForeColor = Color.MediumBlue;
            btnDeposit.Location = new Point(297, 223);
            btnDeposit.Name = "btnDeposit";
            btnDeposit.Size = new Size(125, 40);
            btnDeposit.TabIndex = 3;
            btnDeposit.Text = "Deposit";
            btnDeposit.UseVisualStyleBackColor = false;
            // 
            // txtboxDeposit
            // 
            txtboxDeposit.BackColor = SystemColors.ScrollBar;
            txtboxDeposit.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtboxDeposit.Location = new Point(41, 55);
            txtboxDeposit.Name = "txtboxDeposit";
            txtboxDeposit.Size = new Size(180, 33);
            txtboxDeposit.TabIndex = 2;
            // 
            // lblDeposit
            // 
            lblDeposit.AutoSize = true;
            lblDeposit.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblDeposit.ForeColor = Color.FromArgb(137, 207, 240);
            lblDeposit.Location = new Point(12, 12);
            lblDeposit.Name = "lblDeposit";
            lblDeposit.Size = new Size(234, 25);
            lblDeposit.TabIndex = 1;
            lblDeposit.Text = "Enter Amount to Deposit";
            // 
            // lbltxtBalance
            // 
            lbltxtBalance.AutoSize = true;
            lbltxtBalance.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbltxtBalance.ForeColor = Color.FromArgb(137, 207, 240);
            lbltxtBalance.Location = new Point(12, 259);
            lbltxtBalance.Name = "lbltxtBalance";
            lbltxtBalance.RightToLeft = RightToLeft.Yes;
            lbltxtBalance.Size = new Size(80, 25);
            lbltxtBalance.TabIndex = 6;
            lbltxtBalance.Text = "Balance";
            lbltxtBalance.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBalance
            // 
            lblBalance.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblBalance.ForeColor = Color.FromArgb(137, 207, 240);
            lblBalance.Location = new Point(12, 284);
            lblBalance.Name = "lblBalance";
            lblBalance.RightToLeft = RightToLeft.Yes;
            lblBalance.Size = new Size(93, 25);
            lblBalance.TabIndex = 7;
            lblBalance.Text = "0";
            lblBalance.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(137, 207, 240);
            btnLogout.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogout.ForeColor = Color.Crimson;
            btnLogout.Location = new Point(297, 12);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(125, 40);
            btnLogout.TabIndex = 10;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // combobxRecipients
            // 
            combobxRecipients.BackColor = SystemColors.ScrollBar;
            combobxRecipients.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            combobxRecipients.FormattingEnabled = true;
            combobxRecipients.Items.AddRange(new object[] { "Savings", "Chequing" });
            combobxRecipients.Location = new Point(41, 119);
            combobxRecipients.Name = "combobxRecipients";
            combobxRecipients.Size = new Size(169, 33);
            combobxRecipients.TabIndex = 20;
            // 
            // lblRecipientAccount
            // 
            lblRecipientAccount.AutoSize = true;
            lblRecipientAccount.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblRecipientAccount.ForeColor = Color.FromArgb(137, 207, 240);
            lblRecipientAccount.Location = new Point(41, 91);
            lblRecipientAccount.Name = "lblRecipientAccount";
            lblRecipientAccount.Size = new Size(173, 25);
            lblRecipientAccount.TabIndex = 21;
            lblRecipientAccount.Text = "Recipient Account";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(137, 207, 240);
            button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.Crimson;
            button2.Location = new Point(297, 269);
            button2.Name = "button2";
            button2.Size = new Size(125, 40);
            button2.TabIndex = 23;
            button2.Text = "Go Back";
            button2.UseVisualStyleBackColor = false;
            button2.Click += DepositForm_Load;
            // 
            // DepositForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(434, 321);
            Controls.Add(grpboxType);
            Controls.Add(button2);
            Controls.Add(txtboxDeposit);
            Controls.Add(combobxRecipients);
            Controls.Add(lblDeposit);
            Controls.Add(btnDeposit);
            Controls.Add(lblRecipientAccount);
            Controls.Add(btnLogout);
            Controls.Add(lblBalance);
            Controls.Add(lbltxtBalance);
            MaximizeBox = false;
            Name = "DepositForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DepositForm";
            Load += DepositForm_Load;
            grpboxType.ResumeLayout(false);
            grpboxType.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox grpboxType;
        private RadioButton radioButton1;
        private RadioButton radiobtnCash;
        private Button btnDeposit;
        private TextBox txtboxDeposit;
        private Label lblDeposit;
        private Label lbltxtBalance;
        private Label lblBalance;
        private Button btnLogout;
        private ComboBox combobxRecipients;
        private Label lblRecipientAccount;
        private Button button2;
    }
}
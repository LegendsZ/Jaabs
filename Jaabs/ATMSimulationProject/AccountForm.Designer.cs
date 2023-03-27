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
            this.lbltxtBalance = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.grpboxWithdraw = new System.Windows.Forms.GroupBox();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.txtBoxWithdraw = new System.Windows.Forms.TextBox();
            this.lblWithdraw = new System.Windows.Forms.Label();
            this.grpboxDeposit = new System.Windows.Forms.GroupBox();
            this.grpboxType = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radiobtnCash = new System.Windows.Forms.RadioButton();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.txtboxDeposit = new System.Windows.Forms.TextBox();
            this.lblDeposit = new System.Windows.Forms.Label();
            this.grpboxTransfer = new System.Windows.Forms.GroupBox();
            this.lblRecipientAccount = new System.Windows.Forms.Label();
            this.combobxRecipients = new System.Windows.Forms.ComboBox();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.txtboxTransfer = new System.Windows.Forms.TextBox();
            this.lblTransfer = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.grpboxWithdraw.SuspendLayout();
            this.grpboxDeposit.SuspendLayout();
            this.grpboxType.SuspendLayout();
            this.grpboxTransfer.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbltxtBalance
            // 
            this.lbltxtBalance.AutoSize = true;
            this.lbltxtBalance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbltxtBalance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(207)))), ((int)(((byte)(240)))));
            this.lbltxtBalance.Location = new System.Drawing.Point(232, 12);
            this.lbltxtBalance.Name = "lbltxtBalance";
            this.lbltxtBalance.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbltxtBalance.Size = new System.Drawing.Size(80, 25);
            this.lbltxtBalance.TabIndex = 1;
            this.lbltxtBalance.Text = "Balance";
            this.lbltxtBalance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBalance.Location = new System.Drawing.Point(678, 9);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblBalance.Size = new System.Drawing.Size(23, 25);
            this.lblBalance.TabIndex = 2;
            this.lblBalance.Text = "0";
            this.lblBalance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpboxWithdraw
            // 
            this.grpboxWithdraw.Controls.Add(this.btnWithdraw);
            this.grpboxWithdraw.Controls.Add(this.txtBoxWithdraw);
            this.grpboxWithdraw.Controls.Add(this.lblWithdraw);
            this.grpboxWithdraw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(207)))), ((int)(((byte)(240)))));
            this.grpboxWithdraw.Location = new System.Drawing.Point(12, 12);
            this.grpboxWithdraw.Name = "grpboxWithdraw";
            this.grpboxWithdraw.Size = new System.Drawing.Size(200, 83);
            this.grpboxWithdraw.TabIndex = 3;
            this.grpboxWithdraw.TabStop = false;
            this.grpboxWithdraw.Text = "Withdraw";
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(207)))), ((int)(((byte)(240)))));
            this.btnWithdraw.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnWithdraw.Location = new System.Drawing.Point(13, 205);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(169, 23);
            this.btnWithdraw.TabIndex = 2;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = false;
            // 
            // txtBoxWithdraw
            // 
            this.txtBoxWithdraw.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtBoxWithdraw.Location = new System.Drawing.Point(13, 47);
            this.txtBoxWithdraw.Name = "txtBoxWithdraw";
            this.txtBoxWithdraw.Size = new System.Drawing.Size(169, 23);
            this.txtBoxWithdraw.TabIndex = 1;
            // 
            // lblWithdraw
            // 
            this.lblWithdraw.AutoSize = true;
            this.lblWithdraw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(207)))), ((int)(((byte)(240)))));
            this.lblWithdraw.Location = new System.Drawing.Point(10, 23);
            this.lblWithdraw.Name = "lblWithdraw";
            this.lblWithdraw.Size = new System.Drawing.Size(149, 15);
            this.lblWithdraw.TabIndex = 0;
            this.lblWithdraw.Text = "Enter Amount to Withdraw";
            // 
            // grpboxDeposit
            // 
            this.grpboxDeposit.Controls.Add(this.grpboxType);
            this.grpboxDeposit.Controls.Add(this.btnDeposit);
            this.grpboxDeposit.Controls.Add(this.txtboxDeposit);
            this.grpboxDeposit.Controls.Add(this.lblDeposit);
            this.grpboxDeposit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(207)))), ((int)(((byte)(240)))));
            this.grpboxDeposit.Location = new System.Drawing.Point(12, 111);
            this.grpboxDeposit.Name = "grpboxDeposit";
            this.grpboxDeposit.Size = new System.Drawing.Size(200, 183);
            this.grpboxDeposit.TabIndex = 4;
            this.grpboxDeposit.TabStop = false;
            this.grpboxDeposit.Text = "Deposit";
            // 
            // grpboxType
            // 
            this.grpboxType.Controls.Add(this.radioButton1);
            this.grpboxType.Controls.Add(this.radiobtnCash);
            this.grpboxType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(207)))), ((int)(((byte)(240)))));
            this.grpboxType.Location = new System.Drawing.Point(7, 90);
            this.grpboxType.Name = "grpboxType";
            this.grpboxType.Size = new System.Drawing.Size(179, 86);
            this.grpboxType.TabIndex = 4;
            this.grpboxType.TabStop = false;
            this.grpboxType.Text = "Type";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(207)))), ((int)(((byte)(240)))));
            this.radioButton1.Location = new System.Drawing.Point(11, 49);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(66, 19);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.Text = "Cheque";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radiobtnCash
            // 
            this.radiobtnCash.AutoSize = true;
            this.radiobtnCash.Checked = true;
            this.radiobtnCash.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(207)))), ((int)(((byte)(240)))));
            this.radiobtnCash.Location = new System.Drawing.Point(11, 24);
            this.radiobtnCash.Name = "radiobtnCash";
            this.radiobtnCash.Size = new System.Drawing.Size(51, 19);
            this.radiobtnCash.TabIndex = 0;
            this.radiobtnCash.TabStop = true;
            this.radiobtnCash.Text = "Cash";
            this.radiobtnCash.UseVisualStyleBackColor = true;
            // 
            // btnDeposit
            // 
            this.btnDeposit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(207)))), ((int)(((byte)(240)))));
            this.btnDeposit.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnDeposit.Location = new System.Drawing.Point(6, 205);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(169, 23);
            this.btnDeposit.TabIndex = 3;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = false;
            // 
            // txtboxDeposit
            // 
            this.txtboxDeposit.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtboxDeposit.Location = new System.Drawing.Point(6, 47);
            this.txtboxDeposit.Name = "txtboxDeposit";
            this.txtboxDeposit.Size = new System.Drawing.Size(169, 23);
            this.txtboxDeposit.TabIndex = 2;
            // 
            // lblDeposit
            // 
            this.lblDeposit.AutoSize = true;
            this.lblDeposit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(207)))), ((int)(((byte)(240)))));
            this.lblDeposit.Location = new System.Drawing.Point(6, 23);
            this.lblDeposit.Name = "lblDeposit";
            this.lblDeposit.Size = new System.Drawing.Size(138, 15);
            this.lblDeposit.TabIndex = 1;
            this.lblDeposit.Text = "Enter Amount to Deposit";
            // 
            // grpboxTransfer
            // 
            this.grpboxTransfer.Controls.Add(this.lblRecipientAccount);
            this.grpboxTransfer.Controls.Add(this.combobxRecipients);
            this.grpboxTransfer.Controls.Add(this.btnTransfer);
            this.grpboxTransfer.Controls.Add(this.txtboxTransfer);
            this.grpboxTransfer.Controls.Add(this.lblTransfer);
            this.grpboxTransfer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(207)))), ((int)(((byte)(240)))));
            this.grpboxTransfer.Location = new System.Drawing.Point(232, 40);
            this.grpboxTransfer.Name = "grpboxTransfer";
            this.grpboxTransfer.Size = new System.Drawing.Size(200, 192);
            this.grpboxTransfer.TabIndex = 5;
            this.grpboxTransfer.TabStop = false;
            this.grpboxTransfer.Text = "Transfer";
            // 
            // lblRecipientAccount
            // 
            this.lblRecipientAccount.AutoSize = true;
            this.lblRecipientAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(207)))), ((int)(((byte)(240)))));
            this.lblRecipientAccount.Location = new System.Drawing.Point(6, 90);
            this.lblRecipientAccount.Name = "lblRecipientAccount";
            this.lblRecipientAccount.Size = new System.Drawing.Size(104, 15);
            this.lblRecipientAccount.TabIndex = 6;
            this.lblRecipientAccount.Text = "Recipient Account";
            // 
            // combobxRecipients
            // 
            this.combobxRecipients.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.combobxRecipients.FormattingEnabled = true;
            this.combobxRecipients.Location = new System.Drawing.Point(6, 113);
            this.combobxRecipients.Name = "combobxRecipients";
            this.combobxRecipients.Size = new System.Drawing.Size(169, 23);
            this.combobxRecipients.TabIndex = 5;
            // 
            // btnTransfer
            // 
            this.btnTransfer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(207)))), ((int)(((byte)(240)))));
            this.btnTransfer.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnTransfer.Location = new System.Drawing.Point(6, 146);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(169, 23);
            this.btnTransfer.TabIndex = 4;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.UseVisualStyleBackColor = false;
            // 
            // txtboxTransfer
            // 
            this.txtboxTransfer.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtboxTransfer.Location = new System.Drawing.Point(6, 47);
            this.txtboxTransfer.Name = "txtboxTransfer";
            this.txtboxTransfer.Size = new System.Drawing.Size(169, 23);
            this.txtboxTransfer.TabIndex = 3;
            // 
            // lblTransfer
            // 
            this.lblTransfer.AutoSize = true;
            this.lblTransfer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(207)))), ((int)(((byte)(240)))));
            this.lblTransfer.Location = new System.Drawing.Point(6, 23);
            this.lblTransfer.Name = "lblTransfer";
            this.lblTransfer.Size = new System.Drawing.Size(139, 15);
            this.lblTransfer.TabIndex = 2;
            this.lblTransfer.Text = "Enter Amount to Transfer";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(207)))), ((int)(((byte)(240)))));
            this.btnLogout.ForeColor = System.Drawing.Color.Crimson;
            this.btnLogout.Location = new System.Drawing.Point(271, 250);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(136, 44);
            this.btnLogout.TabIndex = 10;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // AccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(434, 321);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.grpboxTransfer);
            this.Controls.Add(this.grpboxDeposit);
            this.Controls.Add(this.grpboxWithdraw);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.lbltxtBalance);
            this.MaximizeBox = false;
            this.Name = "AccountForm";
            this.Text = "ATM Simulation";
            this.grpboxWithdraw.ResumeLayout(false);
            this.grpboxWithdraw.PerformLayout();
            this.grpboxDeposit.ResumeLayout(false);
            this.grpboxDeposit.PerformLayout();
            this.grpboxType.ResumeLayout(false);
            this.grpboxType.PerformLayout();
            this.grpboxTransfer.ResumeLayout(false);
            this.grpboxTransfer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
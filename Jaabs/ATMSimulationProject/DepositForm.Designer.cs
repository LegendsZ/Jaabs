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
            this.grpboxType = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radiobtnCash = new System.Windows.Forms.RadioButton();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.txtboxDeposit = new System.Windows.Forms.TextBox();
            this.lblDeposit = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.combobxRecipients = new System.Windows.Forms.ComboBox();
            this.lblRecipientAccount = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.grpboxType.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpboxType
            // 
            this.grpboxType.Controls.Add(this.radioButton1);
            this.grpboxType.Controls.Add(this.radiobtnCash);
            this.grpboxType.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpboxType.ForeColor = System.Drawing.Color.Yellow;
            this.grpboxType.Location = new System.Drawing.Point(41, 170);
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
            this.radioButton1.Size = new System.Drawing.Size(95, 29);
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
            this.radiobtnCash.Size = new System.Drawing.Size(71, 29);
            this.radiobtnCash.TabIndex = 0;
            this.radiobtnCash.TabStop = true;
            this.radiobtnCash.Text = "Cash";
            this.radiobtnCash.UseVisualStyleBackColor = true;
            // 
            // btnDeposit
            // 
            this.btnDeposit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(207)))), ((int)(((byte)(240)))));
            this.btnDeposit.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeposit.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnDeposit.Location = new System.Drawing.Point(297, 223);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(125, 40);
            this.btnDeposit.TabIndex = 3;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = false;
            // 
            // txtboxDeposit
            // 
            this.txtboxDeposit.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtboxDeposit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtboxDeposit.Location = new System.Drawing.Point(41, 55);
            this.txtboxDeposit.Name = "txtboxDeposit";
            this.txtboxDeposit.Size = new System.Drawing.Size(180, 33);
            this.txtboxDeposit.TabIndex = 2;
            // 
            // lblDeposit
            // 
            this.lblDeposit.AutoSize = true;
            this.lblDeposit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDeposit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(207)))), ((int)(((byte)(240)))));
            this.lblDeposit.Location = new System.Drawing.Point(12, 12);
            this.lblDeposit.Name = "lblDeposit";
            this.lblDeposit.Size = new System.Drawing.Size(234, 25);
            this.lblDeposit.TabIndex = 1;
            this.lblDeposit.Text = "Enter Amount to Deposit";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(207)))), ((int)(((byte)(240)))));
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogout.ForeColor = System.Drawing.Color.Crimson;
            this.btnLogout.Location = new System.Drawing.Point(297, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(125, 40);
            this.btnLogout.TabIndex = 10;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // combobxRecipients
            // 
            this.combobxRecipients.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.combobxRecipients.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.combobxRecipients.FormattingEnabled = true;
            this.combobxRecipients.Items.AddRange(new object[] {
            "Savings",
            "Chequing"});
            this.combobxRecipients.Location = new System.Drawing.Point(41, 119);
            this.combobxRecipients.Name = "combobxRecipients";
            this.combobxRecipients.Size = new System.Drawing.Size(169, 33);
            this.combobxRecipients.TabIndex = 20;
            // 
            // lblRecipientAccount
            // 
            this.lblRecipientAccount.AutoSize = true;
            this.lblRecipientAccount.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRecipientAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(207)))), ((int)(((byte)(240)))));
            this.lblRecipientAccount.Location = new System.Drawing.Point(41, 91);
            this.lblRecipientAccount.Name = "lblRecipientAccount";
            this.lblRecipientAccount.Size = new System.Drawing.Size(173, 25);
            this.lblRecipientAccount.TabIndex = 21;
            this.lblRecipientAccount.Text = "Recipient Account";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(207)))), ((int)(((byte)(240)))));
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.Crimson;
            this.button2.Location = new System.Drawing.Point(297, 269);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 40);
            this.button2.TabIndex = 23;
            this.button2.Text = "Go Back";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // DepositForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(434, 321);
            this.Controls.Add(this.grpboxType);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtboxDeposit);
            this.Controls.Add(this.combobxRecipients);
            this.Controls.Add(this.lblDeposit);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.lblRecipientAccount);
            this.Controls.Add(this.btnLogout);
            this.MaximizeBox = false;
            this.Name = "DepositForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DepositForm";
            this.grpboxType.ResumeLayout(false);
            this.grpboxType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private GroupBox grpboxType;
        private RadioButton radioButton1;
        private RadioButton radiobtnCash;
        private Button btnDeposit;
        private TextBox txtboxDeposit;
        private Label lblDeposit;
        private Button btnLogout;
        private ComboBox combobxRecipients;
        private Label lblRecipientAccount;
        private Button button2;
    }
}
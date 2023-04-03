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
            this.radioBtnCheque = new System.Windows.Forms.RadioButton();
            this.radioBtnCash = new System.Windows.Forms.RadioButton();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.combobxRecipients = new System.Windows.Forms.ComboBox();
            this.lblRecipientAccount = new System.Windows.Forms.Label();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.grpboxType.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpboxType
            // 
            this.grpboxType.Controls.Add(this.radioBtnCheque);
            this.grpboxType.Controls.Add(this.radioBtnCash);
            this.grpboxType.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpboxType.ForeColor = System.Drawing.Color.Yellow;
            this.grpboxType.Location = new System.Drawing.Point(62, 114);
            this.grpboxType.Name = "grpboxType";
            this.grpboxType.Size = new System.Drawing.Size(179, 86);
            this.grpboxType.TabIndex = 4;
            this.grpboxType.TabStop = false;
            this.grpboxType.Text = "Type";
            // 
            // radioBtnCheque
            // 
            this.radioBtnCheque.AutoSize = true;
            this.radioBtnCheque.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(207)))), ((int)(((byte)(240)))));
            this.radioBtnCheque.Location = new System.Drawing.Point(11, 49);
            this.radioBtnCheque.Name = "radioBtnCheque";
            this.radioBtnCheque.Size = new System.Drawing.Size(95, 29);
            this.radioBtnCheque.TabIndex = 1;
            this.radioBtnCheque.Text = "Cheque";
            this.radioBtnCheque.UseVisualStyleBackColor = true;
            this.radioBtnCheque.Click += new System.EventHandler(this.radioBtnCheque_Click);
            // 
            // radioBtnCash
            // 
            this.radioBtnCash.AutoSize = true;
            this.radioBtnCash.Checked = true;
            this.radioBtnCash.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(207)))), ((int)(((byte)(240)))));
            this.radioBtnCash.Location = new System.Drawing.Point(11, 24);
            this.radioBtnCash.Name = "radioBtnCash";
            this.radioBtnCash.Size = new System.Drawing.Size(71, 29);
            this.radioBtnCash.TabIndex = 0;
            this.radioBtnCash.TabStop = true;
            this.radioBtnCash.Text = "Cash";
            this.radioBtnCash.UseVisualStyleBackColor = true;
            this.radioBtnCash.Click += new System.EventHandler(this.radioBtnCash_Click);
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
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // combobxRecipients
            // 
            this.combobxRecipients.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.combobxRecipients.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.combobxRecipients.FormattingEnabled = true;
            this.combobxRecipients.Items.AddRange(new object[] {
            "Savings",
            "Chequing"});
            this.combobxRecipients.Location = new System.Drawing.Point(62, 63);
            this.combobxRecipients.Name = "combobxRecipients";
            this.combobxRecipients.Size = new System.Drawing.Size(169, 33);
            this.combobxRecipients.TabIndex = 20;
            // 
            // lblRecipientAccount
            // 
            this.lblRecipientAccount.AutoSize = true;
            this.lblRecipientAccount.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRecipientAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(207)))), ((int)(((byte)(240)))));
            this.lblRecipientAccount.Location = new System.Drawing.Point(62, 35);
            this.lblRecipientAccount.Name = "lblRecipientAccount";
            this.lblRecipientAccount.Size = new System.Drawing.Size(173, 25);
            this.lblRecipientAccount.TabIndex = 21;
            this.lblRecipientAccount.Text = "Recipient Account";
            // 
            // btnGoBack
            // 
            this.btnGoBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(207)))), ((int)(((byte)(240)))));
            this.btnGoBack.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGoBack.ForeColor = System.Drawing.Color.Crimson;
            this.btnGoBack.Location = new System.Drawing.Point(297, 269);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(125, 40);
            this.btnGoBack.TabIndex = 23;
            this.btnGoBack.Text = "Go Back";
            this.btnGoBack.UseVisualStyleBackColor = false;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // DepositForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(434, 321);
            this.Controls.Add(this.grpboxType);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.combobxRecipients);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.lblRecipientAccount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
        private RadioButton radioBtnCheque;
        private RadioButton radioBtnCash;
        private Button btnDeposit;
        private ComboBox combobxRecipients;
        private Label lblRecipientAccount;
        private Button btnGoBack;
    }
}
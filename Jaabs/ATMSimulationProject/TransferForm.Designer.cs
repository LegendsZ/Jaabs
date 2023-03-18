namespace ATMSimulationProject
{
    partial class TransferForm
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
            grpboxTransfer = new GroupBox();
            lblRecipientAccount = new Label();
            combobxRecipients = new ComboBox();
            btnTransfer = new Button();
            txtboxTransfer = new TextBox();
            lblTransfer = new Label();
            lblBalance = new Label();
            lbltxtBalance = new Label();
            btnLogout = new Button();
            grpboxTransfer.SuspendLayout();
            SuspendLayout();
            // 
            // grpboxTransfer
            // 
            grpboxTransfer.Controls.Add(lblRecipientAccount);
            grpboxTransfer.Controls.Add(combobxRecipients);
            grpboxTransfer.Controls.Add(btnTransfer);
            grpboxTransfer.Controls.Add(txtboxTransfer);
            grpboxTransfer.Controls.Add(lblTransfer);
            grpboxTransfer.Location = new Point(12, 60);
            grpboxTransfer.Name = "grpboxTransfer";
            grpboxTransfer.Size = new Size(200, 234);
            grpboxTransfer.TabIndex = 6;
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
            combobxRecipients.Items.AddRange(new object[] { "James Smith", "Jane Doe", "Peter Crow", "Sam Wise", "Dolly West" });
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
            // lblBalance
            // 
            lblBalance.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblBalance.Location = new Point(129, 9);
            lblBalance.Name = "lblBalance";
            lblBalance.RightToLeft = RightToLeft.Yes;
            lblBalance.Size = new Size(92, 25);
            lblBalance.TabIndex = 8;
            lblBalance.Text = "0";
            lblBalance.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbltxtBalance
            // 
            lbltxtBalance.AutoSize = true;
            lbltxtBalance.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbltxtBalance.Location = new Point(12, 9);
            lbltxtBalance.Name = "lbltxtBalance";
            lbltxtBalance.RightToLeft = RightToLeft.Yes;
            lbltxtBalance.Size = new Size(80, 25);
            lbltxtBalance.TabIndex = 7;
            lbltxtBalance.Text = "Balance";
            lbltxtBalance.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(18, 330);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(194, 23);
            btnLogout.TabIndex = 9;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // TransferForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(228, 365);
            Controls.Add(btnLogout);
            Controls.Add(lblBalance);
            Controls.Add(lbltxtBalance);
            Controls.Add(grpboxTransfer);
            Name = "TransferForm";
            Text = "Transfer";
            grpboxTransfer.ResumeLayout(false);
            grpboxTransfer.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpboxTransfer;
        private Label lblRecipientAccount;
        private ComboBox combobxRecipients;
        private Button btnTransfer;
        private TextBox txtboxTransfer;
        private Label lblTransfer;
        private Label lblBalance;
        private Label lbltxtBalance;
        private Button btnLogout;
    }
}
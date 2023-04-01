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
            lblRecipientAccount = new Label();
            combobxRecipients = new ComboBox();
            btnTransfer = new Button();
            txtboxTransfer = new TextBox();
            lblTransfer = new Label();
            lblBalance = new Label();
            lbltxtBalance = new Label();
            btnLogout = new Button();
            button1 = new Button();
            label1 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // lblRecipientAccount
            // 
            lblRecipientAccount.AutoSize = true;
            lblRecipientAccount.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblRecipientAccount.ForeColor = Color.FromArgb(137, 207, 240);
            lblRecipientAccount.Location = new Point(144, 144);
            lblRecipientAccount.Name = "lblRecipientAccount";
            lblRecipientAccount.Size = new Size(173, 25);
            lblRecipientAccount.TabIndex = 6;
            lblRecipientAccount.Text = "Recipient Account";
            // 
            // combobxRecipients
            // 
            combobxRecipients.BackColor = SystemColors.ScrollBar;
            combobxRecipients.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            combobxRecipients.FormattingEnabled = true;
            combobxRecipients.Items.AddRange(new object[] { "Savings", "Chequing" });
            combobxRecipients.Location = new Point(144, 172);
            combobxRecipients.Name = "combobxRecipients";
            combobxRecipients.Size = new Size(169, 33);
            combobxRecipients.TabIndex = 5;
            // 
            // btnTransfer
            // 
            btnTransfer.BackColor = Color.FromArgb(137, 207, 240);
            btnTransfer.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnTransfer.ForeColor = Color.MediumBlue;
            btnTransfer.Location = new Point(297, 223);
            btnTransfer.Name = "btnTransfer";
            btnTransfer.Size = new Size(125, 40);
            btnTransfer.TabIndex = 4;
            btnTransfer.Text = "Transfer";
            btnTransfer.UseVisualStyleBackColor = false;
            // 
            // txtboxTransfer
            // 
            txtboxTransfer.BackColor = SystemColors.ScrollBar;
            txtboxTransfer.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtboxTransfer.Location = new Point(144, 95);
            txtboxTransfer.Name = "txtboxTransfer";
            txtboxTransfer.Size = new Size(169, 33);
            txtboxTransfer.TabIndex = 3;
            // 
            // lblTransfer
            // 
            lblTransfer.AutoSize = true;
            lblTransfer.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTransfer.ForeColor = Color.FromArgb(137, 207, 240);
            lblTransfer.Location = new Point(107, 67);
            lblTransfer.Name = "lblTransfer";
            lblTransfer.Size = new Size(239, 25);
            lblTransfer.TabIndex = 2;
            lblTransfer.Text = "Enter Amount to Transfer";
            // 
            // lblBalance
            // 
            lblBalance.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblBalance.ForeColor = Color.FromArgb(137, 207, 240);
            lblBalance.Location = new Point(12, 284);
            lblBalance.Name = "lblBalance";
            lblBalance.RightToLeft = RightToLeft.Yes;
            lblBalance.Size = new Size(100, 25);
            lblBalance.TabIndex = 8;
            lblBalance.Text = "0";
            lblBalance.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbltxtBalance
            // 
            lbltxtBalance.AutoSize = true;
            lbltxtBalance.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbltxtBalance.ForeColor = Color.FromArgb(137, 207, 240);
            lbltxtBalance.Location = new Point(20, 259);
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
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(137, 207, 240);
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Crimson;
            button1.Location = new Point(297, 269);
            button1.Name = "button1";
            button1.Size = new Size(125, 40);
            button1.TabIndex = 18;
            button1.Text = "Go Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnGoBack_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(137, 207, 240);
            label1.Location = new Point(164, 20);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(121, 37);
            label1.TabIndex = 19;
            label1.Text = "Transfer";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(137, 207, 240);
            button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.Crimson;
            button2.Location = new Point(297, 17);
            button2.Name = "button2";
            button2.Size = new Size(125, 40);
            button2.TabIndex = 20;
            button2.Text = "Logout";
            button2.UseVisualStyleBackColor = false;
            button2.Click += btnLogout_Click;
            // 
            // TransferForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(434, 321);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(combobxRecipients);
            Controls.Add(lblRecipientAccount);
            Controls.Add(button1);
            Controls.Add(txtboxTransfer);
            Controls.Add(btnTransfer);
            Controls.Add(lblTransfer);
            Controls.Add(btnLogout);
            Controls.Add(lblBalance);
            Controls.Add(lbltxtBalance);
            Name = "TransferForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Transfer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblRecipientAccount;
        private ComboBox combobxRecipients;
        private Button btnTransfer;
        private TextBox txtboxTransfer;
        private Label lblTransfer;
        private Label lblBalance;
        private Label lbltxtBalance;
        private Button btnLogout;
        private Button button1;
        private Label label1;
        private Button button2;
    }
}
namespace ATMSimulationProject
{
    partial class WithdrawForm
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
            btnWithdraw = new Button();
            txtBoxWithdraw = new TextBox();
            lblWithdraw = new Label();
            lbltxtBalance = new Label();
            lblBalance = new Label();
            btnLogout = new Button();
            btnGoBack = new Button();
            cmbAccount = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnWithdraw
            // 
            btnWithdraw.BackColor = Color.FromArgb(137, 207, 240);
            btnWithdraw.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnWithdraw.ForeColor = Color.MediumBlue;
            btnWithdraw.Location = new Point(297, 223);
            btnWithdraw.Name = "btnWithdraw";
            btnWithdraw.Size = new Size(125, 40);
            btnWithdraw.TabIndex = 2;
            btnWithdraw.Text = "Withdraw";
            btnWithdraw.UseVisualStyleBackColor = false;
            btnWithdraw.Click += btnWithdraw_Click;
            // 
            // txtBoxWithdraw
            // 
            txtBoxWithdraw.BackColor = SystemColors.ScrollBar;
            txtBoxWithdraw.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxWithdraw.Location = new Point(64, 176);
            txtBoxWithdraw.Name = "txtBoxWithdraw";
            txtBoxWithdraw.Size = new Size(169, 33);
            txtBoxWithdraw.TabIndex = 1;
            // 
            // lblWithdraw
            // 
            lblWithdraw.AutoSize = true;
            lblWithdraw.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblWithdraw.ForeColor = Color.FromArgb(137, 207, 240);
            lblWithdraw.Location = new Point(24, 148);
            lblWithdraw.Name = "lblWithdraw";
            lblWithdraw.Size = new Size(253, 25);
            lblWithdraw.TabIndex = 0;
            lblWithdraw.Text = "Enter Amount to Withdraw";
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
            lbltxtBalance.TabIndex = 5;
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
            lblBalance.Size = new Size(100, 25);
            lblBalance.TabIndex = 6;
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
            // btnGoBack
            // 
            btnGoBack.BackColor = Color.FromArgb(137, 207, 240);
            btnGoBack.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnGoBack.ForeColor = Color.Crimson;
            btnGoBack.Location = new Point(297, 269);
            btnGoBack.Name = "btnGoBack";
            btnGoBack.Size = new Size(125, 40);
            btnGoBack.TabIndex = 11;
            btnGoBack.Text = "Go Back";
            btnGoBack.UseVisualStyleBackColor = false;
            btnGoBack.Click += btnGoBack_Click;
            // 
            // cmbAccount
            // 
            cmbAccount.FormattingEnabled = true;
            cmbAccount.Items.AddRange(new object[] { "Savings", "Chequing" });
            cmbAccount.Location = new Point(88, 91);
            cmbAccount.Name = "cmbAccount";
            cmbAccount.Size = new Size(121, 23);
            cmbAccount.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(137, 207, 240);
            label1.Location = new Point(64, 63);
            label1.Name = "label1";
            label1.Size = new Size(156, 25);
            label1.TabIndex = 13;
            label1.Text = "Choose Account";
            // 
            // WithdrawForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(434, 321);
            Controls.Add(label1);
            Controls.Add(cmbAccount);
            Controls.Add(btnGoBack);
            Controls.Add(lblWithdraw);
            Controls.Add(txtBoxWithdraw);
            Controls.Add(btnWithdraw);
            Controls.Add(btnLogout);
            Controls.Add(lblBalance);
            Controls.Add(lbltxtBalance);
            MinimizeBox = false;
            Name = "WithdrawForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WithdrawForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnWithdraw;
        private TextBox txtBoxWithdraw;
        private Label lblWithdraw;
        private Label lbltxtBalance;
        private Label lblBalance;
        private Button btnLogout;
        private Button btnGoBack;
        private ComboBox cmbAccount;
        private Label label1;
    }
}
namespace ATMSimulationProject
{
    partial class MainInterface
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
            lblBalance = new Label();
            lbltxtBalance = new Label();
            label1 = new Label();
            btnWithdraw = new Button();
            btnDeposit = new Button();
            btnTransfer = new Button();
            btnLogout = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // lblBalance
            // 
            lblBalance.BackColor = Color.MidnightBlue;
            lblBalance.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblBalance.ForeColor = Color.FromArgb(137, 207, 240);
            lblBalance.Location = new Point(12, 284);
            lblBalance.Name = "lblBalance";
            lblBalance.RightToLeft = RightToLeft.Yes;
            lblBalance.Size = new Size(100, 25);
            lblBalance.TabIndex = 9;
            lblBalance.Text = "0";
            lblBalance.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbltxtBalance
            // 
            lbltxtBalance.AutoSize = true;
            lbltxtBalance.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbltxtBalance.ForeColor = Color.FromArgb(137, 207, 240);
            lbltxtBalance.Location = new Point(12, 253);
            lbltxtBalance.Name = "lbltxtBalance";
            lbltxtBalance.RightToLeft = RightToLeft.Yes;
            lbltxtBalance.Size = new Size(88, 30);
            lbltxtBalance.TabIndex = 8;
            lbltxtBalance.Text = "Balance";
            lbltxtBalance.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.MidnightBlue;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(137, 207, 240);
            label1.Location = new Point(144, 9);
            label1.Name = "label1";
            label1.Size = new Size(119, 32);
            label1.TabIndex = 10;
            label1.Text = "Welcome";
            // 
            // btnWithdraw
            // 
            btnWithdraw.BackColor = Color.FromArgb(137, 207, 240);
            btnWithdraw.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnWithdraw.ForeColor = Color.MediumBlue;
            btnWithdraw.Location = new Point(95, 65);
            btnWithdraw.Name = "btnWithdraw";
            btnWithdraw.Size = new Size(225, 50);
            btnWithdraw.TabIndex = 11;
            btnWithdraw.Text = "Withdraw Funds";
            btnWithdraw.UseVisualStyleBackColor = false;
            btnWithdraw.Click += btnWithdraw_Click;
            // 
            // btnDeposit
            // 
            btnDeposit.BackColor = Color.FromArgb(137, 207, 240);
            btnDeposit.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnDeposit.ForeColor = Color.MediumBlue;
            btnDeposit.Location = new Point(95, 121);
            btnDeposit.Name = "btnDeposit";
            btnDeposit.Size = new Size(225, 50);
            btnDeposit.TabIndex = 12;
            btnDeposit.Text = "Deposit Cash/Cheque";
            btnDeposit.UseVisualStyleBackColor = false;
            btnDeposit.Click += btnDeposit_Click;
            // 
            // btnTransfer
            // 
            btnTransfer.BackColor = Color.FromArgb(137, 207, 240);
            btnTransfer.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnTransfer.ForeColor = Color.MediumBlue;
            btnTransfer.Location = new Point(95, 177);
            btnTransfer.Name = "btnTransfer";
            btnTransfer.Size = new Size(225, 50);
            btnTransfer.TabIndex = 13;
            btnTransfer.Text = "Transfer Funds";
            btnTransfer.UseVisualStyleBackColor = false;
            btnTransfer.Click += btnTransfer_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(137, 207, 240);
            btnLogout.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogout.ForeColor = Color.Crimson;
            btnLogout.Location = new Point(297, 269);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(125, 40);
            btnLogout.TabIndex = 14;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.MidnightBlue;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(137, 207, 240);
            label2.Location = new Point(93, 41);
            label2.Name = "label2";
            label2.Size = new Size(227, 21);
            label2.TabIndex = 15;
            label2.Text = "How may we help you today";
            // 
            // MainInterface
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(434, 321);
            Controls.Add(label2);
            Controls.Add(btnLogout);
            Controls.Add(btnTransfer);
            Controls.Add(btnDeposit);
            Controls.Add(btnWithdraw);
            Controls.Add(label1);
            Controls.Add(lblBalance);
            Controls.Add(lbltxtBalance);
            Name = "MainInterface";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainInterface";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBalance;
        private Label lbltxtBalance;
        private Label label1;
        private Button btnWithdraw;
        private Button btnDeposit;
        private Button btnTransfer;
        private Button btnLogout;
        private Label label2;
    }
}
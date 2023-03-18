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
            SuspendLayout();
            // 
            // lblBalance
            // 
            lblBalance.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblBalance.Location = new Point(126, 9);
            lblBalance.Name = "lblBalance";
            lblBalance.RightToLeft = RightToLeft.Yes;
            lblBalance.Size = new Size(96, 25);
            lblBalance.TabIndex = 9;
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
            lbltxtBalance.TabIndex = 8;
            lbltxtBalance.Text = "Balance";
            lbltxtBalance.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 49);
            label1.Name = "label1";
            label1.Size = new Size(207, 15);
            label1.TabIndex = 10;
            label1.Text = "Welcome, What would you like to do?";
            // 
            // btnWithdraw
            // 
            btnWithdraw.Location = new Point(12, 80);
            btnWithdraw.Name = "btnWithdraw";
            btnWithdraw.Size = new Size(207, 23);
            btnWithdraw.TabIndex = 11;
            btnWithdraw.Text = "Withdraw Funds";
            btnWithdraw.UseVisualStyleBackColor = true;
            btnWithdraw.Click += btnWithdraw_Click;
            // 
            // btnDeposit
            // 
            btnDeposit.Location = new Point(12, 109);
            btnDeposit.Name = "btnDeposit";
            btnDeposit.Size = new Size(207, 23);
            btnDeposit.TabIndex = 12;
            btnDeposit.Text = "Deposit Cash/Cheque";
            btnDeposit.UseVisualStyleBackColor = true;
            btnDeposit.Click += btnDeposit_Click;
            // 
            // btnTransfer
            // 
            btnTransfer.Location = new Point(12, 138);
            btnTransfer.Name = "btnTransfer";
            btnTransfer.Size = new Size(207, 23);
            btnTransfer.TabIndex = 13;
            btnTransfer.Text = "Transfer Funds";
            btnTransfer.UseVisualStyleBackColor = true;
            btnTransfer.Click += btnTransfer_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(12, 199);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(207, 23);
            btnLogout.TabIndex = 14;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // MainInterface
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(239, 234);
            Controls.Add(btnLogout);
            Controls.Add(btnTransfer);
            Controls.Add(btnDeposit);
            Controls.Add(btnWithdraw);
            Controls.Add(label1);
            Controls.Add(lblBalance);
            Controls.Add(lbltxtBalance);
            Name = "MainInterface";
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
    }
}
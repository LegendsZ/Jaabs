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
            grpboxWithdraw = new GroupBox();
            btnWithdraw = new Button();
            txtBoxWithdraw = new TextBox();
            lblWithdraw = new Label();
            lbltxtBalance = new Label();
            lblBalance = new Label();
            grpboxWithdraw.SuspendLayout();
            SuspendLayout();
            // 
            // grpboxWithdraw
            // 
            grpboxWithdraw.Controls.Add(btnWithdraw);
            grpboxWithdraw.Controls.Add(txtBoxWithdraw);
            grpboxWithdraw.Controls.Add(lblWithdraw);
            grpboxWithdraw.Location = new Point(12, 57);
            grpboxWithdraw.Name = "grpboxWithdraw";
            grpboxWithdraw.Size = new Size(200, 234);
            grpboxWithdraw.TabIndex = 4;
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
            // lbltxtBalance
            // 
            lbltxtBalance.AutoSize = true;
            lbltxtBalance.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbltxtBalance.Location = new Point(12, 9);
            lbltxtBalance.Name = "lbltxtBalance";
            lbltxtBalance.RightToLeft = RightToLeft.Yes;
            lbltxtBalance.Size = new Size(80, 25);
            lbltxtBalance.TabIndex = 5;
            lbltxtBalance.Text = "Balance";
            lbltxtBalance.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblBalance.Location = new Point(199, 9);
            lblBalance.Name = "lblBalance";
            lblBalance.RightToLeft = RightToLeft.Yes;
            lblBalance.Size = new Size(23, 25);
            lblBalance.TabIndex = 6;
            lblBalance.Text = "0";
            lblBalance.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // WithdrawForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(234, 303);
            Controls.Add(lblBalance);
            Controls.Add(lbltxtBalance);
            Controls.Add(grpboxWithdraw);
            MinimizeBox = false;
            Name = "WithdrawForm";
            Text = "WithdrawForm";
            grpboxWithdraw.ResumeLayout(false);
            grpboxWithdraw.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpboxWithdraw;
        private Button btnWithdraw;
        private TextBox txtBoxWithdraw;
        private Label lblWithdraw;
        private Label lbltxtBalance;
        private Label lblBalance;
    }
}
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
            this.lblRecipientAccount = new System.Windows.Forms.Label();
            this.combobxRecipients = new System.Windows.Forms.ComboBox();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.txtboxTransfer = new System.Windows.Forms.TextBox();
            this.lblTransfer = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRecipientAccount
            // 
            this.lblRecipientAccount.AutoSize = true;
            this.lblRecipientAccount.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRecipientAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(207)))), ((int)(((byte)(240)))));
            this.lblRecipientAccount.Location = new System.Drawing.Point(84, 159);
            this.lblRecipientAccount.Name = "lblRecipientAccount";
            this.lblRecipientAccount.Size = new System.Drawing.Size(173, 25);
            this.lblRecipientAccount.TabIndex = 6;
            this.lblRecipientAccount.Text = "Recipient Account";
            // 
            // combobxRecipients
            // 
            this.combobxRecipients.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.combobxRecipients.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.combobxRecipients.FormattingEnabled = true;
            this.combobxRecipients.Items.AddRange(new object[] {
            "Savings",
            "Chequing"});
            this.combobxRecipients.Location = new System.Drawing.Point(84, 187);
            this.combobxRecipients.Name = "combobxRecipients";
            this.combobxRecipients.Size = new System.Drawing.Size(169, 33);
            this.combobxRecipients.TabIndex = 5;
            // 
            // btnTransfer
            // 
            this.btnTransfer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(207)))), ((int)(((byte)(240)))));
            this.btnTransfer.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTransfer.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnTransfer.Location = new System.Drawing.Point(297, 223);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(125, 40);
            this.btnTransfer.TabIndex = 4;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.UseVisualStyleBackColor = false;
            // 
            // txtboxTransfer
            // 
            this.txtboxTransfer.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtboxTransfer.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtboxTransfer.Location = new System.Drawing.Point(84, 110);
            this.txtboxTransfer.Name = "txtboxTransfer";
            this.txtboxTransfer.Size = new System.Drawing.Size(169, 33);
            this.txtboxTransfer.TabIndex = 3;
            // 
            // lblTransfer
            // 
            this.lblTransfer.AutoSize = true;
            this.lblTransfer.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTransfer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(207)))), ((int)(((byte)(240)))));
            this.lblTransfer.Location = new System.Drawing.Point(47, 82);
            this.lblTransfer.Name = "lblTransfer";
            this.lblTransfer.Size = new System.Drawing.Size(239, 25);
            this.lblTransfer.TabIndex = 2;
            this.lblTransfer.Text = "Enter Amount to Transfer";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(18, 330);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(194, 23);
            this.btnLogout.TabIndex = 9;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(207)))), ((int)(((byte)(240)))));
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Crimson;
            this.button1.Location = new System.Drawing.Point(297, 269);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 40);
            this.button1.TabIndex = 18;
            this.button1.Text = "Go Back";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(207)))), ((int)(((byte)(240)))));
            this.label1.Location = new System.Drawing.Point(104, 35);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(121, 37);
            this.label1.TabIndex = 19;
            this.label1.Text = "Transfer";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(207)))), ((int)(((byte)(240)))));
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.Crimson;
            this.button2.Location = new System.Drawing.Point(297, 17);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 40);
            this.button2.TabIndex = 20;
            this.button2.Text = "Logout";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // TransferForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(434, 321);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combobxRecipients);
            this.Controls.Add(this.lblRecipientAccount);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtboxTransfer);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.lblTransfer);
            this.Controls.Add(this.btnLogout);
            this.Name = "TransferForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transfer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblRecipientAccount;
        private ComboBox combobxRecipients;
        private Button btnTransfer;
        private TextBox txtboxTransfer;
        private Label lblTransfer;
        private Button btnLogout;
        private Button button1;
        private Label label1;
        private Button button2;
    }
}
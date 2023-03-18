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
            grpboxDeposit = new GroupBox();
            grpboxType = new GroupBox();
            radioButton1 = new RadioButton();
            radiobtnCash = new RadioButton();
            btnDeposit = new Button();
            txtboxDeposit = new TextBox();
            lblDeposit = new Label();
            lbltxtBalance = new Label();
            lblBalance = new Label();
            btnLogout = new Button();
            grpboxDeposit.SuspendLayout();
            grpboxType.SuspendLayout();
            SuspendLayout();
            // 
            // grpboxDeposit
            // 
            grpboxDeposit.Controls.Add(grpboxType);
            grpboxDeposit.Controls.Add(btnDeposit);
            grpboxDeposit.Controls.Add(txtboxDeposit);
            grpboxDeposit.Controls.Add(lblDeposit);
            grpboxDeposit.Location = new Point(12, 54);
            grpboxDeposit.Name = "grpboxDeposit";
            grpboxDeposit.Size = new Size(200, 234);
            grpboxDeposit.TabIndex = 5;
            grpboxDeposit.TabStop = false;
            grpboxDeposit.Text = "Deposit";
            // 
            // grpboxType
            // 
            grpboxType.Controls.Add(radioButton1);
            grpboxType.Controls.Add(radiobtnCash);
            grpboxType.Location = new Point(7, 90);
            grpboxType.Name = "grpboxType";
            grpboxType.Size = new Size(179, 86);
            grpboxType.TabIndex = 4;
            grpboxType.TabStop = false;
            grpboxType.Text = "Type";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(11, 49);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(66, 19);
            radioButton1.TabIndex = 1;
            radioButton1.Text = "Cheque";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radiobtnCash
            // 
            radiobtnCash.AutoSize = true;
            radiobtnCash.Checked = true;
            radiobtnCash.Location = new Point(11, 24);
            radiobtnCash.Name = "radiobtnCash";
            radiobtnCash.Size = new Size(51, 19);
            radiobtnCash.TabIndex = 0;
            radiobtnCash.TabStop = true;
            radiobtnCash.Text = "Cash";
            radiobtnCash.UseVisualStyleBackColor = true;
            // 
            // btnDeposit
            // 
            btnDeposit.Location = new Point(6, 205);
            btnDeposit.Name = "btnDeposit";
            btnDeposit.Size = new Size(180, 23);
            btnDeposit.TabIndex = 3;
            btnDeposit.Text = "Deposit";
            btnDeposit.UseVisualStyleBackColor = true;
            btnDeposit.Click += btnDeposit_Click;
            // 
            // txtboxDeposit
            // 
            txtboxDeposit.Location = new Point(6, 47);
            txtboxDeposit.Name = "txtboxDeposit";
            txtboxDeposit.Size = new Size(180, 23);
            txtboxDeposit.TabIndex = 2;
            // 
            // lblDeposit
            // 
            lblDeposit.AutoSize = true;
            lblDeposit.Location = new Point(6, 23);
            lblDeposit.Name = "lblDeposit";
            lblDeposit.Size = new Size(138, 15);
            lblDeposit.TabIndex = 1;
            lblDeposit.Text = "Enter Amount to Deposit";
            // 
            // lbltxtBalance
            // 
            lbltxtBalance.AutoSize = true;
            lbltxtBalance.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbltxtBalance.Location = new Point(12, 9);
            lbltxtBalance.Name = "lbltxtBalance";
            lbltxtBalance.RightToLeft = RightToLeft.Yes;
            lbltxtBalance.Size = new Size(80, 25);
            lbltxtBalance.TabIndex = 6;
            lbltxtBalance.Text = "Balance";
            lbltxtBalance.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBalance
            // 
            lblBalance.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblBalance.Location = new Point(129, 9);
            lblBalance.Name = "lblBalance";
            lblBalance.RightToLeft = RightToLeft.Yes;
            lblBalance.Size = new Size(93, 25);
            lblBalance.TabIndex = 7;
            lblBalance.Text = "0";
            lblBalance.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(12, 305);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(200, 23);
            btnLogout.TabIndex = 10;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // DepositForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(234, 340);
            Controls.Add(btnLogout);
            Controls.Add(lblBalance);
            Controls.Add(lbltxtBalance);
            Controls.Add(grpboxDeposit);
            MaximizeBox = false;
            Name = "DepositForm";
            Text = "DepositForm";
            grpboxDeposit.ResumeLayout(false);
            grpboxDeposit.PerformLayout();
            grpboxType.ResumeLayout(false);
            grpboxType.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpboxDeposit;
        private GroupBox grpboxType;
        private RadioButton radioButton1;
        private RadioButton radiobtnCash;
        private Button btnDeposit;
        private TextBox txtboxDeposit;
        private Label lblDeposit;
        private Label lbltxtBalance;
        private Label lblBalance;
        private Button btnLogout;
    }
}
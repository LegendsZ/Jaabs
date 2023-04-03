namespace ATMSimulationProject
{
    partial class CheckBalance
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
            this.lblSavings = new System.Windows.Forms.Label();
            this.lblChequing = new System.Windows.Forms.Label();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSavings
            // 
            this.lblSavings.AutoSize = true;
            this.lblSavings.BackColor = System.Drawing.Color.MidnightBlue;
            this.lblSavings.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSavings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(207)))), ((int)(((byte)(240)))));
            this.lblSavings.Location = new System.Drawing.Point(72, 75);
            this.lblSavings.Name = "lblSavings";
            this.lblSavings.Size = new System.Drawing.Size(115, 32);
            this.lblSavings.TabIndex = 11;
            this.lblSavings.Text = "Savings: ";
            // 
            // lblChequing
            // 
            this.lblChequing.AutoSize = true;
            this.lblChequing.BackColor = System.Drawing.Color.MidnightBlue;
            this.lblChequing.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblChequing.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(207)))), ((int)(((byte)(240)))));
            this.lblChequing.Location = new System.Drawing.Point(72, 153);
            this.lblChequing.Name = "lblChequing";
            this.lblChequing.Size = new System.Drawing.Size(137, 32);
            this.lblChequing.TabIndex = 12;
            this.lblChequing.Text = "Chequing: ";
            // 
            // btnGoBack
            // 
            this.btnGoBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(207)))), ((int)(((byte)(240)))));
            this.btnGoBack.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGoBack.ForeColor = System.Drawing.Color.Crimson;
            this.btnGoBack.Location = new System.Drawing.Point(297, 269);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(125, 40);
            this.btnGoBack.TabIndex = 13;
            this.btnGoBack.Text = "Go Back";
            this.btnGoBack.UseVisualStyleBackColor = false;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // CheckBalance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(434, 321);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.lblChequing);
            this.Controls.Add(this.lblSavings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "CheckBalance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckBalance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblSavings;
        private Label lblChequing;
        private Button btnGoBack;
    }
}
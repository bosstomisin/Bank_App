
namespace NewBank.UI
{
    partial class Dashboard
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
            this.Statement_Of_account = new System.Windows.Forms.Button();
            this.Transfer = new System.Windows.Forms.Button();
            this.withdraw = new System.Windows.Forms.Button();
            this.Deposit_account = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Account_number = new System.Windows.Forms.Label();
            this.Description_text = new System.Windows.Forms.Label();
            this.Amount_text = new System.Windows.Forms.Label();
            this.accountNumTxt = new System.Windows.Forms.TextBox();
            this.amountTxt = new System.Windows.Forms.TextBox();
            this.descriptionTxt = new System.Windows.Forms.TextBox();
            this.Deposit_field = new System.Windows.Forms.Button();
            this.Logout = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Statement_Of_account
            // 
            this.Statement_Of_account.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Statement_Of_account.Location = new System.Drawing.Point(217, 1);
            this.Statement_Of_account.Name = "Statement_Of_account";
            this.Statement_Of_account.Size = new System.Drawing.Size(229, 47);
            this.Statement_Of_account.TabIndex = 6;
            this.Statement_Of_account.Text = "Statement of Account";
            this.Statement_Of_account.UseVisualStyleBackColor = true;
            this.Statement_Of_account.Click += new System.EventHandler(this.Statement_Of_account_Click);
            // 
            // Transfer
            // 
            this.Transfer.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Transfer.Location = new System.Drawing.Point(107, 0);
            this.Transfer.Name = "Transfer";
            this.Transfer.Size = new System.Drawing.Size(112, 47);
            this.Transfer.TabIndex = 4;
            this.Transfer.Text = "Transfer";
            this.Transfer.UseVisualStyleBackColor = true;
            this.Transfer.Click += new System.EventHandler(this.Transfer_Click);
            // 
            // withdraw
            // 
            this.withdraw.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.withdraw.Location = new System.Drawing.Point(445, 1);
            this.withdraw.Name = "withdraw";
            this.withdraw.Size = new System.Drawing.Size(153, 47);
            this.withdraw.TabIndex = 3;
            this.withdraw.Text = "Withdraw";
            this.withdraw.UseVisualStyleBackColor = true;
            this.withdraw.Click += new System.EventHandler(this.withdraw_Click);
            // 
            // Deposit_account
            // 
            this.Deposit_account.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Deposit_account.Location = new System.Drawing.Point(1, 0);
            this.Deposit_account.Name = "Deposit_account";
            this.Deposit_account.Size = new System.Drawing.Size(106, 47);
            this.Deposit_account.TabIndex = 2;
            this.Deposit_account.Text = "Deposit";
            this.Deposit_account.UseVisualStyleBackColor = true;
            this.Deposit_account.Click += new System.EventHandler(this.Deposit_account_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Logout);
            this.panel1.Controls.Add(this.Deposit_account);
            this.panel1.Controls.Add(this.withdraw);
            this.panel1.Controls.Add(this.Statement_Of_account);
            this.panel1.Controls.Add(this.Transfer);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(704, 48);
            this.panel1.TabIndex = 7;
            // 
            // Account_number
            // 
            this.Account_number.AutoSize = true;
            this.Account_number.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Account_number.ForeColor = System.Drawing.Color.White;
            this.Account_number.Location = new System.Drawing.Point(94, 149);
            this.Account_number.Name = "Account_number";
            this.Account_number.Size = new System.Drawing.Size(179, 24);
            this.Account_number.TabIndex = 8;
            this.Account_number.Text = "Account Number";
            // 
            // Description_text
            // 
            this.Description_text.AutoSize = true;
            this.Description_text.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Description_text.ForeColor = System.Drawing.Color.White;
            this.Description_text.Location = new System.Drawing.Point(94, 314);
            this.Description_text.Name = "Description_text";
            this.Description_text.Size = new System.Drawing.Size(125, 24);
            this.Description_text.TabIndex = 9;
            this.Description_text.Text = "Description";
            // 
            // Amount_text
            // 
            this.Amount_text.AutoSize = true;
            this.Amount_text.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Amount_text.ForeColor = System.Drawing.Color.White;
            this.Amount_text.Location = new System.Drawing.Point(94, 223);
            this.Amount_text.Name = "Amount_text";
            this.Amount_text.Size = new System.Drawing.Size(89, 24);
            this.Amount_text.TabIndex = 10;
            this.Amount_text.Text = "Amount";
            // 
            // accountNumTxt
            // 
            this.accountNumTxt.Location = new System.Drawing.Point(284, 146);
            this.accountNumTxt.Name = "accountNumTxt";
            this.accountNumTxt.Size = new System.Drawing.Size(279, 31);
            this.accountNumTxt.TabIndex = 11;
            // 
            // amountTxt
            // 
            this.amountTxt.Location = new System.Drawing.Point(284, 223);
            this.amountTxt.Name = "amountTxt";
            this.amountTxt.Size = new System.Drawing.Size(279, 31);
            this.amountTxt.TabIndex = 12;
            // 
            // descriptionTxt
            // 
            this.descriptionTxt.Location = new System.Drawing.Point(284, 299);
            this.descriptionTxt.Name = "descriptionTxt";
            this.descriptionTxt.Size = new System.Drawing.Size(279, 31);
            this.descriptionTxt.TabIndex = 13;
            // 
            // Deposit_field
            // 
            this.Deposit_field.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Deposit_field.Location = new System.Drawing.Point(317, 423);
            this.Deposit_field.Name = "Deposit_field";
            this.Deposit_field.Size = new System.Drawing.Size(112, 34);
            this.Deposit_field.TabIndex = 14;
            this.Deposit_field.Text = "Deposit";
            this.Deposit_field.UseVisualStyleBackColor = true;
            this.Deposit_field.Click += new System.EventHandler(this.Deposit_field_Click);
            // 
            // Logout
            // 
            this.Logout.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Logout.Location = new System.Drawing.Point(596, 0);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(106, 48);
            this.Logout.TabIndex = 15;
            this.Logout.Text = "LogOut";
            this.Logout.UseVisualStyleBackColor = true;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.ClientSize = new System.Drawing.Size(705, 533);
            this.Controls.Add(this.Deposit_field);
            this.Controls.Add(this.descriptionTxt);
            this.Controls.Add(this.amountTxt);
            this.Controls.Add(this.accountNumTxt);
            this.Controls.Add(this.Amount_text);
            this.Controls.Add(this.Description_text);
            this.Controls.Add(this.Account_number);
            this.Controls.Add(this.panel1);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Statement_Of_account;
        private System.Windows.Forms.Button Transfer;
        private System.Windows.Forms.Button withdraw;
        private System.Windows.Forms.Button Deposit_account;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Account_number;
        private System.Windows.Forms.Label Description_text;
        private System.Windows.Forms.Label Amount_text;
        private System.Windows.Forms.TextBox accountNumTxt;
        private System.Windows.Forms.TextBox amountTxt;
        private System.Windows.Forms.TextBox descriptionTxt;
        private System.Windows.Forms.Button Deposit_field;
        private System.Windows.Forms.Button Logout;
    }
}

namespace NewBank.UI
{
    partial class StatementOfAccount
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Logout = new System.Windows.Forms.Button();
            this.Deposit = new System.Windows.Forms.Button();
            this.Statement_of_account = new System.Windows.Forms.Button();
            this.Transfer = new System.Windows.Forms.Button();
            this.withdraw = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.AccountNoField = new System.Windows.Forms.TextBox();
            this.displayTransaction = new System.Windows.Forms.DataGridView();
            this.GetTrans = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.displayTransaction)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SaddleBrown;
            this.panel1.Controls.Add(this.Logout);
            this.panel1.Controls.Add(this.Deposit);
            this.panel1.Controls.Add(this.Statement_of_account);
            this.panel1.Controls.Add(this.Transfer);
            this.panel1.Controls.Add(this.withdraw);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 45);
            this.panel1.TabIndex = 0;
            // 
            // Logout
            // 
            this.Logout.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Logout.Location = new System.Drawing.Point(701, 1);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(98, 44);
            this.Logout.TabIndex = 4;
            this.Logout.Text = "LogOut";
            this.Logout.UseVisualStyleBackColor = true;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // Deposit
            // 
            this.Deposit.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Deposit.Location = new System.Drawing.Point(182, 0);
            this.Deposit.Name = "Deposit";
            this.Deposit.Size = new System.Drawing.Size(98, 44);
            this.Deposit.TabIndex = 2;
            this.Deposit.Text = "Deposit";
            this.Deposit.UseVisualStyleBackColor = true;
            this.Deposit.Click += new System.EventHandler(this.Deposit_Click);
            // 
            // Statement_of_account
            // 
            this.Statement_of_account.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Statement_of_account.Location = new System.Drawing.Point(376, 1);
            this.Statement_of_account.Name = "Statement_of_account";
            this.Statement_of_account.Size = new System.Drawing.Size(217, 44);
            this.Statement_of_account.TabIndex = 2;
            this.Statement_of_account.Text = "Statement Of Account";
            this.Statement_of_account.UseVisualStyleBackColor = true;
            this.Statement_of_account.Click += new System.EventHandler(this.Statement_of_account_Click);
            // 
            // Transfer
            // 
            this.Transfer.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Transfer.Location = new System.Drawing.Point(279, 1);
            this.Transfer.Name = "Transfer";
            this.Transfer.Size = new System.Drawing.Size(98, 44);
            this.Transfer.TabIndex = 1;
            this.Transfer.Text = "Tranfer";
            this.Transfer.UseVisualStyleBackColor = true;
            this.Transfer.Click += new System.EventHandler(this.Transfer_Click);
            // 
            // withdraw
            // 
            this.withdraw.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.withdraw.Location = new System.Drawing.Point(593, 0);
            this.withdraw.Name = "withdraw";
            this.withdraw.Size = new System.Drawing.Size(109, 44);
            this.withdraw.TabIndex = 3;
            this.withdraw.Text = "Withdraw";
            this.withdraw.UseVisualStyleBackColor = true;
            this.withdraw.Click += new System.EventHandler(this.withdraw_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(0, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Account";
            // 
            // AccountNoField
            // 
            this.AccountNoField.Location = new System.Drawing.Point(81, 52);
            this.AccountNoField.Name = "AccountNoField";
            this.AccountNoField.Size = new System.Drawing.Size(184, 31);
            this.AccountNoField.TabIndex = 2;
            // 
            // displayTransaction
            // 
            this.displayTransaction.AllowUserToAddRows = false;
            this.displayTransaction.AllowUserToDeleteRows = false;
            this.displayTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.displayTransaction.Location = new System.Drawing.Point(0, 89);
            this.displayTransaction.Name = "displayTransaction";
            this.displayTransaction.ReadOnly = true;
            this.displayTransaction.RowHeadersWidth = 62;
            this.displayTransaction.RowTemplate.Height = 33;
            this.displayTransaction.Size = new System.Drawing.Size(799, 277);
            this.displayTransaction.TabIndex = 3;
            // 
            // GetTrans
            // 
            this.GetTrans.Location = new System.Drawing.Point(636, 401);
            this.GetTrans.Name = "GetTrans";
            this.GetTrans.Size = new System.Drawing.Size(112, 34);
            this.GetTrans.TabIndex = 4;
            this.GetTrans.Text = "Enter";
            this.GetTrans.UseVisualStyleBackColor = true;
            this.GetTrans.Click += new System.EventHandler(this.GetTrans_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, -136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 25);
            this.label2.TabIndex = 5;
            // 
            // StatementOfAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GetTrans);
            this.Controls.Add(this.displayTransaction);
            this.Controls.Add(this.AccountNoField);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "StatementOfAccount";
            this.Text = "StatementOfAccount";
            this.Load += new System.EventHandler(this.StatementOfAccount_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.displayTransaction)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Transfer;
        private System.Windows.Forms.Button Statement_of_account;
        private System.Windows.Forms.Button withdraw;
        private System.Windows.Forms.Button Deposit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AccountNoField;
        private System.Windows.Forms.DataGridView displayTransaction;
        private System.Windows.Forms.Button GetTrans;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.Label label2;
    }
}

namespace NewBank.UI
{
    partial class Transfer
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
            this.Credit_acc_text = new System.Windows.Forms.Label();
            this.Description_text = new System.Windows.Forms.Label();
            this.Amount_text = new System.Windows.Forms.Label();
            this.Debit_num_text = new System.Windows.Forms.Label();
            this.credit_text_field = new System.Windows.Forms.TextBox();
            this.Debit_text_field = new System.Windows.Forms.TextBox();
            this.Amount_field = new System.Windows.Forms.TextBox();
            this.Description_field = new System.Windows.Forms.TextBox();
            this.Transfer_field = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.deposit = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.statement_of_account = new System.Windows.Forms.Button();
            this.Withdraw = new System.Windows.Forms.Button();
            this.Logout = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Credit_acc_text
            // 
            this.Credit_acc_text.AutoSize = true;
            this.Credit_acc_text.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Credit_acc_text.ForeColor = System.Drawing.Color.White;
            this.Credit_acc_text.Location = new System.Drawing.Point(67, 142);
            this.Credit_acc_text.Name = "Credit_acc_text";
            this.Credit_acc_text.Size = new System.Drawing.Size(246, 24);
            this.Credit_acc_text.TabIndex = 0;
            this.Credit_acc_text.Text = "Credit Account Number";
            this.Credit_acc_text.Click += new System.EventHandler(this.label1_Click);
            // 
            // Description_text
            // 
            this.Description_text.AutoSize = true;
            this.Description_text.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Description_text.ForeColor = System.Drawing.Color.White;
            this.Description_text.Location = new System.Drawing.Point(67, 407);
            this.Description_text.Name = "Description_text";
            this.Description_text.Size = new System.Drawing.Size(125, 24);
            this.Description_text.TabIndex = 1;
            this.Description_text.Text = "Description";
            // 
            // Amount_text
            // 
            this.Amount_text.AutoSize = true;
            this.Amount_text.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Amount_text.ForeColor = System.Drawing.Color.White;
            this.Amount_text.Location = new System.Drawing.Point(67, 324);
            this.Amount_text.Name = "Amount_text";
            this.Amount_text.Size = new System.Drawing.Size(89, 24);
            this.Amount_text.TabIndex = 2;
            this.Amount_text.Text = "Amount";
            // 
            // Debit_num_text
            // 
            this.Debit_num_text.AutoSize = true;
            this.Debit_num_text.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Debit_num_text.ForeColor = System.Drawing.Color.White;
            this.Debit_num_text.Location = new System.Drawing.Point(67, 246);
            this.Debit_num_text.Name = "Debit_num_text";
            this.Debit_num_text.Size = new System.Drawing.Size(239, 24);
            this.Debit_num_text.TabIndex = 3;
            this.Debit_num_text.Text = "Debit Account Number";
            // 
            // credit_text_field
            // 
            this.credit_text_field.Location = new System.Drawing.Point(404, 142);
            this.credit_text_field.Name = "credit_text_field";
            this.credit_text_field.Size = new System.Drawing.Size(238, 31);
            this.credit_text_field.TabIndex = 4;
            this.credit_text_field.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Debit_text_field
            // 
            this.Debit_text_field.Location = new System.Drawing.Point(404, 239);
            this.Debit_text_field.Name = "Debit_text_field";
            this.Debit_text_field.Size = new System.Drawing.Size(238, 31);
            this.Debit_text_field.TabIndex = 5;
            this.Debit_text_field.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Amount_field
            // 
            this.Amount_field.Location = new System.Drawing.Point(404, 324);
            this.Amount_field.Name = "Amount_field";
            this.Amount_field.Size = new System.Drawing.Size(238, 31);
            this.Amount_field.TabIndex = 6;
            // 
            // Description_field
            // 
            this.Description_field.Location = new System.Drawing.Point(404, 407);
            this.Description_field.Name = "Description_field";
            this.Description_field.Size = new System.Drawing.Size(238, 31);
            this.Description_field.TabIndex = 7;
            // 
            // Transfer_field
            // 
            this.Transfer_field.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Transfer_field.Location = new System.Drawing.Point(256, 471);
            this.Transfer_field.Name = "Transfer_field";
            this.Transfer_field.Size = new System.Drawing.Size(112, 34);
            this.Transfer_field.TabIndex = 8;
            this.Transfer_field.Text = "Transfer";
            this.Transfer_field.UseVisualStyleBackColor = true;
            this.Transfer_field.Click += new System.EventHandler(this.Transfer_field_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Logout);
            this.panel1.Controls.Add(this.deposit);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.statement_of_account);
            this.panel1.Controls.Add(this.Withdraw);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(704, 59);
            this.panel1.TabIndex = 9;
            // 
            // deposit
            // 
            this.deposit.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deposit.Location = new System.Drawing.Point(67, 0);
            this.deposit.Name = "deposit";
            this.deposit.Size = new System.Drawing.Size(111, 57);
            this.deposit.TabIndex = 13;
            this.deposit.Text = "Deposit";
            this.deposit.UseVisualStyleBackColor = true;
            this.deposit.Click += new System.EventHandler(this.deposit_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(177, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 57);
            this.button2.TabIndex = 12;
            this.button2.Text = "Transfer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // statement_of_account
            // 
            this.statement_of_account.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.statement_of_account.Location = new System.Drawing.Point(285, 0);
            this.statement_of_account.Name = "statement_of_account";
            this.statement_of_account.Size = new System.Drawing.Size(217, 57);
            this.statement_of_account.TabIndex = 11;
            this.statement_of_account.Text = "Statement of Account";
            this.statement_of_account.UseVisualStyleBackColor = true;
            this.statement_of_account.Click += new System.EventHandler(this.button3_Click);
            // 
            // Withdraw
            // 
            this.Withdraw.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Withdraw.Location = new System.Drawing.Point(499, 0);
            this.Withdraw.Name = "Withdraw";
            this.Withdraw.Size = new System.Drawing.Size(111, 57);
            this.Withdraw.TabIndex = 10;
            this.Withdraw.Text = "Withdraw";
            this.Withdraw.UseVisualStyleBackColor = true;
            this.Withdraw.Click += new System.EventHandler(this.Withdraw_Click);
            // 
            // Logout
            // 
            this.Logout.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Logout.Location = new System.Drawing.Point(606, 0);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(98, 57);
            this.Logout.TabIndex = 10;
            this.Logout.Text = "LogOut";
            this.Logout.UseVisualStyleBackColor = true;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // Transfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.ClientSize = new System.Drawing.Size(705, 533);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Transfer_field);
            this.Controls.Add(this.Description_field);
            this.Controls.Add(this.Amount_field);
            this.Controls.Add(this.Debit_text_field);
            this.Controls.Add(this.credit_text_field);
            this.Controls.Add(this.Debit_num_text);
            this.Controls.Add(this.Amount_text);
            this.Controls.Add(this.Description_text);
            this.Controls.Add(this.Credit_acc_text);
            this.Name = "Transfer";
            this.Text = "Transfer";
            this.Load += new System.EventHandler(this.Transfer_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Credit_acc_text;
        private System.Windows.Forms.Label Description_text;
        private System.Windows.Forms.Label Amount_text;
        private System.Windows.Forms.Label Debit_num_text;
        private System.Windows.Forms.TextBox credit_text_field;
        private System.Windows.Forms.TextBox Debit_text_field;
        private System.Windows.Forms.TextBox Amount_field;
        private System.Windows.Forms.TextBox Description_field;
        private System.Windows.Forms.Button Transfer_field;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button deposit;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button statement_of_account;
        private System.Windows.Forms.Button Withdraw;
        private System.Windows.Forms.Button Logout;
    }
}
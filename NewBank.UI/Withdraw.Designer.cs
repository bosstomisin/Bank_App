
namespace NewBank.UI
{
    partial class Withdraw
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
            this.Account_number_txt = new System.Windows.Forms.Label();
            this.Account_number_field = new System.Windows.Forms.TextBox();
            this.Amount_txt = new System.Windows.Forms.Label();
            this.Amount_txt_field = new System.Windows.Forms.TextBox();
            this.Description_text = new System.Windows.Forms.Label();
            this.Description_txt_field = new System.Windows.Forms.TextBox();
            this.Withdraw_field = new System.Windows.Forms.Button();
            this.Withdrw = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Deposit_button = new System.Windows.Forms.Button();
            this.Transfer_button = new System.Windows.Forms.Button();
            this.Statement_button = new System.Windows.Forms.Button();
            this.Logout = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Account_number_txt
            // 
            this.Account_number_txt.AutoSize = true;
            this.Account_number_txt.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Account_number_txt.ForeColor = System.Drawing.Color.White;
            this.Account_number_txt.Location = new System.Drawing.Point(89, 202);
            this.Account_number_txt.Name = "Account_number_txt";
            this.Account_number_txt.Size = new System.Drawing.Size(177, 24);
            this.Account_number_txt.TabIndex = 0;
            this.Account_number_txt.Text = "Account number";
            this.Account_number_txt.Click += new System.EventHandler(this.Account_number_txt_Click);
            // 
            // Account_number_field
            // 
            this.Account_number_field.Location = new System.Drawing.Point(270, 195);
            this.Account_number_field.Name = "Account_number_field";
            this.Account_number_field.Size = new System.Drawing.Size(223, 31);
            this.Account_number_field.TabIndex = 1;
            this.Account_number_field.TextChanged += new System.EventHandler(this.Account_number_field_TextChanged);
            // 
            // Amount_txt
            // 
            this.Amount_txt.AutoSize = true;
            this.Amount_txt.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Amount_txt.ForeColor = System.Drawing.Color.White;
            this.Amount_txt.Location = new System.Drawing.Point(89, 287);
            this.Amount_txt.Name = "Amount_txt";
            this.Amount_txt.Size = new System.Drawing.Size(89, 24);
            this.Amount_txt.TabIndex = 2;
            this.Amount_txt.Text = "Amount";
            this.Amount_txt.Click += new System.EventHandler(this.Amount_txt_Click);
            // 
            // Amount_txt_field
            // 
            this.Amount_txt_field.Location = new System.Drawing.Point(270, 284);
            this.Amount_txt_field.Name = "Amount_txt_field";
            this.Amount_txt_field.Size = new System.Drawing.Size(222, 31);
            this.Amount_txt_field.TabIndex = 3;
            this.Amount_txt_field.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Description_text
            // 
            this.Description_text.AutoSize = true;
            this.Description_text.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Description_text.ForeColor = System.Drawing.Color.White;
            this.Description_text.Location = new System.Drawing.Point(89, 355);
            this.Description_text.Name = "Description_text";
            this.Description_text.Size = new System.Drawing.Size(125, 24);
            this.Description_text.TabIndex = 4;
            this.Description_text.Text = "Description";
            this.Description_text.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.Description_text.Click += new System.EventHandler(this.Description_text_Click);
            // 
            // Description_txt_field
            // 
            this.Description_txt_field.Location = new System.Drawing.Point(270, 352);
            this.Description_txt_field.Name = "Description_txt_field";
            this.Description_txt_field.Size = new System.Drawing.Size(218, 31);
            this.Description_txt_field.TabIndex = 5;
            this.Description_txt_field.TextChanged += new System.EventHandler(this.Description_txt_field_TextChanged);
            // 
            // Withdraw_field
            // 
            this.Withdraw_field.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Withdraw_field.Location = new System.Drawing.Point(301, 423);
            this.Withdraw_field.Name = "Withdraw_field";
            this.Withdraw_field.Size = new System.Drawing.Size(143, 47);
            this.Withdraw_field.TabIndex = 6;
            this.Withdraw_field.Text = "Withraw";
            this.Withdraw_field.UseVisualStyleBackColor = true;
            this.Withdraw_field.Click += new System.EventHandler(this.Withdraw_field_Click);
            // 
            // Withdrw
            // 
            this.Withdrw.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Withdrw.Location = new System.Drawing.Point(489, 0);
            this.Withdrw.Name = "Withdrw";
            this.Withdrw.Size = new System.Drawing.Size(122, 45);
            this.Withdrw.TabIndex = 7;
            this.Withdrw.Text = "Withdraw";
            this.Withdrw.UseVisualStyleBackColor = true;
            this.Withdrw.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.Logout);
            this.panel1.Controls.Add(this.Deposit_button);
            this.panel1.Controls.Add(this.Transfer_button);
            this.panel1.Controls.Add(this.Withdrw);
            this.panel1.Controls.Add(this.Statement_button);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(705, 45);
            this.panel1.TabIndex = 8;
            // 
            // Deposit_button
            // 
            this.Deposit_button.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Deposit_button.Location = new System.Drawing.Point(1, -1);
            this.Deposit_button.Name = "Deposit_button";
            this.Deposit_button.Size = new System.Drawing.Size(117, 47);
            this.Deposit_button.TabIndex = 9;
            this.Deposit_button.Text = "Deposit";
            this.Deposit_button.UseVisualStyleBackColor = true;
            this.Deposit_button.Click += new System.EventHandler(this.Deposit_button_Click);
            // 
            // Transfer_button
            // 
            this.Transfer_button.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Transfer_button.Location = new System.Drawing.Point(116, -1);
            this.Transfer_button.Name = "Transfer_button";
            this.Transfer_button.Size = new System.Drawing.Size(139, 47);
            this.Transfer_button.TabIndex = 11;
            this.Transfer_button.Text = "Transfer";
            this.Transfer_button.UseVisualStyleBackColor = true;
            this.Transfer_button.Click += new System.EventHandler(this.button4_Click);
            // 
            // Statement_button
            // 
            this.Statement_button.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Statement_button.Location = new System.Drawing.Point(252, -1);
            this.Statement_button.Name = "Statement_button";
            this.Statement_button.Size = new System.Drawing.Size(244, 47);
            this.Statement_button.TabIndex = 10;
            this.Statement_button.Text = "Statement of Account";
            this.Statement_button.UseVisualStyleBackColor = true;
            this.Statement_button.Click += new System.EventHandler(this.Statement_button_Click);
            // 
            // Logout
            // 
            this.Logout.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Logout.Location = new System.Drawing.Point(598, 0);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(106, 44);
            this.Logout.TabIndex = 9;
            this.Logout.Text = "LogOut";
            this.Logout.UseVisualStyleBackColor = true;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // Withdraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.ClientSize = new System.Drawing.Size(705, 533);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Withdraw_field);
            this.Controls.Add(this.Description_txt_field);
            this.Controls.Add(this.Description_text);
            this.Controls.Add(this.Amount_txt_field);
            this.Controls.Add(this.Amount_txt);
            this.Controls.Add(this.Account_number_field);
            this.Controls.Add(this.Account_number_txt);
            this.Name = "Withdraw";
            this.Text = "Withdraw";
            this.Load += new System.EventHandler(this.Withdraw_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Account_number_txt;
        private System.Windows.Forms.TextBox Account_number_field;
        private System.Windows.Forms.Label Amount_txt;
        private System.Windows.Forms.TextBox Amount_txt_field;
        private System.Windows.Forms.Label Description_text;
        private System.Windows.Forms.TextBox Description_txt_field;
        private System.Windows.Forms.Button Withdraw_field;
        private System.Windows.Forms.Button Withdrw;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Deposit_button;
        private System.Windows.Forms.Button Statement_button;
        private System.Windows.Forms.Button Transfer_button;
        private System.Windows.Forms.Button Logout;
    }
}
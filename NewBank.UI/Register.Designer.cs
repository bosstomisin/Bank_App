
namespace NewBank.UI
{
    partial class Register
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
            this.Firstname_txt = new System.Windows.Forms.Label();
            this.Lastname_txt = new System.Windows.Forms.Label();
            this.Email_text = new System.Windows.Forms.Label();
            this.Firstname_text_field = new System.Windows.Forms.TextBox();
            this.Lastname_txt_field = new System.Windows.Forms.TextBox();
            this.Email_txt_field = new System.Windows.Forms.TextBox();
            this.pin_text = new System.Windows.Forms.Label();
            this.Pin_txt_field = new System.Windows.Forms.TextBox();
            this.Register_field = new System.Windows.Forms.Button();
            this.Account_type = new System.Windows.Forms.Label();
            this.Current_account = new System.Windows.Forms.RadioButton();
            this.Savings_account = new System.Windows.Forms.RadioButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Firstname_txt
            // 
            this.Firstname_txt.AutoSize = true;
            this.Firstname_txt.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Firstname_txt.ForeColor = System.Drawing.Color.Transparent;
            this.Firstname_txt.Location = new System.Drawing.Point(91, 138);
            this.Firstname_txt.Name = "Firstname_txt";
            this.Firstname_txt.Size = new System.Drawing.Size(119, 24);
            this.Firstname_txt.TabIndex = 0;
            this.Firstname_txt.Text = "First Name";
            this.Firstname_txt.Click += new System.EventHandler(this.Firstname_txt_Click);
            // 
            // Lastname_txt
            // 
            this.Lastname_txt.AutoSize = true;
            this.Lastname_txt.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lastname_txt.ForeColor = System.Drawing.Color.Transparent;
            this.Lastname_txt.Location = new System.Drawing.Point(91, 186);
            this.Lastname_txt.Name = "Lastname_txt";
            this.Lastname_txt.Size = new System.Drawing.Size(115, 24);
            this.Lastname_txt.TabIndex = 1;
            this.Lastname_txt.Text = "Last Name";
            this.Lastname_txt.Click += new System.EventHandler(this.Lastname_txt_Click);
            // 
            // Email_text
            // 
            this.Email_text.AutoSize = true;
            this.Email_text.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Email_text.ForeColor = System.Drawing.Color.Transparent;
            this.Email_text.Location = new System.Drawing.Point(86, 247);
            this.Email_text.Name = "Email_text";
            this.Email_text.Size = new System.Drawing.Size(152, 24);
            this.Email_text.TabIndex = 2;
            this.Email_text.Text = "Email Address";
            this.Email_text.Click += new System.EventHandler(this.Email_text_Click);
            // 
            // Firstname_text_field
            // 
            this.Firstname_text_field.Location = new System.Drawing.Point(321, 131);
            this.Firstname_text_field.Name = "Firstname_text_field";
            this.Firstname_text_field.Size = new System.Drawing.Size(225, 31);
            this.Firstname_text_field.TabIndex = 3;
            this.Firstname_text_field.TextChanged += new System.EventHandler(this.Firstname_text_field_TextChanged);
            // 
            // Lastname_txt_field
            // 
            this.Lastname_txt_field.Location = new System.Drawing.Point(321, 179);
            this.Lastname_txt_field.Name = "Lastname_txt_field";
            this.Lastname_txt_field.Size = new System.Drawing.Size(225, 31);
            this.Lastname_txt_field.TabIndex = 4;
            this.Lastname_txt_field.TextChanged += new System.EventHandler(this.Lastname_txt_field_TextChanged);
            // 
            // Email_txt_field
            // 
            this.Email_txt_field.Location = new System.Drawing.Point(321, 247);
            this.Email_txt_field.Name = "Email_txt_field";
            this.Email_txt_field.Size = new System.Drawing.Size(225, 31);
            this.Email_txt_field.TabIndex = 5;
            this.Email_txt_field.TextChanged += new System.EventHandler(this.Email_txt_field_TextChanged);
            // 
            // pin_text
            // 
            this.pin_text.AutoSize = true;
            this.pin_text.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pin_text.ForeColor = System.Drawing.Color.Transparent;
            this.pin_text.Location = new System.Drawing.Point(91, 302);
            this.pin_text.Name = "pin_text";
            this.pin_text.Size = new System.Drawing.Size(42, 24);
            this.pin_text.TabIndex = 6;
            this.pin_text.Text = "Pin";
            this.pin_text.Click += new System.EventHandler(this.pin_text_Click);
            // 
            // Pin_txt_field
            // 
            this.Pin_txt_field.Location = new System.Drawing.Point(321, 295);
            this.Pin_txt_field.Name = "Pin_txt_field";
            this.Pin_txt_field.Size = new System.Drawing.Size(225, 31);
            this.Pin_txt_field.TabIndex = 7;
            this.Pin_txt_field.TextChanged += new System.EventHandler(this.Pin_txt_field_TextChanged);
            // 
            // Register_field
            // 
            this.Register_field.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Register_field.Location = new System.Drawing.Point(258, 476);
            this.Register_field.Name = "Register_field";
            this.Register_field.Size = new System.Drawing.Size(154, 45);
            this.Register_field.TabIndex = 8;
            this.Register_field.Text = "Register";
            this.Register_field.UseVisualStyleBackColor = true;
            this.Register_field.Click += new System.EventHandler(this.Register_field_Click);
            // 
            // Account_type
            // 
            this.Account_type.AutoSize = true;
            this.Account_type.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Account_type.ForeColor = System.Drawing.Color.Transparent;
            this.Account_type.Location = new System.Drawing.Point(36, 24);
            this.Account_type.Name = "Account_type";
            this.Account_type.Size = new System.Drawing.Size(147, 24);
            this.Account_type.TabIndex = 9;
            this.Account_type.Text = "Account Type";
            this.Account_type.Click += new System.EventHandler(this.Account_type_Click);
            // 
            // Current_account
            // 
            this.Current_account.AutoSize = true;
            this.Current_account.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Current_account.ForeColor = System.Drawing.Color.Transparent;
            this.Current_account.Location = new System.Drawing.Point(259, 24);
            this.Current_account.Name = "Current_account";
            this.Current_account.Size = new System.Drawing.Size(112, 28);
            this.Current_account.TabIndex = 10;
            this.Current_account.TabStop = true;
            this.Current_account.Text = "Current";
            this.Current_account.UseVisualStyleBackColor = true;
            this.Current_account.CheckedChanged += new System.EventHandler(this.Current_account_CheckedChanged);
            // 
            // Savings_account
            // 
            this.Savings_account.AutoSize = true;
            this.Savings_account.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Savings_account.ForeColor = System.Drawing.Color.Transparent;
            this.Savings_account.Location = new System.Drawing.Point(471, 22);
            this.Savings_account.Name = "Savings_account";
            this.Savings_account.Size = new System.Drawing.Size(114, 28);
            this.Savings_account.TabIndex = 11;
            this.Savings_account.TabStop = true;
            this.Savings_account.Text = "Savings";
            this.Savings_account.UseVisualStyleBackColor = true;
            this.Savings_account.CheckedChanged += new System.EventHandler(this.Savings_account_CheckedChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Showcard Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBox1.Location = new System.Drawing.Point(-1, -2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(782, 70);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "WELCOME TO AFB BANK";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Peru;
            this.panel2.Controls.Add(this.Account_type);
            this.panel2.Controls.Add(this.Current_account);
            this.panel2.Controls.Add(this.Savings_account);
            this.panel2.Location = new System.Drawing.Point(-1, 349);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(782, 73);
            this.panel2.TabIndex = 14;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(219, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(327, 29);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = " ...a bank you can always trust";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.ClientSize = new System.Drawing.Size(778, 533);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Register_field);
            this.Controls.Add(this.Pin_txt_field);
            this.Controls.Add(this.pin_text);
            this.Controls.Add(this.Email_txt_field);
            this.Controls.Add(this.Lastname_txt_field);
            this.Controls.Add(this.Firstname_text_field);
            this.Controls.Add(this.Email_text);
            this.Controls.Add(this.Lastname_txt);
            this.Controls.Add(this.Firstname_txt);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Register";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Firstname_txt;
        private System.Windows.Forms.Label Lastname_txt;
        private System.Windows.Forms.Label Email_text;
        private System.Windows.Forms.TextBox Firstname_text_field;
        private System.Windows.Forms.TextBox Lastname_txt_field;
        private System.Windows.Forms.TextBox Email_txt_field;
        private System.Windows.Forms.Label pin_text;
        private System.Windows.Forms.TextBox Pin_txt_field;
        private System.Windows.Forms.Button Register_field;
        private System.Windows.Forms.Label Account_type;
        private System.Windows.Forms.RadioButton Current_account;
        private System.Windows.Forms.RadioButton Savings_account;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox1;
    }
}
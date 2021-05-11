
namespace NewBank.UI
{
    partial class Login
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
            this.Login_email = new System.Windows.Forms.Label();
            this.Pin_login = new System.Windows.Forms.Label();
            this.Login_user = new System.Windows.Forms.Button();
            this.Login_email_field = new System.Windows.Forms.TextBox();
            this.Pin_login_field = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Login_email
            // 
            this.Login_email.AutoSize = true;
            this.Login_email.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Login_email.ForeColor = System.Drawing.Color.White;
            this.Login_email.Location = new System.Drawing.Point(161, 196);
            this.Login_email.Name = "Login_email";
            this.Login_email.Size = new System.Drawing.Size(65, 24);
            this.Login_email.TabIndex = 0;
            this.Login_email.Text = "Email";
            this.Login_email.Click += new System.EventHandler(this.Login_email_Click);
            // 
            // Pin_login
            // 
            this.Pin_login.AutoSize = true;
            this.Pin_login.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Pin_login.ForeColor = System.Drawing.Color.White;
            this.Pin_login.Location = new System.Drawing.Point(161, 274);
            this.Pin_login.Name = "Pin_login";
            this.Pin_login.Size = new System.Drawing.Size(39, 22);
            this.Pin_login.TabIndex = 1;
            this.Pin_login.Text = "Pin";
            this.Pin_login.Click += new System.EventHandler(this.Pin_login_Click);
            // 
            // Login_user
            // 
            this.Login_user.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Login_user.ForeColor = System.Drawing.Color.Black;
            this.Login_user.Location = new System.Drawing.Point(227, 355);
            this.Login_user.Name = "Login_user";
            this.Login_user.Size = new System.Drawing.Size(125, 35);
            this.Login_user.TabIndex = 2;
            this.Login_user.Text = "Login";
            this.Login_user.UseVisualStyleBackColor = true;
            this.Login_user.Click += new System.EventHandler(this.Login_user_Click);
            // 
            // Login_email_field
            // 
            this.Login_email_field.Location = new System.Drawing.Point(299, 189);
            this.Login_email_field.Name = "Login_email_field";
            this.Login_email_field.Size = new System.Drawing.Size(230, 31);
            this.Login_email_field.TabIndex = 3;
            this.Login_email_field.TextChanged += new System.EventHandler(this.Login_email_field_TextChanged);
            // 
            // Pin_login_field
            // 
            this.Pin_login_field.Location = new System.Drawing.Point(299, 274);
            this.Pin_login_field.Name = "Pin_login_field";
            this.Pin_login_field.Size = new System.Drawing.Size(230, 31);
            this.Pin_login_field.TabIndex = 4;
            this.Pin_login_field.TextChanged += new System.EventHandler(this.Pin_login_field_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(-1, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(706, 75);
            this.panel1.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Location = new System.Drawing.Point(242, 46);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(412, 24);
            this.textBox3.TabIndex = 1;
            this.textBox3.Text = " ... a bank you can always trust with your money";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Showcard Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(13, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(366, 38);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "WELCOME TO AFB BANK";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.SaddleBrown;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.linkLabel1.LinkColor = System.Drawing.SystemColors.Window;
            this.linkLabel1.Location = new System.Drawing.Point(206, 450);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(78, 25);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Sign Up";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(54, 450);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Not a Customer?";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.ClientSize = new System.Drawing.Size(705, 533);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Pin_login_field);
            this.Controls.Add(this.Login_email_field);
            this.Controls.Add(this.Login_user);
            this.Controls.Add(this.Pin_login);
            this.Controls.Add(this.Login_email);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Login_email;
        private System.Windows.Forms.Label Pin_login;
        private System.Windows.Forms.Button Login_user;
        private System.Windows.Forms.TextBox Login_email_field;
        private System.Windows.Forms.TextBox Pin_login_field;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
    }
}
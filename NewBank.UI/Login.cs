using NewBank.Core;
using NewBank.Core.Abstraction;
using NewBank.Core.Interface;
using System;
using System.Windows.Forms;

namespace NewBank.UI
{
    public partial class Login : Form
    {
        private readonly IAuth _auth;
       private readonly ICustomerRepository _custoRepo;
        private readonly IBankOperations _bankOp;
        private readonly IAccountRepository _accountRepo;



        public Login(IAuth auth, ICustomerRepository custoRepo, IBankOperations bankOp, IAccountRepository accountRepo)
        {
            InitializeComponent();
            _auth = auth;
            _custoRepo = custoRepo;
            _bankOp = bankOp;
            _accountRepo = accountRepo;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Login_email_Click(object sender, EventArgs e)
        {

        }

        private void Login_email_field_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_user_Click(object sender, EventArgs e)
        {
            if (!_auth.CheckEmailExist(Login_email_field.Text) || (!_auth.CheckPasswordExist(Pin_login_field.Text)))
            {
                MessageBox.Show("Enter valid details");
            }
            else
            {
                if (Login_email_field.TextLength == 0 || (Pin_login_field.TextLength == 0))
                {
                    MessageBox.Show("Fields cannot be empty");

                }

                else
                {
                    this.Hide();
                    Dashboard dashboard = new Dashboard(_auth, _bankOp, _accountRepo, _custoRepo);
                    dashboard.Show();
                }
            }
        }

        private void Pin_login_Click(object sender, EventArgs e)
        {

        }

        private void Pin_login_field_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Register register = new Register(_auth, _custoRepo, _bankOp, _accountRepo);
           
            register.Show();
        }
    }
}

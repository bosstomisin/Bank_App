//using BankApp.BL.Database;
//using BankApp.Data.Implementation;
using NewBank.Common;
using NewBank.Core;
using NewBank.Core.Abstraction;
using NewBank.Core.Interface;
using System;
using System.Windows.Forms;

namespace NewBank.UI
{
    public partial class Register : Form
    {
        private readonly IAuth _auth;
        private readonly ICustomerRepository _custoRepo;
       private readonly IBankOperations _bankOp;
        private readonly IAccountRepository _accountRepo;
       
        public Register(IAuth auth, ICustomerRepository custoRepo, IBankOperations bankOp, IAccountRepository accountRep)
        {
            InitializeComponent();
            _auth = auth;
            _custoRepo = custoRepo;
            _bankOp = bankOp;
            _accountRepo = accountRep;
        }

        private void Lastname_txt_Click(object sender, EventArgs e)
        {

        }

        private void Firstname_text_field_TextChanged(object sender, EventArgs e)
        {

        }

        private void Account_type_Click(object sender, EventArgs e)
        {

        }

        private void Current_account_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void Register_field_Click(object sender, EventArgs e)
        {
            if(Firstname_text_field.TextLength == 0 || Lastname_txt_field.TextLength == 0 || Email_txt_field.TextLength == 0 || Pin_txt_field.TextLength == 0)
            {
                
                MessageBox.Show("Please fill the form correctly");

            }
            if (!Utilities.ValidateEmail(Email_txt_field.Text))
            {
                MessageBox.Show("Enter valid email");
            }
            if (!Savings_account.Checked && !Current_account.Checked)
            {
                MessageBox.Show("Select an account type");
            }
            else
            {
                //_custoRepo.AddCustomer(Firstname_text_field.Text, Lastname_txt_field.Text, Email_txt_field.Text, Pin_txt_field.Text, Account_type.Text);

                if (Current_account.Checked == true)
                {
                  var account =  _custoRepo.AddCustomer(Firstname_text_field.Text, Lastname_txt_field.Text, Email_txt_field.Text, Pin_txt_field.Text, "Current");

                    this.Hide();
                    Login login = new Login(_auth, _custoRepo, _bankOp, _accountRepo);
                    login.Show();
                    MessageBox.Show("Login Successfull");
                }
                else if(Savings_account.Checked == true)
                {
                    _custoRepo.AddCustomer(Firstname_text_field.Text, Lastname_txt_field.Text, Email_txt_field.Text, Pin_txt_field.Text, "Savings");
                    this.Hide();
                    Deposit deposit = new Deposit(_auth, _custoRepo, _bankOp, _accountRepo);
                    deposit.Show();
                }
            }
           

            
        }

        private void Pin_txt_field_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Email_txt_field_TextChanged(object sender, EventArgs e)
        {

        }

        private void Savings_account_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Lastname_txt_field_TextChanged(object sender, EventArgs e)
        {

        }

        private void Firstname_txt_Click(object sender, EventArgs e)
        {

        }

        private void Email_text_Click(object sender, EventArgs e)
        {

        }

        private void pin_text_Click(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login(_auth, _custoRepo, _bankOp, _accountRepo);
            login.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

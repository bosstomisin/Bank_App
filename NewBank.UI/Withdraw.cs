using NewBank.Core;
using NewBank.Core.Abstraction;
using NewBank.Core.Interface;
using System;
using System.Windows.Forms;

namespace NewBank.UI
{
    public partial class Withdraw : Form
    {
        private IBankOperations _bankOp { get; }
        private IAccountRepository _accountRepo { get; }
        private ICustomerRepository _custoRepo { get; }
        private IAuth _auth { get; }


        public Withdraw(IAuth auth, IBankOperations bankOp, IAccountRepository accountRepo, ICustomerRepository custoRepo)
        {
            InitializeComponent();
            _bankOp = bankOp;
            _accountRepo = accountRepo;
            _custoRepo = custoRepo;
            _auth = auth;
        }

        private void Account_number_txt_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Account_number_field_TextChanged(object sender, EventArgs e)
        {

        }

        private void Amount_txt_Click(object sender, EventArgs e)
        {

        }

        private void Description_text_Click(object sender, EventArgs e)
        {

        }

        private void Description_txt_field_TextChanged(object sender, EventArgs e)
        {

        }

        private void Withdraw_field_Click(object sender, EventArgs e)
        {
            try
            {
                var accntNum = Account_number_field.Text;
                var amount = Convert.ToDecimal(Amount_txt_field.Text);
                var description = Description_txt_field.Text;
                bool withdraw =   _bankOp.Withdraw(accntNum, amount, description);
                if (withdraw != false)
                {
                    MessageBox.Show("Transaction successful");
                }
            }
            catch (Exception ex)
            { 
                MessageBox.Show(ex.Message, "Insufficient fund");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Transfer transfer = new Transfer(_auth, _accountRepo, _bankOp, _custoRepo);
            transfer.Show();
        }

        private void Withdraw_Load(object sender, EventArgs e)
        {

        }

        private void Deposit_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dashboard = new Dashboard(_auth, _bankOp,_accountRepo, _custoRepo);
            dashboard.Show();
        }

        private void Statement_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            StatementOfAccount statement = new StatementOfAccount(_auth, _custoRepo, _bankOp, _accountRepo);
            statement.Show();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login(_auth, _custoRepo, _bankOp, _accountRepo);
            login.Show();
        }
    }
}

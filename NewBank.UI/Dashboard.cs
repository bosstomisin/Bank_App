using NewBank.Core;
using NewBank.Core.Abstraction;
using NewBank.Core.Interface;
using System;
using System.Windows.Forms;

namespace NewBank.UI
{
    public partial class Dashboard : Form
    {
        private readonly IBankOperations _bankOp;
        private readonly IAccountRepository _accountRepo;
        private readonly ICustomerRepository _custoRepo;
        private readonly IAuth _auth;



        public Dashboard(IAuth auth, IBankOperations bankOp, IAccountRepository accountRepo, ICustomerRepository custoRepo)
        {
            InitializeComponent();
            _bankOp = bankOp;
            _accountRepo = accountRepo;
            _custoRepo = custoRepo;
            _auth = auth;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Deposit_account_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //Deposit deposit = new Deposit();
            //deposit.Show();
        }

        private void Statement_Of_account_Click(object sender, EventArgs e)
        {
            this.Hide();
            StatementOfAccount statement = new StatementOfAccount(_auth, _custoRepo, _bankOp, _accountRepo);
            statement.Show();
        }

        private void Transfer_Click(object sender, EventArgs e)
        {
            this.Hide();
            Transfer transfer = new Transfer(_auth, _accountRepo, _bankOp, _custoRepo);
            transfer.Show();
        }

        private void withdraw_Click(object sender, EventArgs e)
        {
            this.Hide();
            Withdraw withdraw = new Withdraw(_auth, _bankOp, _accountRepo, _custoRepo);
            withdraw.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Deposit_field_Click(object sender, EventArgs e)
        {
            try
            {
                var accntNum = accountNumTxt.Text;
                var amount = Convert.ToDecimal(amountTxt.Text);
                var description = descriptionTxt.Text;
               bool deposit = _bankOp.Deposit(accntNum, amount, description);
                if (deposit != false)
                {
                    MessageBox.Show("Transaction successful");
                }
                
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Amount cannot be negative");
            }
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login(_auth, _custoRepo, _bankOp, _accountRepo);
            login.Show();
        }
    }
}

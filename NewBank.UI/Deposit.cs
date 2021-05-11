using NewBank.Core;
using NewBank.Core.Abstraction;
using NewBank.Core.Interface;
using System;
using System.Windows.Forms;

namespace NewBank.UI
{
    public partial class Deposit : Form
    {
        private readonly IAuth _auth;
        private readonly ICustomerRepository _custoRepo;
        private readonly IBankOperations _bankOp;
        private readonly IAccountRepository _accountRepo;

        public Deposit(IAuth auth, ICustomerRepository custoRepo, IBankOperations bankOp, IAccountRepository accountRepo)
        {
            InitializeComponent();
            _auth = auth;
            _custoRepo = custoRepo;
            _bankOp = bankOp;
            _accountRepo = accountRepo;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void amount_TextChanged(object sender, EventArgs e)
        {

        }

        private void Deposit_Savings_Click(object sender, EventArgs e)
        {
            try
            {
                var accntNum =  Account_number.Text;
                var amount = Convert.ToDecimal(amount_txt.Text);
                var description = Description_txt.Text;
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

        private void Deposit_Load(object sender, EventArgs e)
        {

        }
    }
}

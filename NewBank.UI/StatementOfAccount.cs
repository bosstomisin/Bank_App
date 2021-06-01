using NewBank.Core;
using NewBank.Core.Abstraction;
using NewBank.Core.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NewBank.UI
{
    public partial class StatementOfAccount : Form
    {
        private IAuth _auth { get; }
        private ICustomerRepository _custoRepo { get; }
        private IBankOperations _bankOp { get; }

         private IAccountRepository _accountRepo { get; }

        public StatementOfAccount(IAuth auth, ICustomerRepository custoRepo, IBankOperations bankOp, IAccountRepository accountRepo)
        {
            InitializeComponent();
            _auth = auth;
           _custoRepo = custoRepo;
            _accountRepo = accountRepo;
            _bankOp = bankOp;
        }

        private void Deposit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dashboard = new Dashboard(_auth, _bankOp, _accountRepo, _custoRepo);
            dashboard.Show();
        }

        private void Transfer_Click(object sender, EventArgs e)
        {
            this.Hide();
            Transfer transfer = new Transfer(_auth, _accountRepo, _bankOp, _custoRepo);
            transfer.Show();
        }

        private void Statement_of_account_Click(object sender, EventArgs e)
        {
            this.Hide();
           StatementOfAccount statement = new StatementOfAccount(_auth, _custoRepo, _bankOp, _accountRepo);
            statement.Show();
        }

        private void withdraw_Click(object sender, EventArgs e)
        {
            this.Hide();
            Withdraw withdraw = new Withdraw(_auth, _bankOp, _accountRepo, _custoRepo);
            withdraw.Show();
        }

        private void StatementOfAccount_Load(object sender, EventArgs e)
        {
            
        }

        private void GetTrans_Click(object sender, EventArgs e)
        {
            var AccountNum = AccountNoField.Text;
            var transactions = _bankOp.StatementOfAccount(AccountNum);
            displayTransaction.DataSource = transactions.Select(x => new
            {
                TransactionAmount = x.Amount.ToString(),
                Note = x.Notes,
                Date = x.Date.ToString(),
                TransactionId = x.TransactionId.ToString(),
                transactionType = x.TransactionType
            }).ToList();
            var balance = _accountRepo.GetAccount(AccountNum).Balance;
            Balance.Text = $"Balance: {balance}";
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login(_auth, _custoRepo, _bankOp, _accountRepo);
            login.Show();
        }

        private void displayTransaction_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

using NewBank.Core;
using NewBank.Core.Abstraction;
using NewBank.Core.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NewBank.UI
{
    public partial class Transfer : Form
    {
        private IAccountRepository _accountRepo { get; }
        private IBankOperations _bankOp { get; }
        private ICustomerRepository _custoRepo { get; }
        private readonly IAuth _auth;


        public Transfer(IAuth auth, IAccountRepository accountRepo, IBankOperations bankOp, ICustomerRepository custoRepo)
        {
            InitializeComponent();
            _accountRepo = accountRepo;
            _bankOp = bankOp;
            _custoRepo = custoRepo;
            _auth = auth;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Deposit_button_Click(object sender, EventArgs e)
        {

        }

        private void Transfer_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            StatementOfAccount statement = new StatementOfAccount(_auth, _custoRepo, _bankOp, _accountRepo);
            statement.Show();
        }

        private void deposit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dashboard = new Dashboard(_auth, _bankOp, _accountRepo, _custoRepo);
            dashboard.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Transfer transfer = new Transfer(_auth, _accountRepo, _bankOp, _custoRepo);
            transfer.Show();
        }

        private void Withdraw_Click(object sender, EventArgs e)
        {
            this.Hide();
            Withdraw withdraw = new Withdraw(_auth, _bankOp, _accountRepo, _custoRepo );
            withdraw.Show();
        }

        private void Transfer_field_Click(object sender, EventArgs e)
        {
            try
            {
                var credtAcc = credit_text_field.Text;
                var debitAcc = Debit_text_field.Text;
                var amount = Convert.ToDecimal(Amount_field.Text);
                var description = Description_field.Text;
               bool transfer = _bankOp.Transfer(debitAcc, credtAcc, amount, description);
                if (transfer != false)
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


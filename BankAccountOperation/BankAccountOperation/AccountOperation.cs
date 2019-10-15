using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace BankAccountOperation
{
    public partial class AccountOperation : Form
    {
        public Account account;
        public bool done;
        public AccountOperation()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void createButton_Click(object sender, EventArgs e)
        {
            bool flag1 = Regex.IsMatch(customerNameTextBox.Text, "[a-zA-Z]{1,}$");
            bool flag2 = Regex.IsMatch(accountNUmberTextBox.Text, "[0-9a-zA-Z]{10,10}$");
            if (customerNameTextBox.Text!="" && accountNUmberTextBox.Text!="")
            {
                account = new Account();
                if (flag2 == true)
                {
                    account.AccountNumber = accountNUmberTextBox.Text;
                }
                else
                {
                    MessageBox.Show("Input excat 10 character for account number.");
                }

                if (flag1 == true)
                {
                    account.Name = customerNameTextBox.Text;
                }
                else
                {
                    MessageBox.Show("Use only alphabat for name.");
                }

                done = true;

               customerNameTextBox.Clear();
               accountNUmberTextBox.Clear();
                
            }
            else
            {
                MessageBox.Show("Enter all textfield properly.");
            }

        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            if (done)
            {
                bool flag3 = Regex.IsMatch(amountTextBox.Text, "[0-9.]{1,}$");
                if (flag3 == true)
                {
                    bool deposited = account.Deposit(Convert.ToDouble(amountTextBox.Text));
                    if (deposited)
                    {
                        MessageBox.Show("The amount is deposited.");
                    }
                }
                else
                {
                    MessageBox.Show("Enter amount properly.");
                }
            }
            else
            {
                MessageBox.Show("Create account first.");
            }
            

        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            if (done)
            {
                bool flag4 = Regex.IsMatch(amountTextBox.Text, "[0-9.]{1,}$");
                if (flag4 == true)
                {
                    bool withdrawn = account.Withdraw(Convert.ToDouble(amountTextBox.Text));
                    if (withdrawn)
                    {
                        MessageBox.Show("The amount is withdrawn.");
                    }
                    else
                    {
                        MessageBox.Show("Your account is not sufficient.");
                    }
                }
                else
                {
                    MessageBox.Show("Enter amount properly.");
                }
            }
            else
            {
                MessageBox.Show("Create account first.");
            }

        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            if (done)
            {
                string report = account.Report();
                MessageBox.Show(report);
            }
        }
    }
}

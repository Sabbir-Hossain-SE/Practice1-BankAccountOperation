using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountOperation
{
    public class Account
    {
        public double balance;
        public string Name { set; get; }
        public string AccountNumber { set; get; }

        public bool Deposit(double amount)
        {
            bool flag;
            if (amount <= 0)
            {
                flag = false;
            }
            else
            {
                balance += amount;
                flag = true;
            }
            return flag;
        }
        public bool Withdraw(double amount)
        {
            bool flag;
            if (amount > balance)
            {
                flag = false;
            }
            else
            {
                balance -= amount;
                flag = true;
            }
            return flag;
        }
        public string Report()
        {
            string report;
            report = Name + ", your accoutn number : " + AccountNumber + " and it's balance :" + balance;
            return report;
        }

    }
    
}

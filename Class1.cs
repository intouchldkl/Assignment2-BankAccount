using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2_BankAccount
{
    class Account
    {
        private string name;
        private double balance;

        public Account(string name, double balance)
        {
            this.name = name;
            this.balance = balance;
        }

        public double CheckBalance()
        {
            return balance;
        }

        public double WithdrawMoney(double MoneyOut)
        {
            if (MoneyOut > balance)
            {
                Console.WriteLine("Insufficient amount of balance");
            }
            else if (MoneyOut > 0)
            {
                Console.WriteLine("Withdrawal successful!");
                balance = balance - MoneyOut;
            }
            else
            {
                Console.WriteLine("Withdrawal failed!");
            }
            return balance;
        }

        public double DepositMoney(double MoneyIn)
        {
            if (MoneyIn > 0)
            {
                Console.WriteLine("Deposition successful!");
                balance = balance = MoneyIn;
            }
            else
            {
                Console.WriteLine("Deposition failed");
            }
            return balance;
        }

        public double AddInterest(double InterestRate)
        {
            string date = DateTime.Now.ToShortDateString();
            if (date == "12/01/2021")
            {
                balance = balance * InterestRate;
            }
            return balance;

        }
    }
}

        








using System;

namespace Types
{
	
    public class Account
    {
        private decimal balance;
        private string holder;
        private string number;

        public Account(decimal balance, string holder, string number)
        {
            this.balance = balance;
            this.holder = holder;
            this.number = number;
        }

        public Account(string holder, string number) : this(0.0m, holder, number) {}
        

        public decimal Balance
        {
            get { return balance; }
        }

        public string Holder
        {
            get { return holder; }
        }

        public string Number
        {
            get { return number; }
        }

        public bool Withdraw(decimal amount)
        {
            bool result = false;
            if (amount < balance)
            {
                balance -= amount;
                result = true;
            }
            return result;
        }

        public void Deposit(decimal amount)
        {
            balance += amount;
        }

        public static bool Transfer(decimal amount, Account from, Account to)
        {
            bool result = false;
            result = from.Withdraw(amount);
            if (result)
            {
                to.Deposit(amount);
            }
            return result;
        }
    }
}

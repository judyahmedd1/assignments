using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops1q1
{
    using System;

    namespace BankAccountApp
    {
        class BankAccount
        {
            private string _owner;
            private double _balance;

            public string Owner
            {
                get { return _owner; }
                set
                {
                    if (string.IsNullOrEmpty(value))
                    {
                        Console.WriteLine("owner name can't be empty");
                        return;
                    }

                    _owner = value;
                }
            }

            public double Balance
            {
                get { return _balance; }
                set
                {
                    if (value < 0)
                    {
                        Console.WriteLine("balance can't be negative");
                        return;
                    }

                    _balance = value;
                }
            }

            public BankAccount(string owner, double balance)
            {
                if (string.IsNullOrEmpty(owner))
                {
                    throw new ArgumentException("owner name can't be empty");
                }

                if (balance < 0)
                {
                    throw new ArgumentException("balance can't be negative");
                }

                _owner = owner;
                _balance = balance;
            }

            public void Deposit(double amount)
            {
                if (amount <= 0)
                {
                    Console.WriteLine("deposit amount must be greater than zero");
                    return;
                }

                _balance += amount;
            }
        }

        internal class Program
        {
            static void Main(string[] args)
            {
                BankAccount account = new BankAccount("judy", 1000);
                account.Deposit(500);
                Console.WriteLine("owner name is: " + account.Owner);
                Console.WriteLine("balance is: " + account.Balance);
            }
        }
    }
}

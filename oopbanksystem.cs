using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops3q2
{
    internal class Account
    {
        //fields
        //shared counter 
        static int _nextaccnumber=1;

        private int _accnumber;
        private string _accname;
        //protected for derived classes 
        protected double _balance;
        private DateTime _createddate;

        //accessors properties
        public int Accnumber
        {
            get { return _accnumber; }
        }
        public string Accname
        {
            get { return _accname; } 
            set {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("invalid, name can't be empty");
                }
                _accname = value; }
        }
        public double Balance
        {
            get { return _balance; }
        }
        public DateTime Createddate
        {
            get { return _createddate; }
        }

        //comstructor
        public Account(string accname, double balance)
        {
            _accnumber = _nextaccnumber++;
            Accname = accname;

            if (balance < 0)
            {
                throw new ArgumentException("invalid, balance must be a positive value");
            }
            _balance = balance;

            _createddate = DateTime.Now;
        }

        //methods
        public virtual void deposit(double amount)
        {
            if (amount <= 0) {
                throw new ArgumentException("invalid, amount to deposit must be a positive value");
            }
            _balance += amount;
        }
        public virtual void withdraw(double amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("invalid, amount to withdraw must be a positive value");
            }
            if (amount > _balance)
            {
                throw new InvalidOperationException("invalid, balance is not enough");
            }
            _balance -= amount;
        }
        public virtual void displaydetails()
        {
            Console.WriteLine($"account number is: {Accnumber}");
            Console.WriteLine($"account name is: {Accname}");
            Console.WriteLine($"balance is: {Balance}");
            Console.WriteLine($"created at : {Createddate}");

        }
    }
    internal class Savingsaccount : Account
    {
        private const double _interestrate = 0.05;
        public Savingsaccount(string accname, double balance) : base(accname, balance)
        {
        }
        public void addmonthlyinterest()
        {
            _balance += _balance * _interestrate;
        }
        public override void displaydetails()
        {
            base.displaydetails();
            Console.WriteLine($"interest rate is: {_interestrate * 100}%");
        }
    }
    internal class Currentaccount : Account
    {
        private const double _withdrawfee = 10;
        public Currentaccount(string accname, double balance): base(accname, balance)
        {
        }
        public override void withdraw(double amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("invalid, amount to withdraw must be a positive value");
            }
            double totalamount = amount + _withdrawfee;
            if (totalamount > _balance)
            {
                throw new InvalidOperationException("invalid, balance is not enough for withdrawal and fee");
            }

            _balance -= totalamount;
        }
        public override void displaydetails()
        {
            base.displaydetails();
            Console.WriteLine($"withdrawal fee is: {_withdrawfee}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Savingsaccount savings = new Savingsaccount("judy", 1000);

            savings.deposit(500);
            Console.WriteLine("Savings account details:");
            savings.displaydetails();
            savings.addmonthlyinterest();
            Console.WriteLine("after monthly interest will be:");
            savings.displaydetails();

            Currentaccount current = new Currentaccount("ahmed", 1000);

            current.deposit(500);
            Console.WriteLine("Current account details:");
            current.displaydetails();
            current.withdraw(100);
            Console.WriteLine("after withdrawing will be:");
            current.displaydetails();
        }
    }
}

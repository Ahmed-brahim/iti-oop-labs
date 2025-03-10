using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lap3._5
{
    public class BankAccount
    {
        static private int _n = 1000;
        private string _name;
        private int _id;
        private float _balance;
        public BankAccount()
        {
            _id = _n;
            _n++;
        }

        public BankAccount(string name, float balance)
        {
            _name = name;
            _id = _n;
            _balance = balance;
            _n++;
        }

        public int Id
        {
            get 
            { 
                return _id;
            }
            private set {}
        } 
        public float Balance
        { 
            get 
            { 
                return _balance; 
            }   
            set 
            {
                if(value > 0)
                    _balance = value; 
            } 
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public void print()
        {
            Console.WriteLine($"Account Holder: {_name}\nBalance: {_balance}$\nId: {_id}");
        }
        public void Deposit(float amount)
        {
            if(amount < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid Operation");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                _balance += amount;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Successful operation");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Your Balance is {_balance}");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
        public void Withdraw(float amount)
        {
            if (amount < _balance)
            {
                _balance -= amount;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Successful operation");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Your Balance is {_balance}");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid Operation");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBank
{
    public class BankAccount
    {
        // Backing fields
        private string name;
        private double balance;
        private bool locked;
        // Properties
        public string Name
        {
            get => name;
            set => name = value;
        }
        public double Balance { get { return this.balance; } }
        // Constructers
        public BankAccount (string name, double balance, bool locked)
        {
            this.name = name;
            this.balance = balance;
            this.locked = locked;
        }
        public BankAccount (string name, double balance) : this("", 0, false)
        {
            this.name = name;
            this.balance = balance;
        }
        public BankAccount (double balance) : this("", 0, false)
        {
            this.balance = balance;
            this.name = name;
        }
        
        // Methods
        public override string ToString()
        {
            return $"Name: {name}, Balance: {this.balance}";
        }
        public void Deposit(double amount)
        {
            if (locked == false)
            {
                this.balance += amount;
                Console.WriteLine("Current balance: " + this.balance);
            } else
            {
                Console.WriteLine("Account is locked");
            }
        }
        public void Withdraw(double amount)
        {
            if (locked == false)
            {
                if (amount <= this.balance)
                {
                    this.balance -= amount;
                }
                else
                {
                    Console.WriteLine($"\nInsufficient funds:\nCurrent balance: {this.balance}");
                }
            }else
            {
                Console.WriteLine("Account is locked.");
            }
        }
        public void ChangeLockState()
        {
            if (this.locked == false)
            {
                this.locked = true;
                Console.WriteLine("Bank account locked");
            }
            else
            {
                this.locked = false;
                Console.WriteLine("Bank account unlocked");
            }
        }
    }
}

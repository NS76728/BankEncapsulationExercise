using System;
using System.Collections.Generic;
using System.Text;

namespace BankEncapsulationExercise
{
    class BankAccount
    {
        private double balance = 0;
        
        public void Deposite (double amount)
        {
            balance += amount;
        }
        public double GetBalance()
        {
            return balance;
        }

    }
}

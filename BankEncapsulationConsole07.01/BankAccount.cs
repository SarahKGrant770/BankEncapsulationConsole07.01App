using System;
using System.Collections.Generic;
using System.Text;

namespace BankEncapsulationConsole07._01
{
    public class BankAccount
    {
        public BankAccount()

        {
        }

        private double balance = 0;

        //we're going to hide balance with encapsulation


        //Define a method named Deposit that'll accept double and store that value in the balance field

        public void Deposit(double amount)
        {
            balance = amount;
        }

        //Define a method named GetBalance that will return amount stored in the balance field

        public double GetBalance()
        {
            return balance;
        }

        }
    }


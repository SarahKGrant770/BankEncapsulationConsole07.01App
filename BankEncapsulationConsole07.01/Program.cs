using System;

namespace BankEncapsulationConsole07._01
{
    class Program
    {
        static void Main(string[] args)
        {

            //BankAccount account = new BankAccount();
            //Console.WriteLine("How much would you like to deposit?");

            //var amountToDeposit = double.Parse(Console.ReadLine());
            //account.Deposit(amountToDeposit);

            //Console.WriteLine($"Thank you! Your balance is now {account.GetBalance()}");

           PersonalInfo info = new PersonalInfo();
            Console.WriteLine("Please enter your phone number!");
            info.FormattedNumber = Console.ReadLine();

            Console.WriteLine($"This is your number correctly formatted: {info.FormattedNumber}");


        }
    }
}

using System;

namespace BankEncapsulationExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            var bank1 = new BankAccount();
            Console.WriteLine("How much would you like to deposite?");
            int use = Convert.ToInt32(Console.ReadLine());
            bank1.Deposite(use);

            Console.WriteLine("Would you like to see your balance?   (yes or no)");
            string use2 = Console.ReadLine();

            if (use2 == "yes")
            {
               Console.WriteLine( "You have a balance of: $" +bank1.GetBalance());
            }
            else
            {
                Console.WriteLine("Have a great day!");
            }


        }
    }
}

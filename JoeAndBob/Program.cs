using System;

namespace JoeAndBob
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new Guy object in a variable called joe // Set its Name field to "Joe"
            // Set its Cash field to 50
            // Create a new Guy object in a variable called bob // Set its Name field to "Bob"
            // Set its Cash field to 100
            Guy joe = new Guy() { Name = "Joe", Cash = 50};
            Guy bob = new Guy() { Name = "Bob", Cash = 100 };

            while (true)
            {
                // Call the WriteMyInfo methods for each Guy object
                joe.WriteMyInfo();
                bob.WriteMyInfo();

                Console.WriteLine("Enter an amount");
                string howMuch = Console.ReadLine();
                if (howMuch == "") return;
                if (int.TryParse(howMuch, out int amount))
                {
                    Console.WriteLine("Who should give the cash: ");
                    string whichGuy = Console.ReadLine();
                    if (whichGuy == "Joe")
                    {
                        int cashGiven = joe.GiveCash(amount);
                        bob.ReceiveCash(cashGiven);

                    }
                    else if (whichGuy == "Bob")
                    {
                        int cashGiven = bob.GiveCash(amount);
                        joe.ReceiveCash(cashGiven);
                    }
                    else
                    {
                        Console.WriteLine("Please enter 'Joe' or 'Bob'");
                    }

                }
                else
                {
                    Console.WriteLine("Please enter an amount (or a blank line to exit).");
                }

            }
  
        }
    }
}

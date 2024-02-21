using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sarre_Transport
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* Step 1 Declare a variable called destination of type String
              Step 4 Declare a variable of type int to capture the user’s age */
            string destination;
            int usersAge = 0;
            bool isDestinationCorrect = false;
            string yesOrNo;
            bool isAgeInteger = false;
            float destinationCost = 0.00F;
            float discount = 0.00F;
            float costOfTicket = 0.00F;

            // Step 2 Prompt the user for the destination (‘D’, ’A’ or ‘L’)
            do
            {
                Console.WriteLine("Would like to go to Ashford [A], Dover [D] or London[L]?");
                // Step 3 Read the user’s answer into the destination variable
                destination = Console.ReadLine().ToUpper();

                if (destination == "A" || destination == "D" || destination == "L")
                {
                    Console.WriteLine("Thanks");
                    isDestinationCorrect = true;
                }
                else
                {
                    Console.WriteLine("Please input A, D or L");
                }
            }
            while (isDestinationCorrect == false);

            // Step 5 Prompt for the user’s age and read the user’s input into the age variable
            do
            {
                try
                {
                    Console.WriteLine("How old are you?");
                    usersAge = Convert.ToInt32(Console.ReadLine());
                    isAgeInteger = true;
                }
                catch
                {
                    Console.WriteLine("Please enter an integer");
                }
            }
            while (isAgeInteger == false);

            // Step 6 Prompts the user if they wish to upgrade to first class using a mechanism of your own choice
            do
            {
                Console.WriteLine("Would you like to upgrade to first class? Yes/No [Y/N]");
                yesOrNo = Console.ReadLine().ToUpper();
                if (yesOrNo == "Y" || yesOrNo == "N" || yesOrNo == "YES" || yesOrNo == "NO")
                {
                    Console.WriteLine("Thanks");
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter Yes/No or Y/N");

                }
            }
            while (yesOrNo != "Y" || yesOrNo != "N" || yesOrNo != "YES" || yesOrNo != "NO");

            // Step 7 Calculate the cost of the ticket using the destination, age and optional upgrade
            if (yesOrNo == "N" || yesOrNo == "NO")
            {
                switch (destination)
                {
                    case "A":
                        destinationCost = 8.90F;
                        break;
                    case "D":
                        destinationCost = 9.40F;
                        break;
                    case "L":
                        destinationCost = 37.00F;
                        break;
                }
            }
            else if (yesOrNo == "Y" || yesOrNo == "YES")
            {
                switch (destination)
                {
                    case "A":
                        destinationCost = 13.30F;
                        break;
                    case "D":
                        destinationCost = 14.90F;
                        break;
                    case "L":
                        destinationCost = 63.00F;
                        break;
                }
            }

            if (usersAge > 0 && usersAge < 3)
            {
                discount = 0.00F;
            }
            else if (usersAge >= 3 && usersAge < 16)
            {
                discount = 0.90F;
            }
            else if (usersAge >= 16 && usersAge < 65)
            {
                discount = 1.00F;
            }
            else if (usersAge >= 65)
            {
                discount = 0.85F;
            }

            costOfTicket = destinationCost * discount;
            // Step 8  Display the total price of the ticket to the user
            Console.WriteLine("Your ticket costs £" + costOfTicket);

            // Step 9 Prompt the user to press a key and wait for this to exit the program
        }
    }
}

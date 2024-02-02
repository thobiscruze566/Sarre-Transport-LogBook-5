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
            int usersAge;
            bool isDestinationCorrect = false;
            string yesOrNo;
            bool isAgeInteger = false;

            do
            {
                Console.WriteLine("Would like to go to Ashford [A], Dover [D] or London[L]?");
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
            while(isAgeInteger == false);


            Console.WriteLine("Would you like to upgrade to first class? Yes/No [Y/N]");
            yesOrNo = Console.ReadLine().ToUpper();
        }
    }
}

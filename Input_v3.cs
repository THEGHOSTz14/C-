/* You have already learned that Console.WriteLine() is used to output (print) values. Now we will use Console.ReadLine() to get user input. */

using System;
namespace CSharpV3_Input
{
    class program
    {
        static void Main(string[] args)
        {
            //-------------------------------C# User Input----------------------------------------//

                Console.WriteLine("Say Your Name Soldier:");

                string SoldierName = Console.ReadLine(); // This will read the user input and store it in the SoldierName variable.

                Console.WriteLine("Welcome, " + SoldierName + "!"); // This will display a welcome message with the user's name.

            

            //-------------------------------C# User Input Numbers----------------------------------------//


                Console.WriteLine("Enter your age soldier:");
                
                string age = Console.ReadLine() ?? ""; // This will read the user input and store it in the age variable.

                Console.WriteLine("Your age is: " + age); // This will display the user's age.
















        }
    }
}
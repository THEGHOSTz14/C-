// WELL THERE ARE 2 TYPES OF TYPE CASTING IN C#
// 1. Implicit Type Casting (Widening Conversion) 

//Char -> Int -> Long -> Float -> Double

// 2. Explicit Type Casting (Narrowing Conversion)

// Double -> Float -> Long -> Int -> Char

using System;
namespace CSharpV0_TypeCasting
{
    class Program
    {
        static void Main(string[] args)
        {


        //-------------------------------C# Type Casting----------------------------------------//
        //-------------------------------Implicit Type Casting (Widening Conversion)----------------------------------------//


            int group =  3;
            double groupDouble = group; // Implicit Type Casting (Widening Conversion)
            Console.WriteLine(group); // Output: 3
            Console.WriteLine(groupDouble); // Output: 3.0


        //-------------------------------Explicit Type Casting (Narrowing Conversion)----------------------------------------//


            double percentage = 92.63;
            int percentageInt = (int) percentage; // manual type casting (narrowing conversion)
            double percentageDouble = (double) percentageInt;

            Console.WriteLine(percentage); // Output: 92
            Console.WriteLine(percentage); // Output: 92.63

            
        //-------------------------------C# Type Conversion Methods----------------------------------------//   


            /* Convert.ToInt32() - Converts a specified value to a 32-bit signed integer.
               Convert.ToDouble() - Converts a specified value to a double-precision floating-point number.
               Convert.ToString() - Converts a specified value to its equivalent string representation.
               Convert.ToBoolean() - Converts a specified value to a Boolean value
               Convert.ToChar() - Converts a specified value to a Unicode character. */

            
               int number = 10;
               double numberDouble = 5.25;
               bool isTrue = true;

               Console.WriteLine(Convert.ToString(number)); // Output: "10"
               Console.WriteLine(Convert.ToDouble(number)); // Output: 10.0
               Console.WriteLine(Convert.ToInt32(numberDouble)); // Output: 5  YE BETICHOOOOO STRING KO INTIGERS M BADAL DETA HAI 
               Console.WriteLine(Convert.ToBoolean(isTrue)); // Output: True
               Console.WriteLine(Convert.ToChar(65)); // Output: 'A' (ASCII value of 'A' is 65)




            }
        }
    }
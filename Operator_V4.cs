// OPERATOR ARE USUALLY USED TO PERFORM OPERATIONS ON VARIABLES AND VALUES.
// C# PROVIDES A VARIETY OF OPERATORS, INCLUDING ARITHMETIC, ASSIGNMENT, COMPARISON, LOGICAL, BITWISE, AND MORE.        
// MATH NORMAL MATH K QUESTION AUR LODA LASSAN K LIYE HAPPILY 

using System;
namespace CSharpV0_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            //-------------------------------C# Operators----------------------------------------//
            //-------------------------------Arithmetic Operators----------------------------------------//

                int a = 10;
                int b = 5;

                Console.WriteLine(a + b); // Output: 15
                Console.WriteLine(a - b); // Output: 5
                Console.WriteLine(a * b); // Output: 50
                Console.WriteLine(a / b); // Output: 2
                Console.WriteLine(a % b); // Output: 0
                a++; // Increment operator 10 ko 11 kar dega
                Console.WriteLine(a); // Output: 11
                b--; // Decrement operator 5 ko 4 kar dega
                Console.WriteLine(b); // Output: 4



            //-------------------------------Assignment Operators----------------------------------------//


                int x = 10;
                x += 9; // Equivalent to x = x + 9
                Console.WriteLine(x); // Output: 19
                x -= 5; // Equivalent to x = x - 5
                Console.WriteLine(x); // Output: 14

            /* There are some more operators bellow:
            

                OPERATOR                 EXAMPLE                 SAME AS
                =                      x = 5                   x = 5
                +=                     x += 5                  x = x + 5
                -=                     x -= 5                  x = x - 5
                *=                     x *= 5                  x = x * 5
                /=                     x /= 5                  x = x / 5
                %=                     x %= 5                  x = x % 5
                &=                     x &= 5                  x = x & 5
                |=                     x |= 5                  x = x | 5
                ^=                     x ^= 5                  x = x ^ 5
                <<=                    x <<= 5                 x = x << 5
                >>=                    x >>= 5                 x = x >> 5
                */



            //-------------------------------Comparison Operators----------------------------------------//



                int num1 = 10;
                int num2 = 20;

                Console.WriteLine(num1 == num2); // Output: False
                Console.WriteLine(num1 != num2); // Output: True
                Console.WriteLine(num1 > num2); // Output: False
                Console.WriteLine(num1 < num2); // Output: True
                Console.WriteLine(num1 >= num2); // Output: False
                Console.WriteLine(num1 <= num2); // Output: True






            //-------------------------------Logical Operators----------------------------------------//



                /* Logical operators are used to combine multiple conditions or to negate a condition.
                

                     OPERATOR             NAME                       DESCRIPTION                                             EXAMPLE
                        &&              Logical AND         Returns true if both operands are true.              (true && false) // Output: False
                        ||              Logical OR          Returns true if at least one operand is true.         (true || false) // Output: True
                        !               Logical NOT         Returns true if the operand is false.                 !(true) //
                        */



            int p = 10;
            Console.WriteLine(p > 5 && p < 15); // Output: True
            Console.WriteLine(p > 5 || p > 15); // Output: True
            Console.WriteLine(!(p > 5)); // Output: False
            

            
             



            

            
        }
    }
}
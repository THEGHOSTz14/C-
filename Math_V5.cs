using System;
using System.Numerics;
namespace CSharpV0_Math 
{
    class Program
    {
        static void Main(string[] args)
        {




              // AB HAM KARENGE MATH ME BHI BACKCHOOODI 0_o 



            /*  MATHMETICAL OPERATORS                               WORK                                                                     EXAMPLE 
                MAX (Maximum)                  Returns the larger of two numbers.                                                 Math.Max(3, 7) returns 7
                MIN (Minimum)                  Returns the smaller of two numbers.                                                Math.Min(3, 7) returns 3
                ABS (Absolute Value)           Returns the absolute value of a number.                                            Math.Abs(-5) returns 5
                SQRT (Square Root)             Returns the square root of a number.                                               Math.Sqrt(16) returns 4
                ROUND (Round)                  Rounds a number to the nearest integer or specified number of decimal places.      Math.Round(3.5) returns 4, Math.Round(3.4) returns 3
                POW (Power)                    Returns a number raised to the power of another.                                   Math.Pow(2, 3) returns 8
                CEILING (Ceiling)              Returns the smallest integer greater than or equal to a number.                    Math.Ceiling(3.2) returns 4
                FLOOR (Floor)                  Returns the largest integer less than or equal to a number.                        Math.Floor(3.7) returns 3
                TRUNCATE (Truncate)            Returns the integral part of a number, removing any fractional digits.             Math.Truncate(3.7) returns 3
                SIGN (Sign)                    Returns a value indicating the sign of a number.                                   Math.Sign(-5) returns -1,Math.Sign(0) returns 0, Math.Sign(5) returns 1
                EXP (Exponential)              Returns e raised to the specified power.                                           Math.Exp( 1) returns 2.71828
                LOG (Logarithm)                Returns the logarithm of a number to the specified base.                           Math.Log(100, 10) returns 2
                LOG10 (Logarithm Base 10)      Returns the base 10 logarithm of a number.                                         Math.Log10(100) returns 2
                SIN (Sine)                     Returns the sine of an angle.                                                      Math.Sin(Math.PI  / 2) returns 1
                COS (Cosine)                   Returns the cosine of an angle.                                                    Math.Cos(0    ) returns 1
                TAN (Tangent)                  Returns the tangent of an angle.                                                   Math.Tan(Math .PI  / 4) returns 1
                ASIN (Arc Sine)                Returns the angle whose sine is the specified number.                              Math.Asin(1) returns 1.5708 (which is π/2 radians)   
                    */        



            //-------------------------------C# Math Class----------------------------------------//
            

                int a = 3;
                int b = 6;
                
                //                                                                           MATHMETICAL OPERATORS                               WORK                                                                     EXAMPLE //
                Console.WriteLine(Math.Max(a, b)); // Output: 6                              MAX (Maximum)                  Returns the larger of two numbers.                                                 Math.Max(3, 7) returns 7
                Console.WriteLine(Math.Min(a, b)); // Output: 3                              MIN (Minimum)                  Returns the smaller of two numbers.                                                Math.Min(3, 7) returns 3                            
                Console.WriteLine(Math.Abs(-5)); // Output: 5                                ABS (Absolute Value)           Returns the absolute value of a number.                                            Math.Abs(-5) returns 5
                Console.WriteLine(Math.Sqrt(16)); // Output: 4                               SQRT (Square Root)             Returns the square root of a number.                                               Math.Sqrt(16) returns 4
                Console.WriteLine(Math.Round(3.5)); // Output: 4                             ROUND (Round)                  Rounds a number to the nearest integer or specified number of decimal places.      Math.Round(3.5) returns 4, Math.Round(3.4) returns 3
                Console.WriteLine(Math.Pow(a, b)); // Output: 729 (3 raised to               POW (Power)                    Returns a number raised to the power of another.                                   Math.Pow(2, 3) returns 8            
                Console.WriteLine(Math.Ceiling(3.2)); // Output: 4                           CEILING (Ceiling)              Returns the smallest integer greater than or equal to a number.                    Math.Ceiling(3.2) returns 4
                Console.WriteLine(Math.Floor(3.7)); // Output: 3                             FLOOR (Floor)                  Returns the largest integer less than or equal to a number.                        Math.Floor(3.7) returns 3
                Console.WriteLine(Math.Round(3.4)); // Output: 3                             ROUND (Round)                  Rounds a number to the nearest integer or specified number of decimal places.      Math.Round(3.5) returns 4, Math.Round(3.4) returns 3
                Console.WriteLine(Math.Truncate(3.7)); // Output: 3                          TRUNCATE (Truncate)            Returns the integral part of a number, removing any fractional digits.             Math.Truncate(3.7) returns 3
                Console.WriteLine(Math.Sign(-5)); // Output: -1                              SIGN (Sign)                    Returns a value indicating the sign of a number.                                   Math.Sign(-5) returns -1,Math.Sign(0) returns 0, Math.Sign(5) returns 1
                Console.WriteLine(Math.Sign(0)); // Output: 0                                SIGN (Sign)                    Returns a value indicating the sign of a number.                                   Math.Sign(-5) returns -1,Math.Sign(0) returns 0, Math.Sign(5) returns 1
                Console.WriteLine(Math.Sign(5)); // Output: 1                                SIGN (Sign)                    Returns a value indicating the sign of a number.                                   Math.Sign(-5) returns -1,Math.Sign(0) returns 0, Math.Sign(5) returns 1
                Console.WriteLine(Math.Exp(1)); // Output: 2.71828                           EXP (Exponential)              Returns e raised to the specified power.                                           Math.Exp( 1) returns 2.71828
                Console.WriteLine(Math.Log(100, 10)); // Output: 2                           LOG (Logarithm)                Returns the logarithm of a number to the specified base.                           Math.Log(100, 10) returns 2
                Console.WriteLine(Math.Log10(100)); // Output: 2                             LOG10 (Logarithm Base 10)      Returns the base 10 logarithm of a number.                                         Math.Log10(100) returns 2
                Console.WriteLine(Math.Sin(Math.PI / 2)); // Output: 1                       SIN (Sine)                     Returns the sine of an angle.                                                      Math.Sin(Math.PI  / 2) returns 1
                Console.WriteLine(Math.Cos(0)); // Output: 1                                 COS (Cosine)                   Returns the cosine of an angle.                                                    Math.Cos(0    ) returns 1
                Console.WriteLine(Math.Tan(Math.PI / 4)); // Output: 1                       TAN (Tangent)                  Returns the tangent of an angle.                                                   Math.Tan(Math .PI  / 4) returns 1  
                Console.WriteLine(Math.Asin(1)); // Output: 1.5708 (                         ASIN (Arc Sine)                Returns the angle whose sine is the specified number.                              Math.Asin(1) returns 1.5708 (which is π/2 radians)




                Console.Write("n= ");
                int n = int.Parse(Console.ReadLine() ?? "0"); // This will read the user input and convert it to an integer.
                BigInteger num = 1;
                int sum = 1;
                Console.Write("the sum 1");
                while (num < n)
                {
                    num ++;
                    sum *= num;
                    Console.Write(" + " * num);
                }
                Console.WriteLine(" = " * sum); // This will display the sum of the first n natural numbers. For example, if n is 5, it will display "the sum 1 + 2 + 3 + 4 + 5 = 15".

       
        }
    }
}
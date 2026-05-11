// use of if and else statements //

using System;
using System.ComponentModel;
namespace CSharpV8
{
    class Program
    {





        // ----------------------------------------------------use of function to check the age of a person and print the result accordingly---------------------------------------------------- //





        
        static void Main (string[] arges)


        { 
            int Adiii = 16;
            int Prabhat = 17;
            int Robin = 23;
            int Ghost = 24;
            int Rohan = 20;
            int Ruhiii = 24;
            int Farhan = 19;
            int khusi = 18;
            
            CheckAge(Adiii, "Adiii");
            CheckAge(Prabhat, "Prabhat");
            CheckAge(Robin, "Robin");
            CheckAge(Ghost, "Ghost");
            CheckAge(Rohan, "Rohan");
            CheckAge(Ruhiii, "Ruhiii");
            CheckAge(Farhan, "Farhan");
            CheckAge(khusi, "khusi");


            static void CheckAge(int age, string name)
            {
                if (age >= 18)
                {
                    Console.WriteLine(name + " Bade ho gye");
                }
                else
                {
                    Console.WriteLine(name + " Bachaa haiii tu Lode abhiii.");
                }
            }   






               //--------------------------------without using function-----------------------------// 





          if (Adiii >= 18)
            {
                Console.WriteLine("Adiii Bade ho gye");
            }
            else
            {
                Console.WriteLine("Adiii Bachaa haiii tu Lode abhiii.");
            }
          if (Prabhat >= 18)
            {
                Console.WriteLine("Prabhat Bade ho gye");
            }
            else
            {
                Console.WriteLine("Prabhat Bachaa haiii tu Lode abhiii.");
            } 



        //---------------------------------------------------- Use of else if statement to check the age of a person and print the result accordingly---------------------------------------------------- //



            if (Adiii >= 18)
            {
                Console.WriteLine("Adiii Bade ho gye");
            }
            else if (Adiii < 18)
            {
                Console.WriteLine("Adiii Bachaa haiii tu Lode abhiii.");
            }
             if (Prabhat >= 18)
            {
                Console.WriteLine("Prabhat Bade ho gye");
            }
            else if (Prabhat < 18)
            {
                Console.WriteLine("Prabhat Bachaa haiii tu Lode abhiii.");
             }
        
        

        //----------------------------------------------------use of Short Hand If Statement (Ternary Operator) to check the age of a person and print the result accordingly---------------------------------------------------- //



            Console.WriteLine(Adiii >= 18 ? "Adiii Bade ho gye" : "Adiii Bachaa haiii tu Lode abhiii.");
            Console.WriteLine(Prabhat >= 18 ? "Prabhat Bade ho gye" : "Prabhat Bachaa haiii tu Lode abhiii.");
            Console.WriteLine(Robin >= 18 ? "Robin Bade ho gye" : "Robin Bachaa haiii tu Lode abhiii.");
            Console.WriteLine(Ghost >= 18 ? "Ghost Bade ho gye" : "Ghost Bachaa haiii tu Lode abhiii.");
            Console.WriteLine(Rohan >= 18 ? "Rohan Bade ho gye" : "Rohan Bachaa haiii tu Lode abhiii.");
            Console.WriteLine(Ruhiii >= 18 ? "Ruhiii Bade ho gye" : "Ruhiii Bachaa haiii tu Lode abhiii.");
            Console.WriteLine(Farhan >= 18 ? "Farhan Bade ho gye" : "Farhan Bachaa haiii tu Lode abhiii.");
            Console.WriteLine(khusi >= 18 ? "khusi Bade ho gye" : "khusi Bachaa haiii tu Lode abhiii.");
            





        }
    }
} 
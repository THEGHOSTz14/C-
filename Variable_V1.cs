using System;
namespace CSharpV0
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //------------------------------C# Variables----------------------------------------//
            
            
            
            string name = "Ghost";
            Console.WriteLine("Hello, " + name + "!");

            int age = 20;
            Console.WriteLine("I am " + age + " years old.");

            double height = 1.75;
            Console.WriteLine("I am " + height + " meters tall.");

            bool isStudent = true;
            Console.WriteLine("Am I a student? " + isStudent);

            char grade = 'A';
            Console.WriteLine("My grade is: " + grade);



            // ---------------------------------------C# Constants----------------------------------------//


            const double PI = 3.14159; // This is a constant variable, its value cannot be changed.
            Console.WriteLine("The value of PI is: " + PI); 
            const int MAX_STUDENTS = 30; // This is a constant variable, its value cannot be changed.
            Console.WriteLine("The maximum number of students is: " + MAX_STUDENTS); 


            //---------------------------------------C# Display Variables----------------------------------------//


                string firstName = "John";
                Console.WriteLine("First Name: " + firstName);
                
                int a = 10;
                int b = 20;
                Console.WriteLine( a+b); // This will display the sum of x and y, which is 30.  


            //----------------------------------------C# Declare Multiple Variables----------------------------------------//   
            
                int Rohan = 6, Jojo = 9, Ghost = 3;
                Console.WriteLine(Rohan + Jojo + Ghost); // This will display the sum of Rohan, Jojo, and Ghost, which is 19.   

                int x, y, z;
                x = y = z = 3;
                Console.WriteLine(x + y + z); // This will display the sum of x, y, and z, which is 9.  



            //----------------------------------------C# Identifiers----------------------------------------//
                
                
                int kilometeraperhour = 140; //------Good-------
                int kmph = 140; //------better-------

            
            //----------------------------------------- C# Data Types----------------------------------------//


                int myNum = 5;               // Integer (whole number)
                double myDoubleNum = 5.99;   // Floating point number
                char myLetter = 'D';        // Character
                bool myBool = true;         // Boolean
                string myText = "Hello";    // String
                float myFloatNum = 5.75f;   // Float (floating point number with less precision than double)

                Console.WriteLine("Integer: " + myNum);
                Console.WriteLine("Double: " + myDoubleNum);
                Console.WriteLine("Character: " + myLetter);
                Console.WriteLine("Boolean: " + myBool);
                Console.WriteLine("String: " + myText);
                Console.WriteLine("Float: " + myFloatNum); 



        }
    }
}
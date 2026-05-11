/*usingSystem;
namespace System
{
    public partial struct String
    {
        public static implicit operator String(string value)
        {
            return new String(value);
        }

        public static implicit operator string(String value)
        {
            return value.ToString();
        }
    }
}   
*/

using System;
namespace CSharpv0_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
        //-------------------------------C# Strings----------------------------------------//
          string Name = "Ghost";
            Console.WriteLine(Name.ToUpper()); // This will convert the string to uppercase and display "GHOST".
            Console.WriteLine(Name.ToLower()); // This will convert the string to lowercase and display "ghost".
            Console.WriteLine(Name.Length); // This will display the length of the string, which is 5.
            Console.WriteLine(Name[0]); // This will display the first character of the string, which is 'G'.
            Console.WriteLine(Name[1]); // This will display the second character of the string,
            Console.WriteLine(Name[2]); // This will display the third character of the string,
            Console.WriteLine(Name[3]); // This will display the fourth character of the string,
            Console.WriteLine(Name[4]); // This will display the fifth character of the string, which is 't'.
            Console.WriteLine(Name.Contains("o")); // This will check if the string contains the letter 'o' and display "True".
            Console.WriteLine(Name.Contains("z")); // This will check if the string contains the letter
            Console.WriteLine(Name.StartsWith("G")); // This will check if the string starts with the letter 'G' and display "True".
            Console.WriteLine(Name.EndsWith("t")); // This will check if the string ends
            Console.WriteLine(Name.Replace("o", "a")); // This will replace the letter 'o' with 'a' and display "Ghast".
            Console.WriteLine(Name.Substring(1, 3)); // This will display a substring of
            Console.WriteLine(Name.IndexOf("o")); // This will display the index of the first occurrence of the letter 'o', which is 1.
            Console.WriteLine(Name.LastIndexOf("o")); // This will display the index of the last occurrence of the letter 'o', which is 1.
            Console.WriteLine(Name.Split('o')[0]); // This will split the string at the letter 'o' and display the first part, which is "Gh".
            Console.WriteLine(Name.Split('o')[1]); // This will split the string at the letter 'o' and display the second part, which is "st".



        //-------------------------------C# String Concatenation----------------------------------------//



            // BHAIII ISME KUC KHAAS NHI HOTA BSS BEHENCHOOO  KUC DO VARIABLES BNAO AUR UNKO EK DUSRE K CHIPKA DO 
            // THE STRING CONCATENATION OPERATOR (+) IS USED TO CONCATENATE STRINGS IN C#. IT COMBINES TWO OR MORE STRINGS INTO ONE STRING. 
            string firstName = "Johny";
            string lastName = "Singh";
            string fullName = firstName + " " + lastName; // This will concatenate the first name and last name with a space in between and store it in the variable fullName.
            Console.WriteLine(fullName); // This will display the full name, which is "JohNy Singh".     



        //-------------------------------- ADDING NUMBERS ------------------------------------------------//

        

            int a = 10;
            int b = 20;
            Console.WriteLine(a + b); // This will display the sum of a and b, which is 30.

            int P = ("9");
            int Q = ("6");
            Console.WriteLine(P + Q); // This will display the sum of P and Q, which is 15. However, since P and Q are strings, they will be concatenated instead of added as numbers, resulting in "96". To add them as numbers, you can convert them to integers using int.Parse() or Convert.ToInt32() before adding them. For example:
            int P = int.Parse("9");
            int Q = int.Parse("6");
            Console.WriteLine(P + Q); // This will display the sum of P and Q, which is 15.



        //-------------------------------C# String Interpolation----------------------------------------//

            // STRING INTERPOLATION IS A FEATURE IN C# THAT ALLOWS YOU TO EMBED EXPRESSIONS INSIDE STRING LITERALS. IT USES THE DOLLAR SIGN ($) BEFORE THE STRING AND CURLY BRACES ({}) TO ENCLOSE THE EXPRESSIONS. 
            string name = "Ghost";
            int age = 20;
            string message = $"Hello, my name is {name} and I am {age} years old."; // This will create a string that includes the values of the variables name and age using string interpolation.
            Console.WriteLine(message); // This will display the message, which is "Hello, my name is Ghost and I am 20 years old.".


        //-------------------------------C# Accessing Characters in a String----------------------------------------//

            string str = " whatspp Ghost!";
            Console.WriteLine(str[0]); // This will display the first character of the string, which is 'H'.
            Console.WriteLine(str[7]); // This will display the eighth character of the string, which is 'W'.
            Console.WriteLine(str[str.Length - 1]); // This will display the last character of the string, which is '!'.
                
                   
                    // ----- Indexof()--------//


            string Admin = " GodLGhost ";
            Console.WriteLine(Admin.IndexOf("G")); // This will display the index of the first occurrence of the letter 'G', which is 0.
            Console.WriteLine(Admin.LastIndexOf("G")); // This will display the index of the


                   // ----- Substring()--------//

            string Sub = "Hello, hell!";
            Console.WriteLine(Sub.Substring(0, 5)); // This will display a substring of the string starting from index 0 and having a length of 5, which is "Hello".
            Console.WriteLine(Sub.Substring(7, 4)); // This will display a substring of



                    // ----- Split()--------//
            
            
            
            string Split = "Hello, Robbin !";
            string[] parts = Split.Split(','); // This will split the string at the comma and
            Console.WriteLine(parts[0]); // This will display the first part of the split string, which is "Hello".
            Console.WriteLine(parts[1].Trim()); // This will display the second part of the split string, which is "World". The Trim() method is used to remove any leading or trailing whitespace from the second part.




        //-------------------------------C# Special Characters in Strings----------------------------------------//

             

            /* Escape Characters                       Result                        Description
               \'                                     '                             Single quote
               \"                                     "                             Double quote
               \\                                     \                             Backslash
               \n                                     (new line)                    New line
               \t                                     (tab)                         Tab
               \r                                     (carriage return)             Carriage return
               \b                                     (backspace)                   Backspace
               \f                                     (form feed)                   Form feed
            */
            


              string specialChars = "This is a string with special characters:\nNew line, \tTab, \"Double quotes\", \'Single quotes\', \\Backslash\\";

            Console.WriteLine(specialChars); // This will display the string with special characters, including a new line, a tab, double quotes, single quotes, and backslashes.

            
























































        }
    }
}
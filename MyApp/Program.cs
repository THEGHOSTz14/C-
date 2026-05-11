using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your age soldier: ");
        string age = Console.ReadLine() ?? "";

        Console.WriteLine("Your age is: " + age);
    }
}
/*using System;
using System.Numerics;

Console.Write("n= ");
int n = int.Parse(Console.ReadLine() ?? "0");

int num = 1;
BigInteger sum = 1;

Console.Write("the product 1");

while (num < n)
{
    num++;
    BigInteger prev = sum;
    sum *= num;

    Console.Write(" + " + num);
    Console.WriteLine($"\n{prev} * {num} = {sum}");
}

Console.WriteLine(" = " + sum);*/



using System;
using System.Numerics;

Console.Write("n= ");
int n = int.Parse(Console.ReadLine() ?? "0");

int num = 1;
BigInteger sum = 1;

Console.Write("the product 1");

while (num < n)
{
    num++;
    sum *= num;
    Console.Write(" * " + num);
}

Console.WriteLine(" = " + sum);
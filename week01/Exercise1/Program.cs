using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to you first exercise of cse210, enter the following information:");
        Console.Write("What is your first name? ");
        string first = Console.ReadLine();

        Console.Write("What is your last name? ");
        string last = Console.ReadLine();

        Console.WriteLine($"Your name is {last}, {first} {last}.");
    }

}
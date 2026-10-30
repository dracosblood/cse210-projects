using System;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        displayWelcome();
        string userName = promptUserName();
        int userNumber = promptUserNumber();
        int userSquare = squareNumber(userNumber);
        displayResult(userName,userSquare);
   
    }
    static void displayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string promptUserName()
    {
        Console.Write("Please enter your name for conitue. ");
        string name = Console.ReadLine();
        return name;
    }

    static int promptUserNumber()
    {
        Console.Write("Enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }
    static int squareNumber(int number)
    {
        int square = number * number;
        return square;
    }
    static void displayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square for your number is {square}");
    }
}   
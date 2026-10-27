using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Hello, please indicate your name for can calculate your Grade: ");
        string name = Console.ReadLine();
        Console.Write($"{name}, What is your grade percentage in CSE 110? ");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);

        string letter = "";

        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"{name}, Your grade is: {letter}");
        
        if (percent >= 70)
        {
            Console.WriteLine("Congratulations You passed! enjoy you can continue in CSE 210!");
        }
        else
        {
            Console.WriteLine($"{name}, Better luck next time! you need passed the CSE 110 first, for continue to CSE 210!");
        }
    }
}
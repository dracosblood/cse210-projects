using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers;
        numbers = new List<int>();
        int userNum = -1;
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        
        //while for the list
        while (userNum != 0)
        {

            Console.Write("Enter a list of number, type '0' when finished.");

            string userReply = Console.ReadLine();
            userNum = int.Parse(userReply);

            if (userNum != 0)
            {
                numbers.Add(userNum);
            }

            
        }

        //sum
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");

        //average
        float average = ((float)sum)/numbers.Count;
        Console.WriteLine($"The average is: {average}");

        //max number
        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The largest number is: {max}");

        //min number positive.
        int min = int.MaxValue;
        foreach (int number in numbers)
        {
            if (number > 0 && number < min)
            {
                min = number;
            }
        }
        Console.WriteLine($"The smallest positive number is: {min}");
            
        
    }
}
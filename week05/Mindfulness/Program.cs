//BYU Pathway Worldwide
//Darwin J Tovar
//Activity program (Mindfulness Program)
//in this program i used the principles of abstraction encasulaption and inheritance.
//for the creatyvity i make a funtion that count the numbers of list, refleting, or breath make in a sesion.


using System;

class Program
{
    static void Main(string[] args)
    {
        string choice = "";
        int breathingCount = 0;
        int reflectingCount = 0;
        int listingCount = 0;

        while (choice != "4")
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                BreathingActivity breathing = new BreathingActivity();
                breathing.Run();
                breathingCount++;
            }
            else if (choice == "2")
            {
                ReflectingActivity reflecting = new ReflectingActivity();
                reflecting.Run();
                reflectingCount++;
            }
            else if (choice == "3")
            {
                ListingActivity listing = new ListingActivity();
                listing.Run();
                listingCount++;
            }
            else if (choice == "4")
            {
                int total = breathingCount + reflectingCount + listingCount;
                Console.WriteLine();
                Console.WriteLine("Session Summary:");
                Console.WriteLine($"  Breathing Activity: {breathingCount}");
                Console.WriteLine($"  Reflecting Activity: {reflectingCount}");
                Console.WriteLine($"  Listing Activity: {listingCount}");
                Console.WriteLine($"  Total completed: {total}");
            }
            else 
            {
                Console.WriteLine("Invalid option. Press Enter to try again...");
                Console.ReadLine();
            }
        }
    }
}
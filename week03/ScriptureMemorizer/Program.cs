// Create for Darwin J Tovar.
//for CSE210 in BYU Pathway worldwide.
// this program content:
// 1. I create a list containing several scriptures, and use a random class to select one at random.
// 2. Adding the scritures.
// 3. Select ramdon scriture.
// 4. Main loop that uses the selected random write operation to proceed with the function.
// It is checked whether all the words are hidden.
// Here, we hide words at random this could be a single word or several, up to a maximum of 3 words.

using System;

class Program
{
    static void Main(string[] args)
    {

        List<Scriptures> scriptures = new List<Scriptures>();

        
        scriptures.Add(new Scriptures(
            new Reference("Proverbs", 3, 5, 6), 
            "Trust in the Lord with all your heart, and do not lean on your own understanding."
        ));

        scriptures.Add(new Scriptures(
            new Reference("Jhon", 3, 16), 
            "For God so loved the world that He gave His only begotten Son."
        ));

        scriptures.Add(new Scriptures(
            new Reference("Mosíah", 2, 17), 
            "When you are in the service of your fellow beings, you are only in the service of your God."
        ));

        
        Random random = new Random();
        int randomIndex = random.Next(scriptures.Count);
        Scriptures selectedScripture = scriptures[randomIndex];

        
        while (true)
        {
            Console.Clear();

            Console.WriteLine(selectedScripture.GetDisplayText());
            Console.WriteLine();

            
            if (selectedScripture.IsCompletelyHidden())
            {
                Console.WriteLine("Congratulations! You have memorized the script.");
                break;
            }

            Console.WriteLine("Press Enter to continue or type 'quit' to exit:");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }
            
            int randomCount = random.Next(1, 4);
            selectedScripture.HideRandomWords(randomCount);
        }
        Console.Clear();
    }

}
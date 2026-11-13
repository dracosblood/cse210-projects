// Create for Darwin J Tovar.
//for CSE210 in BYU Pathway worldwide.

using System;

class Program
{
    static void Main(string[] args)
    {
// 1. I create a list containing several scriptures, and use a random class to select one at random.
        List<Scripture> scriptures = new List<Scripture>();

        // 2. Adding the scritures.
        scriptures.Add(new Scripture(
            new Reference("Proverbios", 3, 5, 6), 
            "Trust in the Lord with all your heart, and do not lean on your own understanding."
        ));

        scriptures.Add(new Scripture(
            new Reference("Juan", 3, 16), 
            "For God so loved the world that He gave His only begotten Son."
        ));

        scriptures.Add(new Scripture(
            new Reference("Mosíah", 2, 17), 
            "When you are in the service of your fellow beings, you are only in the service of your God."
        ));

        // 3. Select ramdon scriture.
        Random random = new Random();
        int randomIndex = random.Next(scriptures.Count);
        Scripture selectedScripture = scriptures[randomIndex];

        // 4. Main loop that uses the selected random write operation to proceed with the function.
        while (true)
        {
            Console.Clear();

            Console.WriteLine(selectedScripture.GetDisplayText());
            Console.WriteLine();

            // It is checked whether all the words are hidden.
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
            // Here, we hide words at random this could be a single word or several, up to a maximum of 3 words.
            int randomCount = random.Next(1, 4);
            selectedScripture.HideRandomWords(randomCount);
        }
        Console.Clear();
    }

}
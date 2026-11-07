public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;
    DateTime dateTime = DateTime.Now; 
    

    public void DisplayEntry()
    {   
        string dateText = dateTime.ToShortTimeString();
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Entry: {_entryText}");
    }
}
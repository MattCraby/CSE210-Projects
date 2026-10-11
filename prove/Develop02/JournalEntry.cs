using System;

class JournalEntry
{
    
    public string _date;
    public string _prompt;
    public string _response;

    public JournalEntry () {}


    public JournalEntry(string date, string prompt, string response)
    {
        _date = date;
        _prompt = prompt;
        _response = response;
    }


    public void Display()
    {
        Console.Write($"{_date} - {_prompt}" );
        Console.WriteLine($"{_response}, ");
        Console.WriteLine();
    }


    public void Create()
    {
        string [] prompts =
        {
            "How was your day",
            "What made you happy today?",
            "What made today different from yesterday?",
            "What did you do today?",
            "What did you learn today?",
            "How did you push yourself today?",
            "Was there something you missed out on today?",
            "What made today hard?",
            "What made today easy?",
            "Tell me about the best thing that happened today",
            "Tell me about the worst thing that happened today"
        };
        int random = Random.Shared.Next(0,11);
        _date = DateTime.Now.ToString();
        _prompt = prompts[Random.Shared.Next(prompts.Length)];

        Console.WriteLine($"{_prompt}");
        _response = Console.ReadLine();
    }


    public string ToFileString()
    {
        return $"{_date}#{_prompt}#{_response}";
    }

    public string CreateFileSystemString()

    {
        string outputString = "";
        outputString = $"{_date}#{_prompt}#{_response}";
        return outputString;
    }


}
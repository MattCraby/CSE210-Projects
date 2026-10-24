using System.Diagnostics.Metrics;
using System.Runtime.CompilerServices;

class Scripture
{
    private List <Word> _words;
    private ScriptureReferance _reference;


    public Scripture(string Bookname, int chapter, int verse, string text)
        : this(new ScriptureReferance(Bookname, chapter, verse), text)
    {
    }


    public Scripture(string Bookname, int chapter, int startVerse, int endVerse, string text)
        : this(new ScriptureReferance(Bookname, chapter, startVerse, endVerse), text)
    {
    }


    public Scripture(ScriptureReferance reference, string text)
    {
        _reference = reference;
        _words = ConvertToWords(text);
    }


    public bool HideSomeWords()
    {
            Random rng = new Random();
            int numberOfHidden = NumberOfHiddenWords();

            if (numberOfHidden == _words.Count)
            {
                return true;
            }

            int wordsLeft = _words.Count - numberOfHidden;
            int toHide = 3;
            if (wordsLeft < 3)
            {
                toHide = wordsLeft;
            }

            int hiddenSoFar = 0;
            while (hiddenSoFar < toHide)
            {
                int randomNumber = rng.Next(_words.Count);

                if (!_words[randomNumber].IsHidden())
                {
                    _words[randomNumber].Hide();
                    hiddenSoFar++;
                }
            }

            return NumberOfHiddenWords() == _words.Count;
    }


    private int  NumberOfHiddenWords()
    {
        int counter = 0;
        foreach(Word word in _words)
        {
            if(word.IsHidden())
            {
                counter ++;
            }
            
        }
        return counter;
    }


    public void ShowScripture()
    {
        _reference.DisplayScriptureReference();
        foreach(Word word in _words)
        {
            word.Display();
        }
        Console.WriteLine();
    }
    

    public string GetScriptureReference()
{
    return _reference.GetScriptureReference();
}


    private List<Word> ConvertToWords(string text)
    {
        List<Word> tempWords = new List<Word>();

        string[] words = text.Split(' ');
        foreach(string word in text.Split(' '))
        {
            Word tempWord = new Word(word);
            tempWords.Add(tempWord);
        }
        return tempWords;
    }

}
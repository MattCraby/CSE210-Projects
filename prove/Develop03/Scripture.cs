class Scripture
{
    List <Word> _words;

    // TODO: Add scripture referance

    public Scripture(string Bookname, int chapter, int verse, string text)
    {
        _words = ConvertToWords(text);
    }


    public Scripture(string Bookname, int chapter, int startVerse, int endVerse, string text)
    {
        
    }


    public void ShowScripture()
    {
        foreach(Word word in _words)
        {
            word.Display();
        }
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
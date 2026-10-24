class ScriptureReferance
{
    private string _bookName;
    private int _chapter;
    private int[] _verse;

    public ScriptureReferance(string name, int chapter, int verse)
    {
        _bookName = name;
        _chapter = chapter;
        _verse = new int[] { verse };;
        
    }

    
    public ScriptureReferance(string name, int chapter, int startVerse, int endVerse)
    {
        _bookName = name;
        _chapter = chapter;
        _verse = new int[] { startVerse, endVerse };
    }


    private string GetScriptureReferanceString()
    {
        if (_verse.Length == 1)
        {
            return $"{_bookName} {_chapter}:{_verse[0]}";
        }
        else
        {
            return $"{_bookName} {_chapter}:{_verse[0]}-{_verse[1]}";
        }
    }

    public string GetScriptureReference()
    {
        return GetScriptureReferanceString();
    }

    public void DisplayScriptureReference()
        {
            Console.WriteLine(GetScriptureReferanceString());
        }

}
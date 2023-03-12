class Reference
{
    private string _book;
    private int _chapter, _verse;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }
    public void DisplayReference()
    {
        Console.WriteLine($"{_book} {_chapter}:{_verse}");
    }
    public string GetReferenceString()
    {
        return $"{_book} {_chapter}:{_verse}";
    }
    public string GetBook()
    {
        return _book;
    }
    public void SetBook(string bookName)
    {
        _book = bookName;
    }
    public int GetChapter()
    {
        return _chapter;
    }
    public void SetChapter(int chapterNumber)
    {
        _chapter = chapterNumber;
    }
    public int GetVerse()
    {
        return _verse;
    }
    public void SetVerse(int verseNumber)
    {
        _verse = verseNumber;
    }
    
}  
public class Reference
{
    private readonly string _book;
    private readonly int _chapter;
    private readonly int _verseStart;
    private readonly int _verseEnd;

    public Reference(string book, int chapter, int verse)
    {
        if (chapter <= 0 || verse <= 0) throw new ArgumentException("Chapter and verse must be positive.");
        _book = book;
        _chapter = chapter;
        _verseStart = verse;
        _verseEnd = verse;
    }

    public Reference(string book, int chapter, int verseStart, int verseEnd)
    {
        if (chapter <= 0 || verseStart <= 0 || verseEnd < verseStart)
            throw new ArgumentException("Invalid chapter or verse range.");
        _book = book;
        _chapter = chapter;
        _verseStart = verseStart;
        _verseEnd = verseEnd;
    }

    public string GetDisplayText()
    {
        return _verseStart == _verseEnd
            ? $"{_book} {_chapter}:{_verseStart}"
            : $"{_book} {_chapter}:{_verseStart}-{_verseEnd}";
    }
}
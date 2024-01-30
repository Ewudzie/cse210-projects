using System;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _startVerse;
    private int _endVerse;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;

    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }

        public string GetDisplayText()
        {
            return "";
        }

        public void SetBook(string book)
        {
            _book = book;
        }
        public void SetChapter(int chapter)
        {
            _chapter = chapter;
        }
        public void SeVerse(int verse)
        {
            _verse = verse;
        }

        public void SetStartVerse(int startVerse)
        {
            _startVerse = startVerse;
        }
        public void SetEndVerse(int endVerse)
        {
            _endVerse = endVerse
        }

}
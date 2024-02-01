using System;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;

    }

    public Reference(string book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

        public string GetDisplayText()
        {
            string book = _book;
            string chapter = _chapter.ToString();
            string verse = _verse.ToString();
            string endVerse = _endVerse.ToString();

            return $"{book} {chapter}:{verse}";
        }

        public void SetBook(string book)
        {
            _book = book;
        }
        public void SetChapter(int chapter)
        {
            _chapter = chapter;
        }
        public void SetVerse(int verse)
        {
            _verse = verse;
        }

        public void SetEndVerse(int endVerse)
        {
            _endVerse = endVerse;
        }

}
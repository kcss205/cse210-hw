using System;
class Reference

{

    private string Book { get; set; }
    private int Chapter { get; set; }
    private int StartVerse { get; set; }
    private int EndVerse { get; set; }

    public Reference(string book, int chapter, int verse)
    {
        Book = book;
        Chapter = chapter;
        StartVerse = verse;
        EndVerse = verse;

    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        Book = book;
        Chapter = chapter;
        StartVerse = startVerse;
        EndVerse = endVerse;
    }

    public string GetBok()
    {
        return Book;

    }

    public int GetChapter()
    {
        return Chapter;

    }

    public int GetStartVerse()
    {
        return StartVerse;
        
    }

    public int GetEndVerse()
    {
        return EndVerse;
        
    }

    public override string ToString()
    {
        if (StartVerse == EndVerse)
        {
            return $"{Book} {Chapter}:{StartVerse}";
        }
        else
        {
            return $"{Book} {Chapter}:{StartVerse}-{EndVerse}";
        }
    }
}
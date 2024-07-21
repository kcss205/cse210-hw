using System;

class Book : Entity
{
    public string Title { get; set; }
    public string Author { get; set; }
    public Progress Progress { get; set; }

    public Book(string title, string author)
    {
        Title = title;
        Author = author;
        Progress = new Progress();
    }

    public override string Tostring()
    {
        return$"Title: {Title}, Author; {Author}, Progress; {Progress}";
    }
}
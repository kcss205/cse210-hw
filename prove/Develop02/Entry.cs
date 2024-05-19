using System;

public class Entry
{
    public string Prompt { get; }
    public string Response { get; }
    public DateTime Date { get; }

    public Entry(string prompt, string response, DateTime date)
    {
        Prompt = prompt;
        Response = response;
        Date = date;
    }

    public override string ToString()
    {
        return $"Date: {Date}\nPrompt: {Prompt}\nResponse: {Response}\n";
    }

    public string ToFileFormat()
    {
        return $"{Date}|{Prompt}|{Response}";
    }

    public static Entry FromFileFormat(string fileLine)
    {
        string[] parts = fileLine.Split('|');
        DateTime date = DateTime.Parse(parts[0]);
        string prompt = parts[1];
        string response = parts[2];
        return new Entry(prompt, response, date);
    }
}
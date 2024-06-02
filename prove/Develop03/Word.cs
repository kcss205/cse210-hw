using System;
class Word

{
    private string Text{ get; set; }
    private bool Hidden { get; set; }

    public Word(string text)
    {
        Text = text;
        Hidden = false;
    }

    public void Hide()
    {
        Hidden = true;
    }

    public bool WordHidden()
    {
        return Hidden;
    }

    public override string ToString()
    {
        return Hidden ? "_____" : Text;
    }
}
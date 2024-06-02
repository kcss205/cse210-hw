using System;
class Scripture

{
    private Reference Reference { get; set; }
    private List<Word> Words { get; set; }

    public Scripture(Reference reference, string text)
    {
        Reference =  reference;
        Words = text.Split(' ').Select(word => new Word(word)).ToList();

    }

    public void HideRandomWords(int count)
    {
        Random random = new Random();
        int hiddenCount = 0;

        while (hiddenCount < count)
        {
            int index = random.Next(Words.Count);
            if (!Words[index].WordHidden())
            {
                Words[index].Hide();
                hiddenCount++;
            }
        }
    }

    public bool AllWordsHidden()
    {
        return Words.All(word => word.WordHidden());
    }

    public override string ToString()
    {
        return $"{Reference}\n{string.Join(' ', Words)}";
    }
}
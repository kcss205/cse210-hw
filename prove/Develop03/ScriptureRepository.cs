using System;

class ScriptureRepository
{
    private List<Scripture> Scriptures { get; set; }
    private Random Random { get; set; }

    public ScriptureRepository()
    {
        Scriptures = new List<Scripture>
        {
            new Scripture(new Reference("John", 7, 17), "If any man will do his will, he shall know of the doctrine, whether it be of God, or whether I speak of myself."),
            new Scripture(new Reference("Jeremiah", 1, 4, 5), "Then the word of the Lord came unto me, saying, Before I formed thee in the belly I knew thee; and before thou camest forth out of the womb I sanctified thee, and I ordained thee a prophet unto the nations."),
            new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths."),
            new Scripture(new Reference("Moses", 1, 39), "For behold, this is my work and my glory—to bring to pass the immortality and eternal life of man."),
            new Scripture(new Reference("Isaiah", 1, 18), "Come now, and let us reason together, saith the Lord: though your sins be as scarlet, they shall be as white as snow; though they be red like crimson, they shall be as wool."),
            new Scripture(new Reference("Psalm", 24, 3, 4), "Who shall ascend into the hill of the Lord? or who shall stand in his holy place? He that hath clean hands, and a pure heart; who hath not lifted up his soul unto vanity, nor sworn deceitfully.")
        };
        Random = new Random();
    }

    public Scripture GetRandomScripture()
    {
        int index = Random.Next(Scriptures.Count);
        return Scriptures[index];
    }
}
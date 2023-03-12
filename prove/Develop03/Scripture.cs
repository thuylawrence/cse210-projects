class Scripture
{
    private List<Word> _words = new List<Word>();
    private Reference _reference; 
    
    private List<string> _scriptureList = new List<string>()
    {
        "Nephi$1$3$And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.",
        "2Nephi$31$20$Wherefore, ye must press forward with a steadfastness in Christ, having a perfect brightness of hope, with a love for God and of all men. Wherefore, if ye shall press forward, feasting upon the word of Christ, and endure to the end, behold, thus saith the Father: Ye shall have eternal life.",
        "Doctrine and Covernants$1$28$And inasmuch as they were humble they might be made strong, and blessed from on high, and receive knowledge from time to time.",
        "Enos$1$12$And it came to pass that after I had prayed and labored with all diligence, the Lord said unto me: I will grant unto thee according to thy desires, because of thy faith.",
        "2Nephi$26$29$And now behold, I say unto you that the right way is to believe in Christ, deny him not; and Christ is the Holy One of Israel; wherefore ye must bow down before him, and worship him with all your might, mind, and strength, and your whole soul; and if ye do this ye shall in nowise be cast out."
    };

    public Scripture()
    {
        Random random = new Random();
        string selectedScripture = _scriptureList[random.Next(_scriptureList.Count())];
        string[] splitScripture = selectedScripture.Split("$");
        _reference = new Reference(splitScripture[0], int.Parse(splitScripture[1]), int.Parse(splitScripture[2]));
        // foreach (string word in splitScripture[3].Split(" "))
        // {
        //     Word newWord = new Word(word);
        //     _words.Add(newWord);

        // }
        _words.AddRange(splitScripture[3].Split(" ").Select(_ => new Word(_)));
    }
    
    public void DisplayScripture()
    {
        Console.WriteLine(_reference.GetReferenceString());
       foreach (var word in _words)
       {
        Console.Write(word.GetWord()+ " ");
        
       }
       Console.WriteLine();
    }
    public bool AllWordHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.GetHidden())
            {
                return false;
            }
        }
        return true;
    }

    public void HideWords()
    {
        
        Random random = new Random();
        

        for (int i = 0; i <3;)
        {
            int index = random.Next(0,_words.Count());
            
            if (!_words[index].GetHidden())
            {
                i++;
               _words[index].HideWord(); 
            }
            if (AllWordHidden())
            {
                i = 3;
            }
            
        }
            

        }

    


}
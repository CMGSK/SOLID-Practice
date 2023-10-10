namespace SolidLibrary;

public class Anime : Media
{
    public int Episodes { get; set; }
    
    public void TalkAbout()
    {
        Console.WriteLine($"{Title} is written by {Writer.Name}. It has {Episodes} episodes. It was released in {ReleaseDate:d}");
    }
}
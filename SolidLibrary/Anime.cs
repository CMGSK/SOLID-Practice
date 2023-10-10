namespace SolidLibrary;

public class Anime : IEpisodicMedia
{
    public string Title { get; set; }
    public DateTime ReleaseDate { get; set; }
    public Writer Writer { get; set; }
    
    public int Episodes { get; set; }
    
    public void TalkAbout()
    {
        Console.WriteLine($"{Title} is written by {Writer.Name}. It has {Episodes} episodes. It was released in {ReleaseDate:d}");
    }
}
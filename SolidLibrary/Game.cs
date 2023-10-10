namespace SolidLibrary;

public class Game : Media
{
    public int Length { get; set; }
    public void TalkAbout()
    {
        Console.WriteLine($"{Title} is written by {Writer.Name}. It takes {Length} hours to beat. It was released in {ReleaseDate:d}");
    }
}
namespace SolidLibrary;

public class VisualNovel : Game
{
    public void TalkAbout()
    {
        Console.WriteLine($"{Title} is written by {Writer.Name}. It takes {Length} hours to read. It was released in {ReleaseDate:d}");
    }
}

namespace SolidLibrary;

public class VisualNovel : IMedia
{
    public int Length {get; set;}
    public string Title {get; set;}
    public DateTime ReleaseDate {get; set;}
    public Writer Writer {get; set;}

    public void TalkAbout()
    {
        Console.WriteLine($"{Title} is written by {Writer.Name}. It takes {Length} hours to beat. It was released in {ReleaseDate:d}");
    }
}
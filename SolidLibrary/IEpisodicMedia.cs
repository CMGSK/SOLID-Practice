
namespace SolidLibrary;

public interface IEpisodicMedia
{
    public string Title { get; set; }
    public DateTime ReleaseDate { get; set; }
    public Writer Writer { get; set; }
    
    public int Episodes { get; set; }

    public void TalkAbout();
}
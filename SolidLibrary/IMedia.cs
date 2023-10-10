namespace SolidLibrary;

public interface IMedia
{
    public string Title { get; set; }
    public DateTime ReleaseDate { get; set; }
    public Writer Writer { get; set; }
    public int Length { get; set; }
    
    public void TalkAbout();
}
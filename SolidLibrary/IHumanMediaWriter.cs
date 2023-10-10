namespace SolidLibrary;

public interface IHumanMediaWriter : IMediaWriter, IPerson
{
    public string Name { get; set; }
    public int Age { get; set; }
    public int MediaWritten { get; set; }
    
    public void WriteMedia();
}
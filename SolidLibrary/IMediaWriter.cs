namespace SolidLibrary;

public interface IMediaWriter
{
    public int MediaWritten { get; set; }
    
    public void WriteMedia();
}

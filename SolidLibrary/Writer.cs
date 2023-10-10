namespace SolidLibrary;

public class Writer : IHumanMediaWriter
{
    public string Name { get; set; }
    public int Age { get; set; }
    public int MediaWritten{get; set;}

    public void WriteMedia()
    {
        Console.WriteLine("Semen");
    }


}
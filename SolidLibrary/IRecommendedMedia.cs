namespace SolidLibrary;

public interface IRecommendedMedia 
{
    public IMediaConsumer By { get; set; }
    public IMedia Media { get; set; }

}

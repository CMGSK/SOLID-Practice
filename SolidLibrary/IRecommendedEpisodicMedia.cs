namespace SolidLibrary;

public interface IRecommendedEpisodicMedia
{
    public IMediaConsumer By { get; set; }
    public IEpisodicMedia EpisodicMedia { get; set; }
}


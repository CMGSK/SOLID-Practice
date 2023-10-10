namespace SolidLibrary;

public class RecommendedEpisodicMedia : IRecommendedEpisodicMedia
{
    public IMediaConsumer By { get; set; }
    public IEpisodicMedia EpisodicMedia { get; set; }
}

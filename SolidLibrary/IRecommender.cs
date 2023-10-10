namespace SolidLibrary;

public interface IRecommender 
{
    public void RecommendMedia(IMediaConsumer mediaConsumer, IMedia media);
    public void RecommendEpisodicMedia(IMediaConsumer mediaConsumer, IEpisodicMedia recommendedEpisodicMedia);

}
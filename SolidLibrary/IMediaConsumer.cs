namespace SolidLibrary;

public interface IMediaConsumer : IPerson 
{
    public List<IMedia> ConsumedMedia {get; set;}
    public List<IEpisodicMedia> ConsumedEpisodicMedia {get; set;}
    public List<IRecommendedMedia> RecommendedMedia {get; set;}
    public List<IRecommendedEpisodicMedia> RecommendedEpisodicMedia {get; set;}

    public void ConsumeMedia(IMedia media);

    // SOLID COMPLIATN
    // public void ConsumeMedia(IEpisodicMedia episodicMedia);
    public void ConsumeEpisodicMedia(IEpisodicMedia episodicMedia);
    
}
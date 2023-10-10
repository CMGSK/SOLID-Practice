using Microsoft.VisualBasic;

namespace SolidLibrary;

public class MediaConsumer : IMediaConsumer, IRecommender
{
    public string Name { get; set; }
    public int Age { get; set; }

    public List<IMedia> ConsumedMedia {get; set;} = new();
    public List<IEpisodicMedia> ConsumedEpisodicMedia {get; set;} = new();
    public List<IRecommendedMedia> RecommendedMedia {get; set;} = new();
    public List<IRecommendedEpisodicMedia> RecommendedEpisodicMedia {get; set;} = new();

    public void ConsumeMedia(IMedia media)
    {
        ConsumedMedia.Add(media);
        Console.WriteLine($"{Name} consumed {media.Title}");
    }

    public void ConsumeEpisodicMedia(IEpisodicMedia episodicMedia)
    {
        ConsumedEpisodicMedia.Add(episodicMedia);
        Console.WriteLine($"{Name} consumed {episodicMedia.Title}");
    }

    public void RecommendMedia(IMediaConsumer mediaConsumer, IMedia media)
    {
        if(!ConsumedMedia.Select(e => e.Title).Contains(media.Title))
        {
            Console.WriteLine("Cant recommend a non consumed media");
            return;
        }
        if(mediaConsumer.RecommendedMedia.Exists(e => e.Media.Title == media.Title && e.By.Name == Name))
        {
            Console.WriteLine("Cant recommend multiple times");
            return;
        }
       var addition = new RecommendedMedia
       {
            By = this,
            Media = media
       };
       RecommendedMedia.Add(addition); 
    }

    public void RecommendEpisodicMedia(IMediaConsumer mediaConsumer, IEpisodicMedia episodicMedia)
    {
        if(!ConsumedEpisodicMedia.Select(e => e.Title).Contains(episodicMedia.Title))
        {
            Console.WriteLine("Cant recommend a non consumed media");
            return;
        }
        if(mediaConsumer.RecommendedEpisodicMedia.Exists(e => e.EpisodicMedia.Title == episodicMedia.Title && e.By.Name == Name))
        {
            Console.WriteLine("Cant recommend multiple times");
            return;
        }
       var addition = new RecommendedEpisodicMedia
       {
            By = this,
            EpisodicMedia = episodicMedia
       };
       RecommendedEpisodicMedia.Add(addition); 
    }
}
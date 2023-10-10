namespace SolidLibrary;

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public List<VisualNovel> VisualNovelConsumed { get; set; } = new List<VisualNovel>();
    public List<Game> GamesConsumed { get; set; } = new List<Game>();
    public List<Anime> AnimeConsumed { get; set; } = new List<Anime>();

    public List<RecommendedGame> RecommendedGames { get; set; } = new List<RecommendedGame>();
    public List<RecommendedAnime> RecommendedAnimes { get; set; } = new List<RecommendedAnime>();
    public List<RecommendedVisualNovel> RecommendedVisualNovels { get; set; } = new List<RecommendedVisualNovel>();

    public void ConsumeVisualNovel(VisualNovel visualNovel)
    {
        VisualNovelConsumed.Add(visualNovel);
        Console.WriteLine($"{Name} consumed {visualNovel.Title}");
    }
    
    public void ConsumeGame(Game game)
    {
        GamesConsumed.Add(game);
        Console.WriteLine($"{Name} consumed {game.Title}");
    }
    
    public void ConsumeAnime(Anime anime)
    {
        AnimeConsumed.Add(anime);
        Console.WriteLine($"{Name} consumed {anime.Title}");
    }

    public void RecommendVisualNovel(Person person, VisualNovel visualNovel)
    {
        if (!VisualNovelConsumed.Select(x => x.Title).Contains(visualNovel.Title))
        {
            Console.WriteLine($"{Name} can not recommed {visualNovel.Title} since it's not in their consumed collection");
            return;
        }
        
        if (person.VisualNovelConsumed.Select(x => x.Title).Contains(visualNovel.Title))
        {
            Console.WriteLine($"{person.Name} already consumed {visualNovel.Title}");
            return;
        }
        
        if (person.RecommendedVisualNovels.Select(x => x.VisualNovel.Title).Contains(visualNovel.Title) && person.RecommendedVisualNovels.Exists(x => x.By.Name == Name))
        {
            Console.WriteLine($"{Name} already recommended {visualNovel.Title} to {person.Name}");
            return;
        }
        
        person.RecommendedVisualNovels.Add(new RecommendedVisualNovel
        {
            VisualNovel = visualNovel,
            By = this
        });
        
        Console.WriteLine($"{Name} recommended {person.Name} {visualNovel.Title}");
    }
    
    public void RecommendAnime(Person person, Anime anime)
    {
        if (!AnimeConsumed.Select(x => x.Title).Contains(anime.Title))
        {
            Console.WriteLine($"{Name} can not recommed {anime.Title} since it's not in their consumed collection");
            return;
        }
        
        if (person.AnimeConsumed.Select(x => x.Title).Contains(anime.Title))
        {
            Console.WriteLine($"{person.Name} already consumed {anime.Title}");
            return;
        }
        
        if (person.RecommendedAnimes.Select(x => x.Anime.Title).Contains(anime.Title) && person.RecommendedAnimes.Exists(x => x.By.Name == Name))
        {
            Console.WriteLine($"{Name} already recommended {anime.Title} to {person.Name}");
            return;
        }
        
        person.RecommendedAnimes.Add(new RecommendedAnime
        {
            Anime = anime,
            By = this
        });
        
        Console.WriteLine($"{Name} recommended {person.Name} {anime.Title}");
    }
}
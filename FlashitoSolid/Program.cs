using SolidLibrary;

#region Writers
var uminekoWriter = new Writer
{
    Name = "Ryukishi07",
    Age = 49
};

var steinsGateWriter = new Writer
{
    Name = "Chiyomaru Shikura",
    Age = 53
};
#endregion

#region Media
var umineko = new VisualNovel
{
    Title = "Umineko",
    Writer = uminekoWriter,
    Length = 300,
    ReleaseDate = DateTime.Parse("7/17/2007")
};

var chaosHead = new VisualNovel
{
    Title = "Chaos;Head",
    Writer = steinsGateWriter,
    Length = 40,
    ReleaseDate = DateTime.Parse("7/22/2008")
};

var steinsGateAnime = new Anime
{
    Title = "Steins;Gate",
    Writer = steinsGateWriter,
    Episodes = 25,
    ReleaseDate = DateTime.Parse("April 6, 2011")
};
#endregion

#region Media Actions
umineko.TalkAbout();
steinsGateAnime.TalkAbout();
chaosHead.TalkAbout();
#endregion

#region People
var flashito = new Person
{
    Name = "Flashito",
    Age = 25
};

var ame = new Person
{
    Name = "Ame",
    Age = 25
};
#endregion

#region People Actions
flashito.ConsumeVisualNovel(umineko);
ame.ConsumeAnime(steinsGateAnime);
ame.ConsumeVisualNovel(chaosHead);

flashito.RecommendVisualNovel(ame, umineko);
flashito.RecommendVisualNovel(ame, umineko);

ame.RecommendVisualNovel(flashito, umineko);
ame.RecommendAnime(flashito, steinsGateAnime);
ame.RecommendAnime(flashito, steinsGateAnime);
ame.RecommendVisualNovel(flashito, chaosHead);
#endregion
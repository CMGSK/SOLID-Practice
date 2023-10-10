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
var flashito = new MediaConsumer
{
    Name = "Flashito",
    Age = 25
};

var ame = new MediaConsumer
{
    Name = "Ame",
    Age = 25
};
#endregion

#region People Actions
flashito.ConsumeMedia(umineko);
ame.ConsumeEpisodicMedia(steinsGateAnime);
ame.ConsumeMedia(chaosHead);

flashito.RecommendMedia(ame, umineko);
flashito.RecommendMedia(ame, umineko);

ame.RecommendMedia(flashito, umineko);
ame.RecommendEpisodicMedia(flashito, steinsGateAnime);
ame.RecommendEpisodicMedia(flashito, steinsGateAnime);
ame.RecommendMedia(flashito, chaosHead);
#endregion
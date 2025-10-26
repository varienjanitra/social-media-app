namespace socmed_api;

public class DummyData
{
    public PostModel[] DummyPosts = new PostModel[]
    {
        new PostModel
        {
            Id = 101,
            PostedByUserId = 1,
            PostBody = "Just dropped my new fall playlist on Spotify, link in bio! 🎧🍂 Vibe check: certified cozy. #NewMusic #AutumnAesthetic",
            DateCreated = new DateTime(2025, 10, 25, 14, 30, 0, DateTimeKind.Utc)
        },
        new PostModel
        {
            Id = 102,
            PostedByUserId = 1,
            PostBody = "Seriously cannot believe how good this new coffee shop is. Their lavender latte is iconic. ☕️💜 Rate my study spot! 👇",
            DateCreated = new DateTime(2025, 10, 26, 9, 15, 22, DateTimeKind.Utc)
        },
        new PostModel
        {
            Id = 103,
            PostedByUserId = 1,
            PostBody = "Ate the leftovers I packed for lunch and forgot to take a picture of my fit check this morning. 😩 It was fire, though. Trust me. 😂",
            DateCreated = new DateTime(2025, 10, 26, 12, 5, 45, DateTimeKind.Utc)
        },
        new PostModel
        {
            Id = 104,
            PostedByUserId = 1,
            PostBody = "Did anyone else catch the comet last night? The pics don't even do it justice! Nature is wild, y'all. 🌌✨",
            DateCreated = new DateTime(2025, 10, 25, 23, 58, 10, DateTimeKind.Utc)
        },
        new PostModel
        {
            Id = 105,
            PostedByUserId = 1,
            PostBody = "Pro-tip: always proofread your code before pushing to main. Saved myself a massive headache just now. 😵‍💻 Lesson learned. #devlife",
            DateCreated = new DateTime(2025, 10, 26, 11, 45, 0, DateTimeKind.Utc)
        }
    };
}
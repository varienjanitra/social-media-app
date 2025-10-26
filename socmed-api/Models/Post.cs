namespace socmed_api;

public class PostModel
{
    public int Id { get; set; }
    public required int PostedByUserId { get; set; }
    public required string PostBody { get; set; }
    public DateTime DateCreated { get; set; }
}

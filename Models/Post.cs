namespace Blog.Models;


public class Post
{

    public int Id { get; set; }
    public required string Title { get; set; }
    public required string Summary { get; set; }
    public required string Body { get; set; }
    public required string Slug { get; set; }
    public DateTime CreateDate { get; set; }
    public DateTime LastUpdateDate { get; set; }
    public int CategoryId { get; set; }

    public int AuthorId { get; set; }

}
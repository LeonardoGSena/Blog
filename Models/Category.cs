namespace Blog.Models;


public class Category
{

    public int Id { get; set; }

    public required string Name { get; set; }
    public required string Slug { get; set; }

    public IList<Post> Posts { get; set; }
}
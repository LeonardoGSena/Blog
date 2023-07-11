using Blog.Data;
using Blog.Models;
using Microsoft.EntityFrameworkCore;

namespace Blog;

internal class Program
{
    private void Main(string[] args)
    {
        using var context = new BlogDataContext();

        var posts = context.PostWithTagsCount.ToList();
        foreach (var post in posts)
        {
            System.Console.WriteLine($"{post.Name} {post.Count}");
        }
    }
}
using Blog.Data;
using Blog.Models;
using Microsoft.EntityFrameworkCore;

namespace Blog;

internal class Program
{
    private static void Main(string[] args)
    {
        using var context = new BlogDataContext();

        // var user = new User
        // {
        //     Name = "Leonardo Sena",
        //     Slug = "leonardosena",
        //     Email = "leonardo@.net.com",
        //     Bio = "Just a random guy",
        //     Image = "https://balta.io",
        //     PasswordHash = "1230987457"
        // };

        // var category = new Category
        // {
        //     Name = "Backend",
        //     Slug = "backend"
        // };

        // var post = new Post
        // {
        //     Author = user,
        //     Category = category,
        //     Body = "<p>Hello World</p>",
        //     Slug = "comecando-com-ef-core",
        //     Summary = "Neste artigo vamos aprender EF Core",
        //     Title = "Começando com EF Core",
        //     CreateDate = DateTime.Now,
        //     LastUpdateDate = DateTime.Now
        // };

        // context.Posts.Add(post);
        // context.SaveChanges();

        var posts = context
        .Posts
        .AsNoTracking()
        .Include(x => x.Author)
        .Include(x => x.Category)
        .OrderByDescending(x => x.LastUpdateDate)
        .ToList();

        foreach (var post in posts)
        {
            System.Console.WriteLine($"{post.Title} escrito por {post.Author?.Name} em {post.Category?.Name}");
        }
    }
}
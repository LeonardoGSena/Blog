using Blog.Data;
using Blog.Models;
using Microsoft.EntityFrameworkCore;

namespace Blog;

internal class Program
{
    private static void Main(string[] args)
    {
        using var context = new BlogDataContext();

        //     context.Users.Add(new User
        //     {
        //         Bio = "Another Random Guy",
        //         Email = "leonardo@.net.com",
        //         Image = "https://balta.io",
        //         Name = "Leonardo Sena",
        //         PasswordHash = "1234",
        //         Slug = "leonardo-sena"
        //     });

        //     context.SaveChanges();

        var user = context.Users.FirstOrDefault();
        var post = new Post
        {
            Author = user,
            Body = "Meu Artigo",
            Category = new Category
            {
                Name = "Backend",
                Slug = "backend"
            },
            CreateDate = DateTime.Now,
            Slug = "meu-artigo",
            Summary = "Neste artigo vamos conferir",
            Title = "Meu artigo"
        };

        context.Posts.Add(post);
        context.SaveChanges();

    }
}
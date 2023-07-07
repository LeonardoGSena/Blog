using Blog.Data;
using Blog.Models;
using Microsoft.EntityFrameworkCore;

namespace Blog;

internal class Program
{
    private static void Main(string[] args)
    {
        using (var context = new BlogDataContext())
        {
        }
    }
}
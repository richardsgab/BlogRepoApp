using BlogApp.Models.DomeinModels;
using Microsoft.EntityFrameworkCore;

namespace BlogApp.Data
{
    public class SeedData
    {
        public static void AddRecords(ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<Blog>().HasData(

                new Blog
                {
                    Id = 1, 
                    Name = "Poetry Blog",
                    Description = "Description11",
                }
            );
            modelbuilder.Entity<Post>().HasData(
                new Post
                {
                    Id = 1,
                    BlogId = 1,
                    Title = "The Rain in June",
                    Content = "The rain is falling no stop.And falling in love."
                    CreatedAt = DateTime.Now
            });
            
            modelbuilder.Entity<Blog>().HasData(

                new Blog
                {
                    Id = 1, 
                    Name = "Poetry Blog",
                    Description = "Description11",
                }
            );
            modelbuilder.Entity<Post>().HasData(
                new Post
                {
                    Id = 2,
                    BlogId = 1,
                    Title = "I'm hungry",
                    Content = "Apples and bananes.",
                    CreatedAt = DateTime.Now
            });
            modelbuilder.Entity<Blog>().HasData(

                new Blog
                {
                    Id = 1,
                    Name = "Poetry Blog",
                    Description = "Description11",
                }
            );
            modelbuilder.Entity<Post>().HasData(
                new Post
                {
                    Id = 3,
                    BlogId = 1,
                    Title = "Five minutes",
                    Content = "It's tuesday and not friday",
                    CreatedAt = DateTime.Now
                });
        }
    }
}

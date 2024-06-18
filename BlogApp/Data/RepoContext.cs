using BlogApp.Models.DomeinModels;
using Microsoft.EntityFrameworkCore;

namespace BlogApp.Data
{
    public class RepoContext:DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }
        public RepoContext(DbContextOptions<RepoContext> options) : base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); 

            //Configuration for Post(many)
            modelBuilder.Entity<Post>()
                .HasKey(p => p.Id);

            modelBuilder.Entity<Post>()
               .HasOne(b => b.Blog)
               .WithMany(b => b.Posts)
               .HasForeignKey(b => b.BlogId)
               .OnDelete(DeleteBehavior.Cascade); // Use cascade delete


            //Configuration for Blog(one)
            modelBuilder.Entity<Blog>()
                .HasKey(b => b.Id);

            modelBuilder.Entity<Blog>()
                .Property(b => b.Name)
                .IsRequired()
                .HasMaxLength(100);
            modelBuilder.Entity<Blog>()
                .HasIndex(b => b.Name)
                .IsUnique();

            SeedData.AddRecords(modelBuilder);

        }
    }
}

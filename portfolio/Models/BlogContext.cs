using Microsoft.EntityFrameworkCore;

namespace portfolio.Models
{
    public class BlogContext : DbContext
    {
        public BlogContext(DbContextOptions options) :
            base(options)
        {
        }

        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<BlogPostTag> BlogPostTags { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BlogPostBlogPostTag>()
                .HasKey(bc => new { bc.BlogPostId, bc.BlogPostTagId });
            modelBuilder.Entity<BlogPostBlogPostTag>()
                .HasOne(bc => bc.BlogPost)
                .WithMany(b => b.BlogPostTags)
                .HasForeignKey(bc => bc.BlogPostId);
            modelBuilder.Entity<BlogPostBlogPostTag>()
                .HasOne(bc => bc.BlogPostTag)
                .WithMany(c => c.BlogPostsTags)
                .HasForeignKey(bc => bc.BlogPostTagId);
        }

    }
}
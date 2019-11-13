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
    }
}
using Microsoft.EntityFrameworkCore;

namespace portfolio.Models
{
    public class BlogContext : DbContext
    {
        public DbSet<BlogPost> BlogPosts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-FEKCTRH;Database=portfolio;User Id=sa;Password=Password;");
        }
    }
}
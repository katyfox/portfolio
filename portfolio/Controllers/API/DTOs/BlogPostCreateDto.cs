using System.Collections.Generic;
using portfolio.Models;

namespace portfolio.Controllers
{
    public class BlogPostCreateDto
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string ImagePath { get; set; }
        public BlogPostCategory Category { get; set; }
        public ICollection<BlogPostBlogPostTag> BlogPostTags { get; set; }
        public string Author { get; set; }
    }
}
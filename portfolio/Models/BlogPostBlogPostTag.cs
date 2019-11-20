using System;

namespace portfolio.Models
{
    public class BlogPostBlogPostTag
    {
        public Guid BlogPostId { get; set; }
        public BlogPost BlogPost { get; set; }
        public Guid BlogPostTagId { get; set; }
        public BlogPostTag BlogPostTag { get; set; }
    }
}
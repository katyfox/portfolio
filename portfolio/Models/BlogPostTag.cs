using System;
using System.Collections;
using System.Collections.Generic;

namespace portfolio.Models
{
    public class BlogPostTag
    {
        public Guid Id { get; set; }
        public string TagName { get; set; }
        public ICollection<BlogPostBlogPostTag> BlogPostsTags { get; set; }

    }
}
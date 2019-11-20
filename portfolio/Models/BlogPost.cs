﻿using System;
using System.Collections.Generic;

namespace portfolio.Models
{
    public class BlogPost
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string ImagePath { get; set; }
        public ICollection<BlogPostBlogPostTag> BlogPostTags { get; set; }
        public string Author { get; set; }

        public string GetFormattedDate()
        {
            return this.Date.ToString("Y");
        }

        public bool HasImage()
        {
            return (!String.IsNullOrWhiteSpace(this.ImagePath) && !this.ImagePath.Equals("string"));
        }
    }
}
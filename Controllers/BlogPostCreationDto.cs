﻿using portfolio.Models;

namespace portfolio.Controllers
{
    public class BlogPostCreationDto
    {
        public string Content { get; set; }
        public string ImagePath { get; set; }
        public BlogPostCategory Category { get; set; }
        public string Author { get; set; }
    }
}
using System;

namespace portfolio.Models
{
    public class BlogPost
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public string Content { get; set; }
        public string ImagePath { get; set; }
        public BlogPostCategory Category { get; set; }
        public string Author { get; set; }
    }
}
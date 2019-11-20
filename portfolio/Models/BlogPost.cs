using System;

namespace portfolio.Models
{
    public class BlogPost
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string ImagePath { get; set; }
        public BlogPostCategory Category { get; set; }
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
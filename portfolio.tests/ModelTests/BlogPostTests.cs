using System;
using NUnit.Framework;
using portfolio.Models;

namespace portfolio.tests.ModelTests
{
    [TestFixture]
    public class BlogPostTests
    {
        private BlogPost _post;

        [SetUp]
        public void SetUp()
        {
            _post = new BlogPost
            {
                Id = 1,
                Date = DateTime.Now,
                Title = "Sample Blog Post",
                Content = "This is a sample blog post for testing",
                ImagePath = "/images/BlogPostImage.png",
                Author = "Katy Fox"
            };
        }

        [Test]
        public void GetFormattedDate_DateSet_ReturnsProperFormat()
        {
            string expected = DateTime.Now.ToString("Y");

            Assert.IsTrue(expected.Equals(_post.GetFormattedDate()), 
                "BlogPost GetFormattedDate() didn't return the expected format. Expected: {0}; Actual: {1}", expected, _post.GetFormattedDate());
        }

        [Test]
        public void GetFormattedDate_DateNotSet_ReturnsProperFormat()
        {
            string expected = new DateTime().ToString("Y");

            Assert.IsTrue(expected.Equals(new BlogPost().GetFormattedDate()),
                "BlogPost GetFormattedDate() didn't return the expected format when Date is default DateTime value. Expected: {0}; Actual: {1}", expected, _post.GetFormattedDate());
        }

        [Test]
        public void PostHasImage_ImagePathSet_ReturnsTrue()
        {
            Assert.True(_post.HasImage(),
                "BlogPost HasImage() should have returned True for a non-\"string\" or whitespace value. ImagePath: {0}", _post.ImagePath);
        }

        [Test]
        public void PostHasImage_ImagePathSetToString_ReturnsFalse()
        {
            _post.ImagePath = "string"; // this is the default value in the API
            Assert.False(_post.HasImage(), 
                "BlogPost HasImage() should have returned False for a \"string\". ImagePath: {0}", _post.ImagePath);
        }

        [Test]
        public void PostHasImage_ImagePathNull_ReturnsFalse()
        {
            _post.ImagePath = null;
            Assert.False(_post.HasImage(), 
                "BlogPost HasImage() should have returned False for a null value.");
        }

        [Test]
        public void PostHasImage_ImagePathEmptyString_ReturnsFalse()
        {
            _post.ImagePath = String.Empty;
            Assert.False(_post.HasImage(), 
                "BlogPost HasImage() should have returned False for a String.Empty value. ImagePath: {0}", _post.ImagePath);
        }

        [Test]
        public void PostHasImage_ImagePathWhiteSpace_ReturnsFalse()
        {
            _post.ImagePath = "";
            Assert.False(_post.HasImage(), 
                "BlogPost HasImage() should have returned False for a \"\" value. ImagePath: {0}", _post.ImagePath);

            _post.ImagePath = " ";
            Assert.False(_post.HasImage(), 
                "BlogPost HasImage() should have returned False for a whitespace \" \" value. ImagePath: {0}", _post.ImagePath);
        }
    }
}
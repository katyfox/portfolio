using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using portfolio.Models;
using Microsoft.AspNetCore.Authorization;

namespace portfolio.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class BlogPostTagController : ControllerBase
    {
        private readonly BlogContext _context;

        public BlogPostTagController(BlogContext context)
        {
            _context = context;
        }

        // GET: api/BlogPostTag
        [HttpGet]
        public IEnumerable<BlogPostTag> GetBlogPostTags()
        {
            return _context.BlogPostTags;
        }

        // GET: api/BlogPostTag/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBlogPostTag([FromRoute] Guid id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var blogPostTag = await _context.BlogPostTags.FindAsync(id);

            if (blogPostTag == null)
            {
                return NotFound();
            }

            return Ok(blogPostTag);
        }

        // PUT: api/BlogPostTag/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBlogPostTag([FromRoute] Guid id, [FromBody] BlogPostTag blogPostTag)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != blogPostTag.Id)
            {
                return BadRequest();
            }

            _context.Entry(blogPostTag).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BlogPostTagExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/BlogPostTag
        [HttpPost]
        public async Task<IActionResult> PostBlogPostTag([FromBody] BlogPostTagCreateDto blogPostTag)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            BlogPostTag newTag = new BlogPostTag();
            newTag.TagName = blogPostTag.TagName;

            _context.BlogPostTags.Add(newTag);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBlogPostTag", new { id = newTag.Id }, newTag);
        }

        // DELETE: api/BlogPostTag/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBlogPostTag([FromRoute] Guid id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var blogPostTag = await _context.BlogPostTags.FindAsync(id);
            if (blogPostTag == null)
            {
                return NotFound();
            }

            _context.BlogPostTags.Remove(blogPostTag);
            await _context.SaveChangesAsync();

            return Ok(blogPostTag);
        }

        private bool BlogPostTagExists(Guid id)
        {
            return _context.BlogPostTags.Any(e => e.Id == id);
        }
    }
}
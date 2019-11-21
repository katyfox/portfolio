using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using portfolio.Models;

namespace portfolio.Controllers
{
    public class BlogPostBlogPostTagsController : Controller
    {
        private readonly BlogContext _context;

        public BlogPostBlogPostTagsController(BlogContext context)
        {
            _context = context;
        }

        // GET: BlogPostBlogPostTags
        public async Task<IActionResult> Index()
        {
            var blogContext = _context.BlogPostBlogPostTag.Include(b => b.BlogPost).Include(b => b.BlogPostTag);
            return View(await blogContext.ToListAsync());
        }

        // GET: BlogPostBlogPostTags/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var blogPostBlogPostTag = await _context.BlogPostBlogPostTag
                .Include(b => b.BlogPost)
                .Include(b => b.BlogPostTag)
                .FirstOrDefaultAsync(m => m.BlogPostId == id);
            if (blogPostBlogPostTag == null)
            {
                return NotFound();
            }

            return View(blogPostBlogPostTag);
        }

        // GET: BlogPostBlogPostTags/Create
        public IActionResult Create()
        {
            ViewData["BlogPostId"] = new SelectList(_context.BlogPosts, "Id", "Id");
            ViewData["BlogPostTagId"] = new SelectList(_context.BlogPostTags, "Id", "Id");
            return View();
        }

        // POST: BlogPostBlogPostTags/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BlogPostId,BlogPostTagId")] BlogPostBlogPostTag blogPostBlogPostTag)
        {
            if (ModelState.IsValid)
            {
                _context.Add(blogPostBlogPostTag);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["BlogPostId"] = new SelectList(_context.BlogPosts, "Id", "Id", blogPostBlogPostTag.BlogPostId);
            ViewData["BlogPostTagId"] = new SelectList(_context.BlogPostTags, "Id", "Id", blogPostBlogPostTag.BlogPostTagId);
            return View(blogPostBlogPostTag);
        }

        // GET: BlogPostBlogPostTags/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var blogPostBlogPostTag = await _context.BlogPostBlogPostTag.FindAsync(id);
            if (blogPostBlogPostTag == null)
            {
                return NotFound();
            }
            ViewData["BlogPostId"] = new SelectList(_context.BlogPosts, "Id", "Id", blogPostBlogPostTag.BlogPostId);
            ViewData["BlogPostTagId"] = new SelectList(_context.BlogPostTags, "Id", "Id", blogPostBlogPostTag.BlogPostTagId);
            return View(blogPostBlogPostTag);
        }

        // POST: BlogPostBlogPostTags/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("BlogPostId,BlogPostTagId")] BlogPostBlogPostTag blogPostBlogPostTag)
        {
            if (id != blogPostBlogPostTag.BlogPostId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(blogPostBlogPostTag);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BlogPostBlogPostTagExists(blogPostBlogPostTag.BlogPostId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["BlogPostId"] = new SelectList(_context.BlogPosts, "Id", "Id", blogPostBlogPostTag.BlogPostId);
            ViewData["BlogPostTagId"] = new SelectList(_context.BlogPostTags, "Id", "Id", blogPostBlogPostTag.BlogPostTagId);
            return View(blogPostBlogPostTag);
        }

        // GET: BlogPostBlogPostTags/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var blogPostBlogPostTag = await _context.BlogPostBlogPostTag
                .Include(b => b.BlogPost)
                .Include(b => b.BlogPostTag)
                .FirstOrDefaultAsync(m => m.BlogPostId == id);
            if (blogPostBlogPostTag == null)
            {
                return NotFound();
            }

            return View(blogPostBlogPostTag);
        }

        // POST: BlogPostBlogPostTags/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var blogPostBlogPostTag = await _context.BlogPostBlogPostTag.FindAsync(id);
            _context.BlogPostBlogPostTag.Remove(blogPostBlogPostTag);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BlogPostBlogPostTagExists(Guid id)
        {
            return _context.BlogPostBlogPostTag.Any(e => e.BlogPostId == id);
        }
    }
}

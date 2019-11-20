using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using portfolio.Models;

namespace portfolio.Controllers
{
    [Authorize]
    public class BlogPostTagsController : Controller
    {
        private readonly BlogContext _context;

        public BlogPostTagsController(BlogContext context)
        {
            _context = context;
        }

        // GET: BlogPostTags
        public async Task<IActionResult> Index()
        {
            return View(await _context.BlogPostTags.ToListAsync());
        }

        // GET: BlogPostTags/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var blogPostTag = await _context.BlogPostTags
                .FirstOrDefaultAsync(m => m.Id == id);
            if (blogPostTag == null)
            {
                return NotFound();
            }

            return View(blogPostTag);
        }

        // GET: BlogPostTags/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: BlogPostTags/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TagName")] BlogPostTag blogPostTag)
        {
            if (ModelState.IsValid)
            {
                blogPostTag.Id = Guid.NewGuid();
                _context.Add(blogPostTag);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(blogPostTag);
        }

        // GET: BlogPostTags/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var blogPostTag = await _context.BlogPostTags.FindAsync(id);
            if (blogPostTag == null)
            {
                return NotFound();
            }
            return View(blogPostTag);
        }

        // POST: BlogPostTags/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,TagName")] BlogPostTag blogPostTag)
        {
            if (id != blogPostTag.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(blogPostTag);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BlogPostTagExists(blogPostTag.Id))
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
            return View(blogPostTag);
        }

        // GET: BlogPostTags/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var blogPostTag = await _context.BlogPostTags
                .FirstOrDefaultAsync(m => m.Id == id);
            if (blogPostTag == null)
            {
                return NotFound();
            }

            return View(blogPostTag);
        }

        // POST: BlogPostTags/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var blogPostTag = await _context.BlogPostTags.FindAsync(id);
            _context.BlogPostTags.Remove(blogPostTag);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BlogPostTagExists(Guid id)
        {
            return _context.BlogPostTags.Any(e => e.Id == id);
        }
    }
}

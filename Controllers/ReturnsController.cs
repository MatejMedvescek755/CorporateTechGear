using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CorporateTechGear.Data;
using Models;

namespace CorporateTechGear.Controllers
{
    public class ReturnsController : Controller
    {
        private readonly ShopContext _context;

        public ReturnsController(ShopContext context)
        {
            _context = context;
        }

        // GET: Returns
        public async Task<IActionResult> Index()
        {
              return _context.Returns != null ? 
                          View(await _context.Returns.ToListAsync()) :
                          Problem("Entity set 'ShopContext.Returns'  is null.");
        }

        // GET: Returns/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Returns == null)
            {
                return NotFound();
            }

            var returns = await _context.Returns
                .FirstOrDefaultAsync(m => m.id == id);
            if (returns == null)
            {
                return NotFound();
            }

            return View(returns);
        }

        // GET: Returns/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Returns/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,order_id")] Returns returns)
        {
            if (ModelState.IsValid)
            {
                _context.Add(returns);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(returns);
        }

        // GET: Returns/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Returns == null)
            {
                return NotFound();
            }

            var returns = await _context.Returns.FindAsync(id);
            if (returns == null)
            {
                return NotFound();
            }
            return View(returns);
        }

        // POST: Returns/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,order_id")] Returns returns)
        {
            if (id != returns.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(returns);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReturnsExists(returns.id))
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
            return View(returns);
        }

        // GET: Returns/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Returns == null)
            {
                return NotFound();
            }

            var returns = await _context.Returns
                .FirstOrDefaultAsync(m => m.id == id);
            if (returns == null)
            {
                return NotFound();
            }

            return View(returns);
        }

        // POST: Returns/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Returns == null)
            {
                return Problem("Entity set 'ShopContext.Returns'  is null.");
            }
            var returns = await _context.Returns.FindAsync(id);
            if (returns != null)
            {
                _context.Returns.Remove(returns);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReturnsExists(int id)
        {
          return (_context.Returns?.Any(e => e.id == id)).GetValueOrDefault();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ItemLendSystemWithLogin.Models;
using Microsoft.AspNetCore.Authorization;

namespace ItemLendSystemWithLogin.Controllers
{
    public class LendsController : Controller
    {
        private readonly ItemLendSystemwithLogin_systemDB _context;

        public LendsController(ItemLendSystemwithLogin_systemDB context)
        {
            _context = context;
        }

        // GET: Lends
        public async Task<IActionResult> Index()
        {
            var itemLendSystemwithLogin_systemDB = _context.Lends.Include(l => l.Borrower).Include(l => l.Item);
            return View(await itemLendSystemwithLogin_systemDB.ToListAsync());
        }

        // GET: Lends/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Lends == null)
            {
                return NotFound();
            }

            var lend = await _context.Lends
                .Include(l => l.Borrower)
                .Include(l => l.Item)
                .FirstOrDefaultAsync(m => m.LID == id);
            if (lend == null)
            {
                return NotFound();
            }

            return View(lend);
        }

        // GET: Lends/Create
        [Authorize]
        public IActionResult Create()
        {
            ViewData["BID"] = new SelectList(_context.Borrowers, "BID", "Email");
            ViewData["IID"] = new SelectList(_context.Items, "IID", "Description");
            return View();
        }
        [Authorize]
        // POST: Lends/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("LID,IID,BID,Quantity,LendingDate,LendingDays,Note")] Lend lend)
        {
            if (ModelState.IsValid)
            {
                _context.Add(lend);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["BID"] = new SelectList(_context.Borrowers, "BID", "Email", lend.BID);
            ViewData["IID"] = new SelectList(_context.Items, "IID", "Description", lend.IID);
            return View(lend);
        }

        // GET: Lends/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Lends == null)
            {
                return NotFound();
            }

            var lend = await _context.Lends.FindAsync(id);
            if (lend == null)
            {
                return NotFound();
            }
            ViewData["BID"] = new SelectList(_context.Borrowers, "BID", "Email", lend.BID);
            ViewData["IID"] = new SelectList(_context.Items, "IID", "Description", lend.IID);
            return View(lend);
        }

        // POST: Lends/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("LID,IID,BID,Quantity,LendingDate,LendingDays,Note")] Lend lend)
        {
            if (id != lend.LID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(lend);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LendExists(lend.LID))
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
            ViewData["BID"] = new SelectList(_context.Borrowers, "BID", "Email", lend.BID);
            ViewData["IID"] = new SelectList(_context.Items, "IID", "Description", lend.IID);
            return View(lend);
        }

        // GET: Lends/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Lends == null)
            {
                return NotFound();
            }

            var lend = await _context.Lends
                .Include(l => l.Borrower)
                .Include(l => l.Item)
                .FirstOrDefaultAsync(m => m.LID == id);
            if (lend == null)
            {
                return NotFound();
            }

            return View(lend);
        }

        // POST: Lends/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Lends == null)
            {
                return Problem("Entity set 'ItemLendSystemwithLogin_systemDB.Lends'  is null.");
            }
            var lend = await _context.Lends.FindAsync(id);
            if (lend != null)
            {
                _context.Lends.Remove(lend);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LendExists(int id)
        {
          return (_context.Lends?.Any(e => e.LID == id)).GetValueOrDefault();
        }
    }
}

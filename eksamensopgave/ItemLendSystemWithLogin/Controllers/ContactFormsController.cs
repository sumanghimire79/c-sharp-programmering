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
    public class ContactFormsController : Controller
    {
        private readonly ItemLendSystemwithLogin_systemDB _context;

        public ContactFormsController(ItemLendSystemwithLogin_systemDB context)
        {
            _context = context;
        }

        [Authorize(Roles = "Admin")]
        // GET: ContactForms
        public async Task<IActionResult> Index()
        {
              return _context.contactForm != null ? 
                          View(await _context.contactForm.ToListAsync()) :
                          Problem("Entity set 'ItemLendSystemwithLogin_systemDB.contactForm'  is null.");
        }

        // GET: ContactForms/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.contactForm == null)
            {
                return NotFound();
            }

            var contactForm = await _context.contactForm
                .FirstOrDefaultAsync(m => m.CFID == id);
            if (contactForm == null)
            {
                return NotFound();
            }

            return View(contactForm);
        }


        // GET: ContactForms/Create
        public IActionResult Create()
        {
            return View();
        }
       
        // POST: ContactForms/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CFID,Name,Email,Message")] ContactForm contactForm)
        {
            if (ModelState.IsValid)
            {
                _context.Add(contactForm);
                await _context.SaveChangesAsync();
                //return RedirectToAction(nameof(Index));
                return RedirectToAction("Index","Home");
            }
            return View(contactForm);
        }


        [Authorize(Roles = "Admin")]
        // GET: ContactForms/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.contactForm == null)
            {
                return NotFound();
            }

            var contactForm = await _context.contactForm.FindAsync(id);
            if (contactForm == null)
            {
                return NotFound();
            }
            return View(contactForm);
        }
        [Authorize(Roles = "Admin")]
        // POST: ContactForms/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CFID,Name,Email,Message")] ContactForm contactForm)
        {
            if (id != contactForm.CFID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(contactForm);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ContactFormExists(contactForm.CFID))
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
            return View(contactForm);
        }
        [Authorize(Roles = "Admin")]
        // GET: ContactForms/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.contactForm == null)
            {
                return NotFound();
            }

            var contactForm = await _context.contactForm
                .FirstOrDefaultAsync(m => m.CFID == id);
            if (contactForm == null)
            {
                return NotFound();
            }

            return View(contactForm);
        }
        [Authorize(Roles = "Admin")]
        // POST: ContactForms/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.contactForm == null)
            {
                return Problem("Entity set 'ItemLendSystemwithLogin_systemDB.contactForm'  is null.");
            }
            var contactForm = await _context.contactForm.FindAsync(id);
            if (contactForm != null)
            {
                _context.contactForm.Remove(contactForm);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ContactFormExists(int id)
        {
          return (_context.contactForm?.Any(e => e.CFID == id)).GetValueOrDefault();
        }
    }
}

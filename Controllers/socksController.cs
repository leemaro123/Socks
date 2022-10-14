using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MvcSocks.Models;
using Socks.Data;

namespace Socks.Controllers
{
    public class socksController : Controller
    {
        private readonly SocksContext _context;

        public socksController(SocksContext context)
        {
            _context = context;
        }

        // GET: socks
        public async Task<IActionResult> Index()
        {
            return View(await _context.socks.ToListAsync());
        }

        // GET: socks/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var socks = await _context.socks
                .FirstOrDefaultAsync(m => m.Id == id);
            if (socks == null)
            {
                return NotFound();
            }

            return View(socks);
        }

        // GET: socks/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: socks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Company,LaunchDate,Type,Color,Size,Price")] socks socks)
        {
            if (ModelState.IsValid)
            {
                _context.Add(socks);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(socks);
        }

        // GET: socks/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var socks = await _context.socks.FindAsync(id);
            if (socks == null)
            {
                return NotFound();
            }
            return View(socks);
        }

        // POST: socks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Company,LaunchDate,Type,Color,Size,Price")] socks socks)
        {
            if (id != socks.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(socks);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!socksExists(socks.Id))
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
            return View(socks);
        }

        // GET: socks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var socks = await _context.socks
                .FirstOrDefaultAsync(m => m.Id == id);
            if (socks == null)
            {
                return NotFound();
            }

            return View(socks);
        }

        // POST: socks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var socks = await _context.socks.FindAsync(id);
            _context.socks.Remove(socks);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool socksExists(int id)
        {
            return _context.socks.Any(e => e.Id == id);
        }
    }
}

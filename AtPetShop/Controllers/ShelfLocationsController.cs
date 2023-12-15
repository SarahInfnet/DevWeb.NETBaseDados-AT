using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AtPetShop.Data;
using AtPetShop.Models;

namespace AtPetShop.Controllers
{
    public class ShelfLocationsController : Controller
    {
        private readonly PetShopContext _context;

        public ShelfLocationsController(PetShopContext context)
        {
            _context = context;
        }

        // GET: ShelfLocations
        public async Task<IActionResult> Index()
        {
              return _context.ShelfLocation != null ? 
                          View(await _context.ShelfLocation.ToListAsync()) :
                          Problem("Entity set 'PetShopContext.ShelfLocation'  is null.");
        }

        // GET: ShelfLocations/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.ShelfLocation == null)
            {
                return NotFound();
            }

            var shelfLocation = await _context.ShelfLocation
                .FirstOrDefaultAsync(m => m.Id == id);
            if (shelfLocation == null)
            {
                return NotFound();
            }

            return View(shelfLocation);
        }

        // GET: ShelfLocations/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ShelfLocations/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Row,Column,Aisle")] ShelfLocation shelfLocation)
        {
            if (ModelState.IsValid)
            {
                shelfLocation.Created = DateTime.Now;
                _context.Add(shelfLocation);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(shelfLocation);
        }

        // GET: ShelfLocations/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.ShelfLocation == null)
            {
                return NotFound();
            }

            var shelfLocation = await _context.ShelfLocation.FindAsync(id);
            if (shelfLocation == null)
            {
                return NotFound();
            }
            return View(shelfLocation);
        }

        // POST: ShelfLocations/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Row,Column,Aisle")] ShelfLocation shelfLocation)
        {
            if (id != shelfLocation.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(shelfLocation);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ShelfLocationExists(shelfLocation.Id))
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
            return View(shelfLocation);
        }

        // GET: ShelfLocations/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.ShelfLocation == null)
            {
                return NotFound();
            }

            var shelfLocation = await _context.ShelfLocation
                .FirstOrDefaultAsync(m => m.Id == id);
            if (shelfLocation == null)
            {
                return NotFound();
            }

            return View(shelfLocation);
        }

        // POST: ShelfLocations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.ShelfLocation == null)
            {
                return Problem("Entity set 'PetShopContext.ShelfLocation'  is null.");
            }
            var shelfLocation = await _context.ShelfLocation.FindAsync(id);
            if (shelfLocation != null)
            {
                _context.ShelfLocation.Remove(shelfLocation);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ShelfLocationExists(int id)
        {
          return (_context.ShelfLocation?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}

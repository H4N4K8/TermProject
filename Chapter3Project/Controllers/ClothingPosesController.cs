using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Chapter3Project.Models;

namespace Chapter3Project.Controllers
{
    public class ClothingPosesController : Controller
    {
        private readonly SetContext _context;

        public ClothingPosesController(SetContext context)
        {
            _context = context;
        }

        // GET: ClothingPoses
        public async Task<IActionResult> Index()
        {
            return View(await _context.CPoses.ToListAsync());
        }

        // GET: ClothingPoses/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clothingPoses = await _context.ClothingPoses
                .FirstOrDefaultAsync(m => m.SetId == id);
            if (clothingPoses == null)
            {
                return NotFound();
            }

            return View(clothingPoses);
        }

        // GET: ClothingPoses/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ClothingPoses/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,SetName,SmiskiType")] ClothingPoses clothingPoses)
        {
            if (ModelState.IsValid)
            {
                _context.Add(clothingPoses);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(clothingPoses);
        }

        // GET: ClothingPoses/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clothingPoses = await _context.ClothingPoses.FindAsync(id);
            if (clothingPoses == null)
            {
                return NotFound();
            }
            return View(clothingPoses);
        }

        // POST: ClothingPoses/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,SetName,SmiskiType")] ClothingPoses clothingPoses)
        {
            if (id != clothingPoses.SetId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(clothingPoses);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClothingPosesExists(clothingPoses.SetId))
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
            return View(clothingPoses);
        }

        // GET: ClothingPoses/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clothingPoses = await _context.ClothingPoses
                .FirstOrDefaultAsync(m => m.SetId == id);
            if (clothingPoses == null)
            {
                return NotFound();
            }

            return View(clothingPoses);
        }

        // POST: ClothingPoses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var clothingPoses = await _context.ClothingPoses.FindAsync(id);
            if (clothingPoses != null)
            {
                _context.ClothingPoses.Remove(clothingPoses);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ClothingPosesExists(string id)
        {
            return _context.ClothingPoses.Any(e => e.SetId == id);
        }
    }
}

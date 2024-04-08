using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MindSpringsTest.Models;
using MvcstoreResultModel.Data;

namespace MindSpringsTest.Controllers
{
    public class storeResultModelController : Controller
    {
        private readonly MvcstoreResultModelContext _context;

        public storeResultModelController(MvcstoreResultModelContext context)
        {
            _context = context;
        }

        // GET: storeResultModel
        public async Task<IActionResult> Index()
        {
            return View(await _context.storeResultModel.ToListAsync());
        }

        // GET: storeResultModel/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var storeResultModel = await _context.storeResultModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (storeResultModel == null)
            {
                return NotFound();
            }

            return View(storeResultModel);
        }

        // GET: storeResultModel/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: storeResultModel/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TextEntered,translatedText")] storeResultModel storeResultModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(storeResultModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(storeResultModel);
        }

        // GET: storeResultModel/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var storeResultModel = await _context.storeResultModel.FindAsync(id);
            if (storeResultModel == null)
            {
                return NotFound();
            }
            return View(storeResultModel);
        }

        // POST: storeResultModel/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TextEntered,translatedText")] storeResultModel storeResultModel)
        {
            if (id != storeResultModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(storeResultModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!storeResultModelExists(storeResultModel.Id))
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
            return View(storeResultModel);
        }

        // GET: storeResultModel/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var storeResultModel = await _context.storeResultModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (storeResultModel == null)
            {
                return NotFound();
            }

            return View(storeResultModel);
        }

        // POST: storeResultModel/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var storeResultModel = await _context.storeResultModel.FindAsync(id);
            if (storeResultModel != null)
            {
                _context.storeResultModel.Remove(storeResultModel);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool storeResultModelExists(int id)
        {
            return _context.storeResultModel.Any(e => e.Id == id);
        }
    }
}

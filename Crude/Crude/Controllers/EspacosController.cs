using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Crude.Data;
using Crude.Models;

namespace Crude.Controllers
{
    public class EspacosController : Controller
    {
        private readonly CrudeDB _context;

        public EspacosController(CrudeDB context)
        {
            _context = context;
        }

        // GET: Espacos
        public async Task<IActionResult> Index()
        {
            return View(await _context.Espacos.ToListAsync());
        }

        // GET: Espacos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var espacos = await _context.Espacos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (espacos == null)
            {
                return NotFound();
            }

            return View(espacos);
        }

        // GET: Espacos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Espacos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Classificacao,NomeOficial,NomeConhecido,Latitude,Longitude")] Espacos espacos)
        {
            if (ModelState.IsValid)
            {
                _context.Add(espacos);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(espacos);
        }

        // GET: Espacos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var espacos = await _context.Espacos.FindAsync(id);
            if (espacos == null)
            {
                return NotFound();
            }
            return View(espacos);
        }

        // POST: Espacos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Classificacao,NomeOficial,NomeConhecido,Latitude,Longitude")] Espacos espacos)
        {
            if (id != espacos.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(espacos);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EspacosExists(espacos.Id))
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
            return View(espacos);
        }

        // GET: Espacos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var espacos = await _context.Espacos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (espacos == null)
            {
                return NotFound();
            }

            return View(espacos);
        }

        // POST: Espacos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var espacos = await _context.Espacos.FindAsync(id);
            _context.Espacos.Remove(espacos);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EspacosExists(int id)
        {
            return _context.Espacos.Any(e => e.Id == id);
        }
    }
}

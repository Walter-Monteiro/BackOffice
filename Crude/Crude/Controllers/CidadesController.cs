﻿using System;
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
    public class CidadesController : Controller
    {
        private readonly CrudeDB _context;

        public CidadesController(CrudeDB context)
        {
            _context = context;
        }

        // GET: Cidades
        public async Task<IActionResult> Index()
        {
            return View(await _context.Cidades.ToListAsync());
        }

        // GET: Cidades/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cidade = await _context.Cidades
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cidade == null)
            {
                return NotFound();
            }

            return View(cidade);
        }

        // GET: Cidades/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Cidades/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,Latitude,Longitude")] Cidade cidade)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cidade);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cidade);
        }

        // GET: Cidades/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cidade = await _context.Cidades.FindAsync(id);
            if (cidade == null)
            {
                return NotFound();
            }
            return View(cidade);
        }

        // POST: Cidades/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Latitude,Longitude")] Cidade cidade)
        {
            if (id != cidade.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cidade);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CidadeExists(cidade.Id))
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
            return View(cidade);
        }

        // GET: Cidades/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cidade = await _context.Cidades
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cidade == null)
            {
                return NotFound();
            }

            return View(cidade);
        }

        // POST: Cidades/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cidade = await _context.Cidades.FindAsync(id);
            _context.Cidades.Remove(cidade);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CidadeExists(int id)
        {
            return _context.Cidades.Any(e => e.Id == id);
        }
    }
}

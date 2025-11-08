using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SisDoBem.Data;
using SisDoBem.Models;

namespace SisDoBem.Controllers
{
    public class CampanhasController : Controller
    {
        private readonly AppDbContext _context;

        public CampanhasController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Campanhas
        public async Task<IActionResult> Index()
        {
            return View(await _context.Campanhas.ToListAsync());
        }

        // GET: Campanhas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var campanha = await _context.Campanhas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (campanha == null)
            {
                return NotFound();
            }

            return View(campanha);
        }

        // GET: Campanhas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Campanhas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,Descricao,DataDeInicio,DataDeTermino,MetaFinanceira,TotalArrecadado,Status,DataDeCadastro,DataDeAtualizacao")] Campanha campanha)
        {
            if (ModelState.IsValid)
            {
                _context.Add(campanha);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(campanha);
        }

        // GET: Campanhas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var campanha = await _context.Campanhas.FindAsync(id);
            if (campanha == null)
            {
                return NotFound();
            }
            return View(campanha);
        }

        // POST: Campanhas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Descricao,DataDeInicio,DataDeTermino,MetaFinanceira,TotalArrecadado,Status,DataDeCadastro,DataDeAtualizacao")] Campanha campanha)
        {
            if (id != campanha.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(campanha);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CampanhaExists(campanha.Id))
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
            return View(campanha);
        }

        // GET: Campanhas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var campanha = await _context.Campanhas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (campanha == null)
            {
                return NotFound();
            }

            return View(campanha);
        }

        // POST: Campanhas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var campanha = await _context.Campanhas.FindAsync(id);
            if (campanha != null)
            {
                _context.Campanhas.Remove(campanha);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CampanhaExists(int id)
        {
            return _context.Campanhas.Any(e => e.Id == id);
        }
    }
}

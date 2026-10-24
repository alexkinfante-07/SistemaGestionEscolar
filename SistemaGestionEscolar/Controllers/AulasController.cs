using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SistemaGestionEscolar.Data;
using SistemaGestionEscolar.Models;

namespace SistemaGestionEscolar.Controllers
{
    public class AulasController : Controller
    {
        private readonly SistemaGestionEscolarContext _context;

        public AulasController(SistemaGestionEscolarContext context)
        {
            _context = context;
        }

        
        public async Task<IActionResult> Index()
        {
            return View(await _context.Aula.ToListAsync());
        }

        
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();

            var aula = await _context.Aula.FirstOrDefaultAsync(m => m.Id == id);
            if (aula == null) return NotFound();

            return View(aula);
        }

        
        public IActionResult Create()
        {
            return View();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Numero,Capacidad,Edificio,Piso")] Aula aula)
        {
            if (ModelState.IsValid)
            {
                _context.Add(aula);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(aula);
        }

        
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();

            var aula = await _context.Aula.FindAsync(id);
            if (aula == null) return NotFound();
            return View(aula);
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Numero,Capacidad,Edificio,Piso")] Aula aula)
        {
            if (id != aula.Id) return NotFound();

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(aula);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AulaExists(aula.Id)) return NotFound();
                    else throw;
                }
                return RedirectToAction(nameof(Index));
            }
            return View(aula);
        }

        
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            var aula = await _context.Aula.FirstOrDefaultAsync(m => m.Id == id);
            if (aula == null) return NotFound();

            return View(aula);
        }

        
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var aula = await _context.Aula.FindAsync(id);
            if (aula != null) _context.Aula.Remove(aula);

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AulaExists(int id)
        {
            return _context.Aula.Any(e => e.Id == id);
        }
    }
}
using System;
using System.Threading.Tasks;
using Examen1SI.Data;
using Examen1SI.Models.Citasmedicas;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Examen1SI.Controllers
{
    public class CitasController : Controller
    {
        private readonly ApplicationDbContext db;

        public CitasController(ApplicationDbContext db)
        {
            this.db = db;
        }

        public async Task<IActionResult> Index()
        {
            return View(await db.Citas.ToListAsync());
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cit = await db.Citas.FirstOrDefaultAsync(m => m.CitaID == id);
            if (cit == null)
            {
                return NotFound();
            }

            return View(cit);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Cita_Medica cit)
        {
            if (ModelState.IsValid)
            {
                db.Add(cit);
                await db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));

            }
            return View(cit);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cit = await db.Citas.FindAsync(id);

            if (cit == null)
            {
                return NotFound();
            }

            return View(cit);


        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Edit(int id, Cita_Medica cit)
        {
            if (id != cit.CitaID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    db.Update(cit);
                    await db.SaveChangesAsync();

                }
                catch (DbUpdateConcurrencyException)
                {
                    return NotFound();
                }

                return RedirectToAction(nameof(Index));
            }

            return View(cit);
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cit = await db.Citas.FirstOrDefaultAsync(m => m.CitaID == id);
            if (cit == null)
            {
                return NotFound();
            }

            return View(cit);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            var cit = await db.Citas.FindAsync(id);
            db.Citas.Remove(cit);
            await db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));


        }
    }
}

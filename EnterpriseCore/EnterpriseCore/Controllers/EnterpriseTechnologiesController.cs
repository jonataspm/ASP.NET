using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EnterpriseCore.Data;
using EnterpriseCore.Models;

namespace EnterpriseCore.Controllers
{
    public class EnterpriseTechnologiesController : Controller
    {
        private readonly EnterpriseCoreContext _context;

        public EnterpriseTechnologiesController(EnterpriseCoreContext context)
        {
            _context = context;
        }

        // GET: EnterpriseTechnologies
        public async Task<IActionResult> Index()
        {
            return View(await _context.EnterpriseTechnology.ToListAsync());
        }

        // GET: EnterpriseTechnologies/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var enterpriseTechnology = await _context.EnterpriseTechnology
                .FirstOrDefaultAsync(m => m.Id == id);
            if (enterpriseTechnology == null)
            {
                return NotFound();
            }

            return View(enterpriseTechnology);
        }

        // GET: EnterpriseTechnologies/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: EnterpriseTechnologies/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TechnologyType,Id,CreationDate,DeletionnDate,UpdatenDate")] EnterpriseTechnology enterpriseTechnology)
        {
            if (ModelState.IsValid)
            {
                _context.Add(enterpriseTechnology);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(enterpriseTechnology);
        }

        // GET: EnterpriseTechnologies/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var enterpriseTechnology = await _context.EnterpriseTechnology.FindAsync(id);
            if (enterpriseTechnology == null)
            {
                return NotFound();
            }
            return View(enterpriseTechnology);
        }

        // POST: EnterpriseTechnologies/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long? id, [Bind("TechnologyType,Id,CreationDate,DeletionnDate,UpdatenDate")] EnterpriseTechnology enterpriseTechnology)
        {
            if (id != enterpriseTechnology.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(enterpriseTechnology);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EnterpriseTechnologyExists(enterpriseTechnology.Id))
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
            return View(enterpriseTechnology);
        }

        // GET: EnterpriseTechnologies/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var enterpriseTechnology = await _context.EnterpriseTechnology
                .FirstOrDefaultAsync(m => m.Id == id);
            if (enterpriseTechnology == null)
            {
                return NotFound();
            }

            return View(enterpriseTechnology);
        }

        // POST: EnterpriseTechnologies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long? id)
        {
            var enterpriseTechnology = await _context.EnterpriseTechnology.FindAsync(id);
            _context.EnterpriseTechnology.Remove(enterpriseTechnology);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EnterpriseTechnologyExists(long? id)
        {
            return _context.EnterpriseTechnology.Any(e => e.Id == id);
        }
    }
}

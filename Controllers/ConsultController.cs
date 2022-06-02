#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StayHealthy.Data;
using StayHealthy.Models;

namespace StayHealthy.Controllers
{
    public class ConsultController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;

        public ConsultController(ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            this._userManager = userManager;
            _context = context;
        }

        // GET: Consult
        public async Task<IActionResult> Index()
        {
            if (User.IsInRole("Admin"))
            {
                // return index view with not answered consults only

                return View("Admin",await _context.Consult.Where<Consult>(c=>c.answered == false).ToListAsync());
            }
            // return index view with this user consults only
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var patienEmail = _context.Users.FindAsync(userId);
            ViewBag.patienEmail = patienEmail;
            return View("Patient",await _context.Consult.ToListAsync());
        }

        // GET: Consult/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var consult = await _context.Consult
                .FirstOrDefaultAsync(m => m.Id == id);
            if (consult == null)
            {
                return NotFound();
            }

            return View(consult);
        }

        // GET: Consult/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Consult/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,subject,content,reply,imageName")] Consult consult)
        {
            if (ModelState.IsValid)
            {
                _context.Add(consult);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(consult);
        }

        // GET: Consult/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var consult = await _context.Consult.FindAsync(id);
            if (consult == null)
            {
                return NotFound();
            }
            return View(consult);
        }

                // GET: Consult/Relpy/5
        public async Task<IActionResult> Relpy(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var consult = await _context.Consult.FindAsync(id);
            if (consult == null)
            {
                return NotFound();
            }
            return View(consult);
        }

        // POST: Consult/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,subject,content,reply,imageName")] Consult consult)
        {
            if (id != consult.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(consult);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ConsultExists(consult.Id))
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
            return View(consult);
        }

        // GET: Consult/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var consult = await _context.Consult
                .FirstOrDefaultAsync(m => m.Id == id);
            if (consult == null)
            {
                return NotFound();
            }

            return View(consult);
        }

        // POST: Consult/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var consult = await _context.Consult.FindAsync(id);
            _context.Consult.Remove(consult);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ConsultExists(int id)
        {
            return _context.Consult.Any(e => e.Id == id);
        }
    }
}

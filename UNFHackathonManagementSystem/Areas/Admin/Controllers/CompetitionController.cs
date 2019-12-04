using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UNFHackathonManagementSystem.Data;
using UNFHackathonManagementSystem.Models;

namespace UNFHackathonManagementSystem.Areas.Admin
{
    [Area("Admin")]
    public class CompetitionController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly IHostingEnvironment _hostingEnvironment;

        public CompetitionController(ApplicationDbContext db, IHostingEnvironment hostingEnvironment)
        {
            _db = db;
            _hostingEnvironment = hostingEnvironment;
        }

        //GET 
        [Authorize]
        public async Task<IActionResult> Index()
        {
            return View(await _db.Competition.ToListAsync());
        }

        //GET - CREATE
        public IActionResult Create()
        {
            return View();
        }

        //POST - CREATE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Competition competition)
        {
            if (ModelState.IsValid)
            {
                //if valid
                _db.Competition.Add(competition);
                await _db.SaveChangesAsync();

                return RedirectToAction(nameof(Index));

            }

            return View(competition);
        }

        //GET - EDIT
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var competition = await _db.Competition.FindAsync(id);
            if (competition == null)
            {
                return NotFound();
            }

            return View(competition);
        }

        //POST - EDIT
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Competition competition)
        {
            if (ModelState.IsValid)
            {
                _db.Update(competition);
                await _db.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            return View(competition);
        }

        //GET - Delete
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var competition = await _db.Competition.FindAsync(id);
            if (competition == null)
            {
                return NotFound();
            }

            return View(competition);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleleConfirmed(int id)
        {
            var competition = await _db.Competition.FindAsync(id);

            if (competition == null)
            {
                return View();
            }
            _db.Competition.Remove(competition);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        //GET - DETAILS
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var competition = await _db.Competition.FindAsync(id);
            if (competition == null)
            {
                return NotFound();
            }

            return View(competition);
        }
    }
}
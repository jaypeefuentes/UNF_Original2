using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UNFHackathonManagementSystem.Data;
using UNFHackathonManagementSystem.Models;

namespace UNFHackathonManagementSystem.Controllers
{   
    [Area("Participant")]
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _db;

        public HomeController(ApplicationDbContext db)
        {
            _db = db;
        }


        public async Task<IActionResult> Index()
        {
            IndexViewModel IndexVM = new IndexViewModel()
                {
                     CompetitionItem = await _db.Competition.ToListAsync()
            };
            return View(IndexVM);
        }


        [Authorize]
        public async Task<IActionResult> Details(int id)
        {
            var competionItemFromDb = await _db.Competition.ToListAsync();
            JoinCompetition joinCompetion = new JoinCompetition()
            {
            

            };

            return View(joinCompetion);
        }
    





        public IActionResult Privacy()
        {
            return View();
        }




        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UNFHackathonManagementSystem.Data;
using UNFHackathonManagementSystem.Models.ViewModels;

namespace UNFHackathonManagementSystem.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class LeaderBoardController : Controller
    {

        private readonly ApplicationDbContext _db;

        public LeaderBoardController(ApplicationDbContext db)
        {
            _db = db;
        }

        //Get INDEX
        [Authorize]
        public async Task<IActionResult> Index()
        {
            var leaderBoard = await _db.Leaderboard.Include(s=>s.Competition).ToListAsync();
            return View(leaderBoard);
        }

        //GET - CREATE
        public async Task<IActionResult> Create()
        {
            LeaderBoardAndCompetitionViewModel model = new LeaderBoardAndCompetitionViewModel()
            {
                CompetitionList = await _db.Competition.ToListAsync(),
                Leaderboard = new Models.Leaderboard(),
                LeaderBoardList = await _db.Leaderboard.OrderBy(p => p.Name).Select(p => p.Name).Distinct().ToListAsync()
            };

            return View(model);
        }
    }
}
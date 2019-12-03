using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UNFHackathonManagementSystem.Models.ViewModels
{
    public class LeaderBoardAndCompetitionViewModel
    {
        public IEnumerable<Competition> CompetitionList { get; set; }
        public Leaderboard Leaderboard { get; set; }
        public List<string> LeaderBoardList { get; set; }
        public string StatusMessage { get; set; }
    }
}

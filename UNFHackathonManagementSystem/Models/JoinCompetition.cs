using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace UNFHackathonManagementSystem.Models
{
    public class JoinCompetition
    {
        public int Id { get; set; }

        public int CompetitionItemId { get; set; }
    }
}

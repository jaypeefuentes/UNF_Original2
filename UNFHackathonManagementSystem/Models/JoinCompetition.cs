using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using UNFHackathonManagementSystem.Data.Migrations;

namespace UNFHackathonManagementSystem.Models
{
    public class JoinCompetition
    {
        public int Id { get; set; }

        public int CompetitionId { get; set; }

    }
}

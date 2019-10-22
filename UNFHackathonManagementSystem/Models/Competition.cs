using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UNFHackathonManagementSystem.Models
{
    public class Competition
    {
        [Key]
        public int Id { get; set; }

        [Display(Name="Competition Name")]
        [Required]
        public string Name { get; set; }

        public string Type { get; set; }

        public string Location { get; set; }

        public int Date { get; set; }

        public int Time { get; set; }

        public string Organizer { get; set; }

        public string Description { get; set; }
    }
}

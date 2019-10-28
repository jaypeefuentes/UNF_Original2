using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using UNFHackathonManagementSystem.Data;

namespace UNFHackathonManagementSystem.ViewComponenets
{
    public class UserNameViewComponent : ViewComponent
    {
        private readonly ApplicationDbContext _db;
        public UserNameViewComponent(ApplicationDbContext db)
        {
            _db = db;
        }


    }
}

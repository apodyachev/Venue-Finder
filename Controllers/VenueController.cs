using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Venue_Finder.Models;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace Venue_Finder.Controllers
{
    public class VenueController : Controller
    {

        private readonly dbContext _context;
        public VenueController(dbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Search() 
        {
            return View(_context.Venue.ToList());
        }
    }
}
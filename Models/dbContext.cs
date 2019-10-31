using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Venue_Finder.Models
{
    public class dbContext
    {
        public dbContext()
            : base()
        {
        }
        public DbSet<Venue> Venue { get; set; }
    }
}

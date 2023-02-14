using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Mission06_jh985.Models
{
    public class MovieEntryContext : DbContext
    {
        //Constructor
        public MovieEntryContext (DbContextOptions<MovieEntryContext> options) : base (options)
        {
            //leave blank for now
        }
        public DbSet<MovieEntry> response { get; set; }
    }
}

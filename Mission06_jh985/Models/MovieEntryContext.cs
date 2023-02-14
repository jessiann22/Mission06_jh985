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
        public DbSet<MovieEntry> Response { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<MovieEntry>().HasData(

                new MovieEntry
                {
                    Category = "Romance",
                    Title = "The Proposal",
                    Year = 1980,
                    Director = "Joseph B. Worthin",
                    Rating = "PG-13",
                    Edited = true,
                    Lent = "David A Bednar",
                    Notes = "Best Movie created babe"
                },

                new MovieEntry
                {
                    Category = "Fantasy",
                    Title = "Harry Potter",
                    Year = 2007,
                    Director = "JK Rowling",
                    Rating = "PG-13",
                    Edited = false,
                    Lent = "Pooh Bear",
                    Notes = "pretty good movie babe"
                },

                new MovieEntry
                {
                    Category = "Sports",
                    Title = "Forever Strong",
                    Year = 2013,
                    Director = "Kevin Holt",
                    Rating = "R",
                    Edited = true,
                    Lent = "Dee Dee Holt",
                    Notes = "Motivated me to win the state champtionship"
                });


        }
    }
}

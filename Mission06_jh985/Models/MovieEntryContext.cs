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
        public DbSet<MovieEntryModel> Responses { get; set; }

        public DbSet<Category> Category { get; set; }

        //seed data

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                new Category { CategoryID = 1, CategoryName = "Action" },
                new Category { CategoryID = 2, CategoryName = "Comedy" },
                new Category { CategoryID = 3, CategoryName = "Romance" },
                new Category { CategoryID = 4, CategoryName = "Sports" },
                new Category { CategoryID = 5, CategoryName = "Fantasy" }
                );


            mb.Entity<MovieEntryModel>().HasData(

                new MovieEntryModel
                {
                    CategoryID = 3,
                    Title = "The Proposal",
                    Year = 1980,
                    Director = "Joseph B. Worthin",
                    Rating = "PG-13",
                    Edited = true,
                    Lent = "David A Bednar",
                    Notes = "Best Movie created babe"
                },

                new MovieEntryModel
                {
                    CategoryID = 5,
                    Title = "Harry Potter",
                    Year = 2007,
                    Director = "JK Rowling",
                    Rating = "PG-13",
                    Edited = false,
                    Lent = "Pooh Bear",
                    Notes = "pretty good movie babe"
                },

                new MovieEntryModel
                {
                    CategoryID = 4,
                    Title = "Forever Strong",
                    Year = 2013,
                    Director = "Kevin Holt",
                    Rating = "R",
                    Edited = true,
                    Lent = "Dee Dee Holt",
                    Notes = "Motivated me to win the state champtionship"
                }) ;


        }
    }
}

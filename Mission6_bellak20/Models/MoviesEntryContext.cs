using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission6_bellak20.Models
{
    public class MoviesEntryContext : DbContext
    {
        //constructor
        public MoviesEntryContext(DbContextOptions<MoviesEntryContext> options) : base(options)
        {

        }

        public DbSet<MovieResponse> Responses { get; set; }
        public DbSet<Category> Categories { get; set; }
        //set entries in the database
        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                new Category { CategoryId = 1, CategoryName = "Horror/Suspense" },
                new Category { CategoryId = 2, CategoryName = "Action/Adventure" },
                new Category { CategoryId = 3, CategoryName = "Comedy" },
                new Category { CategoryId = 4, CategoryName = "Drama" },
                new Category { CategoryId = 5, CategoryName = "Family" },
                new Category { CategoryId = 6, CategoryName = "Micellaneous" },
                new Category { CategoryId = 7, CategoryName = "Television" },
                new Category { CategoryId = 8, CategoryName = "VHS" }
                ) ;

            mb.Entity<MovieResponse>().HasData(
                
                new MovieResponse
                {
                    ApplicationId = 1,
                    CategoryId = 1,
                    Title="Gremlins",
                    Year="1989",
                    Director="Who Knows",
                    Rating= "PG"
                },
                new MovieResponse
                {
                    ApplicationId = 2,
                    CategoryId = 2,
                    Title = "Gremlins",
                    Year = "1989",
                    Director = "Who Knows",
                    Rating = "PG"
                },
                new MovieResponse
                {
                    ApplicationId = 3,
                    CategoryId = 3,
                    Title = "Gremlins",
                    Year = "1989",
                    Director = "Who Knows",
                    Rating = "PG"
                }
                );
        }
    }
}

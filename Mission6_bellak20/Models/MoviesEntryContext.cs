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

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<MovieResponse>().HasData(
                
                new MovieResponse
                {
                    ApplicationId = 1,
                    Category = "Horror",
                    Title="Gremlins",
                    Year="1989",
                    Director="Who Knows",
                    Rating= "PG"
                },
                new MovieResponse
                {
                    ApplicationId = 2,
                    Category = "Comedy",
                    Title = "Gremlins",
                    Year = "1989",
                    Director = "Who Knows",
                    Rating = "PG"
                },
                new MovieResponse
                {
                    ApplicationId = 3,
                    Category = "Holiday",
                    Title = "Gremlins",
                    Year = "1989",
                    Director = "Who Knows",
                    Rating = "PG"
                }
                );
        }
    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mission6_nconrad3.Models
{
    public class MovieInfoContext : DbContext
    {
        //constructor
        public MovieInfoContext (DbContextOptions<MovieInfoContext> options) : base(options)
        {
            
        }

        public DbSet<ApplicationResponse> responses { get; set; }

        //creation of model
        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<ApplicationResponse>().HasData(

                //seeded data
                new ApplicationResponse
                {
                    ApplicationID = 1,
                    Title = "Sky High",
                    Category = "Adventure",
                    Year = 2005,
                    Director = "Mike Mitchell",
                    Rating = "PG",
                    Edited = false,
                    LentTo = "Dave",
                    Notes = "Great Movie"
                },
                new ApplicationResponse
                {
                    ApplicationID = 2,
                    Title = "Kung Fu Panda",
                    Category = "Comedy",
                    Year = 2008,
                    Director = "John Stevenson",
                    Rating = "PG",
                    Edited = false,
                    LentTo = "Dave",
                    Notes = "Great Movie"
                },
                new ApplicationResponse
                {
                    ApplicationID = 3,
                    Title = "Shrek",
                    Category = "Comedy",
                    Year = 2001,
                    Director = "Vicky Jenson",
                    Rating = "PG",
                    Edited = false,
                    LentTo = "Dave",
                    Notes = "Best Movie"
                }
             );
        }

        //new ApplicationResponse
        //{

//}

        
    }
}

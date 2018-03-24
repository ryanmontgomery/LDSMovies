using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<DbContextOptions<MvcMovieContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                     new Movie
                     {
                         Title = "Legacy",
                         ReleaseDate = DateTime.Parse("07-03-1993"),
                         Genre = "Drama",
                         Rating = "NR",
                         Price = 0.00M
                     },

                     new Movie
                     {
                         Title = "The Other Side of Heaven",
                         ReleaseDate = DateTime.Parse("04-12-2002"),
                         Genre = "Drama",
                         Rating = "PG",
                         Price = 1.99M
                     },

                     new Movie
                     {
                         Title = "Meet the Mormons",
                         ReleaseDate = DateTime.Parse("02-26-2015"),
                         Genre = "Documentary",
                         Rating = "PG",
                         Price = 0.00M
                     },

                     new Movie
                     {
                         Title = "The Best Two Years",
                         ReleaseDate = DateTime.Parse("02-20-2004"),
                         Genre = "Drama",
                         Rating = "PG",
                         Price = 1.99M
                     },

                     new Movie
                     {
                         Title = "The Testaments: Of One Fold and One Shepherd",
                         ReleaseDate = DateTime.Parse("03-24-2000"),
                         Genre = "Drama",
                         Rating = "NR",
                         Price = 0.00M
                     }
                );
                context.SaveChanges();
            }
        }
    }
}
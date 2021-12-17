using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using csci340lab7.Data;
using System;
using System.Linq;

namespace csci340lab7.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new csci340lab7Context(
                serviceProvider.GetRequiredService<
                    DbContextOptions<csci340lab7Context>>()))
            {
                // Look for any movies.
                if (context.Game.Any())
                {
                    return;   // DB has been seeded
                }

                context.Game.AddRange(
                    new Game
                    {
                        Title = "World of Warcraft",
                        ReleaseDate = DateTime.Parse("2004-11-23"),
                        Genre = "MMORPG",
                        Price = 0
                        Rating = "A+"
                    },

                    new Game
                    {
                        Title = "Minecraft",
                        ReleaseDate = DateTime.Parse("2011-11-08"),
                        Genre = "Sandbox, Survival",
                        Price = 27
                        Rating = "A-"
                    }

                   
                );
                context.SaveChanges();
            }
        }
    }
}
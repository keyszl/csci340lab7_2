using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using csci340lab7.Models;

namespace csci340lab7.Data
{
    public class csci340lab7Context : DbContext
    {
        public csci340lab7Context (DbContextOptions<csci340lab7Context> options)
            : base(options)
        {
        }

        public DbSet<csci340lab7.Models.Game> Game { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie11.Models;

namespace RazorPagesMovie11.Data
{
    public class RazorPagesMovie11Context : DbContext
    {
        public RazorPagesMovie11Context (DbContextOptions<RazorPagesMovie11Context> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesMovie11.Models.Movie> Movie { get; set; }
    }
}

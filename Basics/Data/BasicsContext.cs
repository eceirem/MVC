using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Basics.Models;

namespace Basics.Data
{
    public class BasicsContext : DbContext
    {
        public BasicsContext (DbContextOptions<BasicsContext> options)
            : base(options)
        {
        }

        public DbSet<Basics.Models.Movie> Movie { get; set; } = default!;
    }
}

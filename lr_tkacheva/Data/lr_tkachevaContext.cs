using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

namespace lr_tkacheva.Data
{
    public class lr_tkachevaContext : DbContext
    {
        public lr_tkachevaContext (DbContextOptions<lr_tkachevaContext> options)
            : base(options)
        {
        }

        public DbSet<MvcMovie.Models.Movie> Movie { get; set; } = default!;
    }
}

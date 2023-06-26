using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using pzlab010.Models;

namespace pzlab010.Data
{
    public class pzlab010Context : DbContext
    {
        public pzlab010Context (DbContextOptions<pzlab010Context> options)
            : base(options)
        {
        }

        public DbSet<pzlab010.Models.Movie> Movie { get; set; } = default!;
    }
}

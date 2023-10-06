using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using latihan5.Models;

namespace latihan5.Data
{
    public class latihan5Context : DbContext
    {
        public latihan5Context (DbContextOptions<latihan5Context> options)
            : base(options)
        {
        }

        public DbSet<latihan5.Models.Movie> Movie { get; set; } = default!;
    }
}

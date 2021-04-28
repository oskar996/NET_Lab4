using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NET_Lab4.Models;

namespace NET_Lab4.Data
{
    public class NET_Lab4Context : DbContext
    {
        public NET_Lab4Context (DbContextOptions<NET_Lab4Context> options)
            : base(options)
        {
        }

        public DbSet<NET_Lab4.Models.Game> Game { get; set; }
    }
}

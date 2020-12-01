using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EFGetStarted;

namespace shonection.Data
{
    public class shonectionContext : DbContext
    {
        public shonectionContext (DbContextOptions<shonectionContext> options)
            : base(options)
        {
        }

        public DbSet<EFGetStarted.User> User { get; set; }

        public DbSet<EFGetStarted.Cart> Cart { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ovning11.Models;

namespace Ovning11.Data
{
    public class Ovning11Context : DbContext
    {
        public Ovning11Context (DbContextOptions<Ovning11Context> options)
            : base(options)
        {
        }

        public DbSet<Ovning11.Models.Product> Product { get; set; }
    }
}

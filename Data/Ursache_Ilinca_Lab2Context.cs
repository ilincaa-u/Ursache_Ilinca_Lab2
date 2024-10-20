using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ursache_Ilinca_Lab2.Models;

namespace Ursache_Ilinca_Lab2.Data
{
    public class Ursache_Ilinca_Lab2Context : DbContext
    {
        public Ursache_Ilinca_Lab2Context (DbContextOptions<Ursache_Ilinca_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Ursache_Ilinca_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Ursache_Ilinca_Lab2.Models.Publisher> Publisher { get; set; } = default!;
    }
}

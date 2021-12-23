using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataGridSystem.Models
{
    public class ApplicationContext: DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Categorey> Categoreys { get; set; }
        public DbSet<SubCatagorey> SubCatagoreys { get; set; }
    }
}

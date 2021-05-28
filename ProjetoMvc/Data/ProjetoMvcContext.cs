using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ProjetoMvc.Models
{
    public class ProjetoMvcContext : DbContext
    {
        public ProjetoMvcContext (DbContextOptions<ProjetoMvcContext> options)
            : base(options)
        {
        }
        
        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }
    }
}

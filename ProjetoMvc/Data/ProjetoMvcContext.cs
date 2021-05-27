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

        public DbSet<ProjetoMvc.Models.Department> Department { get; set; }
    }
}

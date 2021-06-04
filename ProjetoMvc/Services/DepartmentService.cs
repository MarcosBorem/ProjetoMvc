using ProjetoMvc.Models;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoMvc.Services
{
    public class DepartmentService
    {
        private readonly ProjetoMvcContext _context;

        public DepartmentService(ProjetoMvcContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
;        }
    }
}

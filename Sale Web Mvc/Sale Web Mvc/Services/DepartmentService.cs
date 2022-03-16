using Sale_Web_Mvc.Data;
using Sale_Web_Mvc.Models;
using System.Collections.Generic;
using System.Linq;

namespace Sale_Web_Mvc.Services
{
    public class DepartmentService
    {
        private readonly Sale_Web_MvcContext _context;

        public DepartmentService(Sale_Web_MvcContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}

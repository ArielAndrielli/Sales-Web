using Sale_Web_Mvc.Data;
using Sale_Web_Mvc.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sale_Web_Mvc.Services
{
    public class DepartmentService
    {
        private readonly Sale_Web_MvcContext _context;

        public DepartmentService(Sale_Web_MvcContext context)
        {
            _context = context;
        }

        public async Task<List<Department>>  FindAllAsync() //Para você transformar a operação em assíncrona você deve colocar o Task na frente do 'List<Department>'. O sulfixo 'Async' é uma recomendação do C#
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync(); //Pra que se possa fazer uma chamada assíncrona no método é necessário avisar ao complilador que isso é uma chamada assíncrona 
        }
    }
}

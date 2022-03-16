using Sale_Web_Mvc.Data;
using Sale_Web_Mvc.Models;
using System.Collections.Generic;
using System.Linq;

namespace Sale_Web_Mvc.Services
{
    public class SellerService
    {
        private readonly Sale_Web_MvcContext _context;

        public SellerService(Sale_Web_MvcContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }

        public void Insert(Seller obj)
        {
            obj.Department = _context.Department.First();
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}

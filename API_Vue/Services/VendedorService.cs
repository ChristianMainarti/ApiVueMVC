using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_Vue.Models;

namespace API_Vue.Services
{
    public class VendedorService
    {
        private readonly AppDbContext _context;
        public VendedorService(AppDbContext context)
        {
            _context = context;
        }

        public List<Vendedor> FindAll()
        {
            return _context.Vendedor.ToList();
        }

        public void Insert(Vendedor obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}

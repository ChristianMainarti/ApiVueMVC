using API_Vue.Models;
using System.Collections.Generic;
using System.Linq;

namespace API_Vue.Services
{
    public class DepartamentoService
    {
        private readonly AppDbContext _context;

        public DepartamentoService(AppDbContext context)
        {
            _context = context;
        }

        public List<Departamento> FindAll()
        {
            return _context.Departamentos.OrderBy(x => x.Nome).ToList();
        }


    }
}

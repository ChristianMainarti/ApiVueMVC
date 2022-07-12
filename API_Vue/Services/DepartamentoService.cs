using API_Vue.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace API_Vue.Services
{
    public class DepartamentoService
    {
        private readonly AppDbContext _context;

        public DepartamentoService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Departamento>> FindAllSync()
        {
            return await _context.Departamentos.OrderBy(x => x.Nome).ToListAsync();
        }

    }
}

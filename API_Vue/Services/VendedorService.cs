using System;
using System.Collections.Generic;
using System.Linq;
using API_Vue.Models;
using Microsoft.EntityFrameworkCore;
using API_Vue.Services.Exceptions;
using System.Threading.Tasks;

namespace API_Vue.Services
{
    public class VendedorService
    {
        private readonly AppDbContext _context;
        public VendedorService(AppDbContext context)
        {
            _context = context;
        }
         
        public async Task<List<Vendedor>> FindAllSync()
        {
            return await _context.Vendedor.ToListAsync();
        }

        public void Insert(Vendedor obj)
        {
            _context.Add(obj);
            _context.SaveChangesAsync();
        }

        public async Task<Vendedor> FindByIdAsync(int id)
        {
            return await _context.Vendedor.Include(obj => obj.Departamento).FirstOrDefaultAsync();
        }

        public async Task RemoveAsync(int id)
        {
            try
            {
                var obj = await _context.Vendedor.FindAsync(id);
                _context.Vendedor.Remove(obj);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException e)
            {
                throw new IntegrityException(e.Message);
            }
        }

        public void UpdateAsync(Vendedor obj)
        {
            bool hasAny = _context.Vendedor.Any(x => x.Id == obj.Id);

            if (!hasAny)
                throw new NotFoundException("Id Not Found");

            try
            {
                _context.Update(obj);
                _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException e)
            {
                throw new DbUpdateConcurrencyException(e.Message);
            }
        }
    }
}

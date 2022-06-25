using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using System.Threading.Tasks;

namespace API_Vue.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options) : base(options)
        {

        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Estoque> Estoques { get; set; }
        public DbSet<Vendedor> Vendedor { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<RegistroVenda> RegistroVendas { get; set; }
    }
}

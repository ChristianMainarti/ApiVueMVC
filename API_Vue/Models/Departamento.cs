using System;
using System.Linq;
using System.Collections.Generic;

namespace API_Vue.Models
{
    public class Departamento
    {
        public int Id { get; set; }
        public string Nome { get; set;}
        public ICollection<Vendedor> Vendedores { get; set; } = new List<Vendedor>();

        public double TVendas { get; set; }

        public Departamento()
        {
        }
        public Departamento(int id, string nome, DateTime inicio, DateTime final)
        {
            Id = id;
            Nome = nome;
            TotalVendas(inicio, final);
        }
        public void AdicionarVendedor(Vendedor vendedor) 
        {
            Vendedores.Add(vendedor);
        }

        public double TotalVendas(DateTime inicio, DateTime final) 
        {
            return Vendedores.Sum(vend => vend.TotalVendas(inicio, final));
        }
    }
}

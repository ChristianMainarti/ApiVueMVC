using System;
using System.Collections.Generic;
using System.Linq;

namespace API_Vue.Models
{
    public class Vendedor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataNasc { get; set; }
        public double SalarioBase { get; set; }
        public Departamento Departamento { get; set; }
        public int DepartamentoId { get; set; }
        public ICollection<RegistroVenda> Vendas { get; set; } = new List<RegistroVenda>();

        public Vendedor() 
        {
        }

        public Vendedor( int id, string nome, string email, DateTime dataNasc, double salarioBase,Departamento departamento ) 
        {
            Id = id;
            Nome = nome;
            Email = email;
            DataNasc = dataNasc;
            SalarioBase = salarioBase;
            Departamento = departamento;
        }

        public void RealizaVenda(RegistroVenda registroVenda) 
        {
            Vendas.Add( registroVenda );
        }

        public void RemoveVenda (RegistroVenda registroVenda)
        {
            Vendas.Remove(registroVenda);
        }

        public double TotalVendas(DateTime inicio, DateTime final) 
        {
            return Vendas
                .Where(rv => rv.Data >= inicio && rv.Data <= final)
                .Sum(rv => rv.Montante);    
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace API_Vue.Models
{
    public class Vendedor
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} required")]
        [StringLength(60, MinimumLength = 4, ErrorMessage = "{0} size should be between {2} and {1}")]
        public string Nome { get; set; }

        [Required(ErrorMessage ="{0} required")]
        [EmailAddress(ErrorMessage ="Enter a Valid email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "Data de Nascimento")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:dd/MM/yyyy}")]
        public DateTime DataNasc { get; set; }

        [Required(ErrorMessage ="{0} required")]
        [Range(100.0,50000.0, ErrorMessage ="{0} must be from {1} to {2}")]
        [Display(Name ="Salário Base")]
        [DisplayFormat(DataFormatString ="{0:F2}")]
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

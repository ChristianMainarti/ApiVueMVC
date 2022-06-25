using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API_Vue.Models
{
    public class Estoque
    {
        public Estoque()
        { }

        public int EstoqueId { get; set; }
        public string NomeEstoque { get; set; }
        public int CodProduto { get; set; }
        public float Quantidade { get; set; }

    }
}

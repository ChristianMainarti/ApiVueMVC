using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Vue.Models
{
    public class Produto
    {
        public Produto()
        { }

        public int ProdutoId { get; set; }
        public int Nome { get; set; }
        public float Preco { get; set; }
        public Estoque Estoque { get; set; }
    }
}

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
        public string Nome { get; set; }

        //[ForeignKey("Produto")]
        //public int ProdutoId { get; set; }
        //public virtual Produto Produto { get; set; }

        public float Quantidade { get; set; }
        public virtual ICollection<Produto> Produtos { get; set; } = new List<Produto>();
    }
}

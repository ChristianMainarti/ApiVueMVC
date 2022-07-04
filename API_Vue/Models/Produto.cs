using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace API_Vue.Models
{
    public class Produto
    {
        public Produto()
        { }

        public int ProdutoId { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }
        [JsonPropertyName("img")]
        public string Imagem { get; set; }

        [ForeignKey("Estoque")]
        public int EstoqueId { get; set; }
        public virtual Estoque Estoque { get;set; }

        public override string ToString() => JsonSerializer.Serialize<Produto>(this); 
    }
}

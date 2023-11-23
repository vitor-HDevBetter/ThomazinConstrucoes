using System.ComponentModel.DataAnnotations;

namespace ThomazinConstrucoes.Business.Models
{
    public class Produto
    {
        [Key]
        public long IdProduto { get; set; }
        public string Nome { get; set; }
        public string Marca { get; set; }
        public string Tamanho { get; set; }
        public decimal ValorCusto { get; set; }
        public decimal ValorVenda { get; set; }
        public long Estoque { get; set; }
        public string Obs { get; set; }
        public string PathImagem { get; set; }
        public string Codigo { get; set; }
        public DateTime DhCriacao { get; set; }
        public bool Ativo { get; set; }
        public DateTime? DhDesativacao { get; set; }

    }
}

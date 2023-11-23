using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThomazinConstrucoes.Business.Models
{
    public class Proposta
    {
        [Key]
        public long IdProposta { get; set; }
        public long IdProdutoUsuario { get; set; }
        public long ValorCusto { get; set; }
        public long ValorVenda { get; set; }
        public long Quantidade { get; set; }
        public long ValorFrete { get; set; }
        public DateTime DhCriacao { get; set; }
        public bool Venda { get; set; }
        public DateTime DhVenda { get; set; }
        public string Obs { get; set; }



    }
}

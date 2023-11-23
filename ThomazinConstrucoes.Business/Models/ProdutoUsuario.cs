using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThomazinConstrucoes.Business.Models
{
    public class ProdutoUsuario
    {
        [Key]
        public long IdProdutoUsuario { get; set; }
        public long IdProduto { get; set; }
        public long IdUsuario { get; set; }



    }
}

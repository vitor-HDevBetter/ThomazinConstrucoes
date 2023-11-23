using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThomazinConstrucoes.Business.Models
{
    public class Usuario
    {
        [Key]
        public long IdUsuario { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Celular { get; set; }
        public string CEP { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Telefone { get; set; }
        public DateTime DhCriacao { get; set; }
        public bool Ativo { get; set; }



    }
}

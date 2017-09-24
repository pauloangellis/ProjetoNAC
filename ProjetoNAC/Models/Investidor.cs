using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ProjetoNAC.Models
{
    public class Investidor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        [Display(Name ="E-mail")]
        public string Email { get; set; }
        public string Telefone { get; set; }
        [Display(Name = "Gênero")]
        public string Genero { get; set; }
        [Display(Name = "Endereço")]
        public string Endereco { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
    }
}
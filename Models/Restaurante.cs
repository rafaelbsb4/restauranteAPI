using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoNovo.Repository
{
    public class Restaurante
    {

        [Key]
        public int idRestaurante { get; set; }
        [Required]
        public string nomeRestaurante { get; set; }
    }
}
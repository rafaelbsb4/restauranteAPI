using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProjetoNovo.Repository
{
    public class Pratos
    {
        [Key]
        public int idPrato { get; set; }

        [Required]
        public string nomePrato { get; set; }

        public float valorPrato { get; set; }

        [Required]
        public int idRestaurante { get; set; }

        [ForeignKey("idRestaurante")]
        public virtual Restaurante Restaurante { get; set; }
    }
}
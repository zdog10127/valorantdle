using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Valorantdle.Dominio.Entidades
{
    [Table("Arsenal")]
    public class Arsenal
    {
        [Key]
        [Required]
        [Column("IdArma", TypeName = "int")]
        public int IdArma { get; set; }

        [Column("Nome", TypeName = "varchar")]
        [MaxLength(45)]
        public string Nome { get; set; }

        [Column("Tipo", TypeName = "varchar")]
        [MaxLength(45)]
        public string Tipo { get; set; }

        [Column("Descricao", TypeName = "varchar")]
        [MaxLength(200)]
        public string Descricao { get; set; }

        [Column("Preco", TypeName = "int")]
        public int Preco { get; set; }

        [Column("ImagemArma", TypeName = "varchar")]
        [MaxLength(500)]
        public string ImagemArma { get; set; }
    }
}

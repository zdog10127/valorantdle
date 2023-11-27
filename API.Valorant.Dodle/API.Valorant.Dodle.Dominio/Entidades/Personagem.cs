using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Valorantdle.Dominio.Entidades
{
    [Table("Personagem")]
    public class Personagem
    {
        [Key]
        [Required]
        [Column("IdPersonagem", TypeName = "int")]
        public int IdPersonagem { get; set; }

        [Column("Nome", TypeName = "varchar")]
        [MaxLength(45)]
        public string Nome { get; set; }

        [Column("Descricao", TypeName = "varchar")]
        [MaxLength(255)]
        public string Descricao { get; set; }

        [Column("Regiao", TypeName = "varchar")]
        [MaxLength(45)]
        public string Regiao { get; set; }

        [Column("Funcao", TypeName = "varchar")]
        [MaxLength(45)]
        public string Funcao { get; set; }

        [Column("ImagemPersonagem", TypeName = "varchar")]
        [MaxLength(500)]
        public string ImagemPersonagem { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Valorantdle.Dominio.Entidades
{
    [Table("Skin")]
    public class Skin
    {
        [Key]
        [Required]
        [Column("IdSkin", TypeName = "int")]
        public int IdSkin { get; set; }

        [Required]
        [Column("IdArma", TypeName = "int")]
        public int IdArma { get; set; }

        [Column("Nome", TypeName = "varchar")]
        [MaxLength(45)]
        public string Nome { get; set; }

        [Column("Pacote", TypeName = "varchar")]
        [MaxLength(45)]
        public string Pacote { get; set; }

        [Column("ImagemSkin", TypeName = "varchar")]
        [MaxLength(500)]
        public string ImagemSkin { get; set; }

        [Column("Rara", TypeName = "char")]
        public bool Rara { get; set; }

        [ForeignKey("IdArma")]
        public Arsenal Arsenal { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Valorantdle.Dominio.Entidades
{
    [Table("Mapas")]
    public class Mapas
    {
        [Key]
        [Required]
        [Column("IdMapa", TypeName = "int")]
        public int IdMapa { get; set; }

        [Column("Nome", TypeName = "varchar")]
        [MaxLength(45)]
        public string Nome { get; set; }

        [Column("Região", TypeName = "varchar")]
        [MaxLength(45)]
        public string Região { get; set; }

        [Column("ImagemMapa", TypeName = "varchar")]
        [MaxLength(500)]
        public string ImagemMapa { get; set; }
    }
}

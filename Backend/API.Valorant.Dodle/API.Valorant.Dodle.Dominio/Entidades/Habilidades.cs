using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Valorantdle.Dominio.Entidades
{
    [Table("Habilidades")]
    public class Habilidades
    {
        [Key]
        [Required]
        [Column("IdHabilidade", TypeName = "int")]
        public int IdHabilidade { get; set; }

        [Required]
        [Column("IdPersonagem", TypeName = "int")]
        public int IdPersonagem { get; set; }

        [Column("PrimeiraHabilidade", TypeName = "varchar")]
        [MaxLength(45)]
        public string PrimeiraHabilidade { get; set; }

        [Column("DescricaoPrimeiraHabilidade", TypeName = "varchar")]
        [MaxLength(255)]
        public string DescricaoPrimeiraHabilidade { get; set; }

        [Column("ImagemPrimeiraHabilidade", TypeName = "varchar")]
        [MaxLength(500)]
        public string ImagemPrimeiraHabilidade { get; set; }

        [Column("SegundaHabilidade", TypeName = "varchar")]
        [MaxLength(45)]
        public string SegundaHabilidade { get; set; }

        [Column("DescricaoSegundaHabilidade", TypeName = "varchar")]
        [MaxLength(255)]
        public string DescricaoSegundaHabilidade { get; set; }

        [Column("ImagemSegundaHabilidade", TypeName = "varchar")]
        [MaxLength(500)]
        public string ImagemSegundaHabilidade { get; set; }

        [Column("TerceiraHabilidade", TypeName = "varchar")]
        [MaxLength(45)]
        public string TerceiraHabilidade { get; set; }

        [Column("DescricaoTerceiraHabilidade", TypeName = "varchar")]
        [MaxLength(255)]
        public string DescricaoTerceiraHabilidade { get; set; }

        [Column("ImagemTerceiraHabilidade", TypeName = "varchar")]
        [MaxLength(500)]
        public string ImagemTerceiraHabilidade { get; set; }

        [Column("UltimaHabildade", TypeName = "varchar")]
        [MaxLength(45)]
        public string UltimaHabildade { get; set; }

        [Column("DescricaoUltimaHabildade", TypeName = "varchar")]
        [MaxLength(255)]
        public string DescricaoUltimaHabildade { get; set; }

        [Column("ImagemUltimaHabilidade", TypeName = "varchar")]
        [MaxLength(500)]
        public string ImagemUltimaHabilidade { get; set; }

        [ForeignKey("IdPersonagem")]
        public Personagem Personagem { get; set; }
    }
}

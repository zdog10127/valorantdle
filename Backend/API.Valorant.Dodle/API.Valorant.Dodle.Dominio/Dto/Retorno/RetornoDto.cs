using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Valorant.Dodle.Dominio.Dto.Retorno
{
    public class RetornoDto
    {
        public bool HouveErro { get; set; }
        public string? TituloErro { get; set; }
        public string? MensagemErro { get; set; }
        public string? CodigoErro { get; set; }
        public string? ObjetoRetorno { get; set; }
    }
}

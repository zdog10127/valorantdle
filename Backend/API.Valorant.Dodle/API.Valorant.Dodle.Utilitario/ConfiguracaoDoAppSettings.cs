using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Valorant.Dodle.Utilitario
{
    public class ConfiguracaoDoAppSettings
    {
        public static string ObterStringDeConexaoSql()
        {
            Configuracao configuracao = new Configuracao();
            return configuracao.ConfiguracaoDoArquivoAppSettings["ConnectionStringSqlServer"];
        }
    }
}

using API.Valorantdle.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Valorantdle.Dominio.Interfaces.Repositorio
{
    public interface IRepositorioArsenal
    {
        Task<List<Arsenal>> ListarTodasAsArmasDoArsenal();
        Task<List<Arsenal>> BuscarArmasPeloTipo(string tipo);
        Task<Arsenal> BuscarPeloNome(string nome);
        Task CadastrarArma(Arsenal arsenal);
        Task AtualizarArma(int idMapas, Arsenal arsenal);
        Task DeletarArma(int idArma);
    }
}

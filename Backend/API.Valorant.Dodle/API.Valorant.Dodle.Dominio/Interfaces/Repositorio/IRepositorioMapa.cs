using API.Valorantdle.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Valorantdle.Dominio.Interfaces.Repositorio
{
    public interface IRepositorioMapa
    {
        Task<List<Mapas>> ListarTodosOsMapas();
        Task<Mapas> BuscarMapaPorNome(string nome);
        Task GravarMapa(Mapas mapas);
        Task AtualizarMapa(int idMapas, Mapas mapas);
        Task DeletarMapa(int idMapas);
    }
}

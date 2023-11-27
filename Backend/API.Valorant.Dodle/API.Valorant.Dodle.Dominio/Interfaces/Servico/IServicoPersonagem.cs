using API.Valorantdle.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Valorantdle.Dominio.Interfaces.Servico
{
    public interface IServicoPersonagem
    {
        Task<List<Personagem>> ListarTodosOsPersonagens();
        Task<Personagem> BuscarPersonagemPorNome(string Nome);
        Task GravarPersonagem(Personagem personagem);
        Task AtualizarPersonagem(int idPersonagem, Personagem personagem);
        Task DeletarPersonagem(int idPersonagem);
    }
}

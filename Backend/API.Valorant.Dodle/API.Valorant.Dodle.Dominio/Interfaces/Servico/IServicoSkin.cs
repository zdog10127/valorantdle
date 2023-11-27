using API.Valorantdle.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Valorantdle.Dominio.Interfaces.Servico
{
    public interface IServicoSkin
    {
        Task<List<Skin>> ListarTodasAsSkin();
        Task<List<Skin>> ListarTodasAsSkinDoPacote(string pacote);
        Task<Skin> BuscarSkinPorNome(string nome);
        Task CadastrarSkin(Skin skin);
        Task AtualizarSkin(int idArma, Skin skin);
        Task DeletarSkin(int idArma, Skin skin);
    }
}

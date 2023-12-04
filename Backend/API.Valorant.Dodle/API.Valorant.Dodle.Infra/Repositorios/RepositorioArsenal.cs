using API.Valorant.Dodle.Infra.Contextos;
using API.Valorantdle.Dominio.Entidades;
using API.Valorantdle.Dominio.Interfaces.Repositorio;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace API.Valorant.Dodle.Infra.Repositorios
{
    public class RepositorioArsenal : IRepositorioArsenal
    {
        private readonly Contexto _contexto;

        public RepositorioArsenal()
        {
            _contexto = new Contexto(); 
        }

        public async Task AtualizarArma(int idArma, Arsenal arsenal)
        {
            var armaExistente = await _contexto.Set<Arsenal>().Where(x => x.IdArma == idArma).FirstOrDefaultAsync();
            if (armaExistente != null)
            {
                armaExistente.Nome = arsenal.Nome;
                armaExistente.Descricao = arsenal.Descricao;
                armaExistente.Tipo = arsenal.Tipo;
                armaExistente.Preco = arsenal.Preco;
                armaExistente.ImagemArma = arsenal.ImagemArma;

                _contexto.Arsenal.Update(armaExistente);
                await _contexto.SaveChangesAsync();
            }
        }

        public async Task<List<Arsenal>> BuscarArmasPeloTipo(string tipo)
        {
            var tipos = await _contexto.Set<Arsenal>().Where(x => x.Tipo == tipo).ToListAsync();
            return tipos;
        }

        public async Task<Arsenal> BuscarPeloNome(string nome)
        {
            var arma = await _contexto.Set<Arsenal>().Where(x => x.Nome == nome).FirstOrDefaultAsync();
            return arma;
        }

        public async Task CadastrarArma(Arsenal arsenal)
        {
            await _contexto.Arsenal.AddAsync(arsenal);
            await _contexto.SaveChangesAsync();
        }

        public async Task DeletarArma(int idArma)
        {
            var arma = await _contexto.Set<Arsenal>().Where(x => x.IdArma == idArma).FirstOrDefaultAsync();
            if (arma != null)
            {
                _contexto.Arsenal.Remove(arma);
                await _contexto.SaveChangesAsync();
            }
        }

        public async Task<List<Arsenal>> ListarTodasAsArmasDoArsenal()
        {
            var lista = await _contexto.Arsenal.ToListAsync();
            return lista;
        }
    }
}

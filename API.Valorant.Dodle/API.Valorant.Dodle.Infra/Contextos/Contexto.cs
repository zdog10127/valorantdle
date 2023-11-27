using API.Valorant.Dodle.Utilitario;
using API.Valorantdle.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Reflection;


namespace API.Valorant.Dodle.Infra.Contextos
{
    public class Contexto : DbContext
    {
        private readonly string BancoDeDados;

        public Contexto()
        {
            BancoDeDados = ConfiguracaoDoAppSettings.ObterStringDeConexaoSql();
        }

        public Contexto(DbContextOptions<Contexto> options) : base(options) { }

        public virtual DbSet<Arsenal> Arsenal { get; set; }
        public virtual DbSet<Habilidades> Habilidades { get; set; }
        public virtual DbSet<Mapas> Mapas { get; set; }
        public virtual DbSet<Personagem> Personagem { get; set; }
        public virtual DbSet<Skin> Skin { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(BancoDeDados);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            modelBuilder.HasDefaultSchema("dbo");
        }
    }
}

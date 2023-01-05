using Microsoft.EntityFrameworkCore;
using sb_ceak.Dominio.Entidade;
using sb_ceak.Repositorio.Config;

namespace sb_ceak.Repositorio.Contexto
{
    public class SB_CEAKContexto : DbContext
    {
        public DbSet<Autores> Autor                                 { get; set; }
        public DbSet<EmprestimoDevolucoes> EmprestimoDevolucao      { get; set; }
        public DbSet<Funcoes> Funcao                                { get; set; }
        public DbSet<Logs> Log                                      { get; set; }
        public DbSet<Obras> Obra                                    { get; set; }
        public DbSet<Operacoes> Operacao                            { get; set; }
        public DbSet<Parametros> Parametro                          { get; set; }
        public DbSet<Perfis> Perfil                                 { get; set; }
        public DbSet<Pessoas> Pessoa                                { get; set; }
        public DbSet<Reservas> Reserva                              { get; set; }
        public DbSet<Telefones> Telefone                            { get; set; }
        public DbSet<TipoAutores> TipoAutor                         { get; set; }
        public DbSet<TipoObras> TipoObra                            { get; set; }
        public DbSet<TipoTelefones> TipoTelefone                    { get; set; }

        public SB_CEAKContexto(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Classes de mapeamento aqui...
            modelBuilder.ApplyConfiguration(new AutoresConfiguration());
            modelBuilder.ApplyConfiguration(new EmprestimoDevolucoesConfiguration());
            modelBuilder.ApplyConfiguration(new FuncoesConfiguration());
            modelBuilder.ApplyConfiguration(new LogsConfiguration());
            modelBuilder.ApplyConfiguration(new ObrasConfiguration());
            modelBuilder.ApplyConfiguration(new OperacoesConfiguration());
            modelBuilder.ApplyConfiguration(new ParametrosConfiguration());
            modelBuilder.ApplyConfiguration(new PerfisConfiguration());
            modelBuilder.ApplyConfiguration(new PessoasConfiguration());
            modelBuilder.ApplyConfiguration(new ReservasConfiguration());
            modelBuilder.ApplyConfiguration(new TelefonesConfiguration());
            modelBuilder.ApplyConfiguration(new TipoAutoresConfiguration());
            modelBuilder.ApplyConfiguration(new TipoObrasConfiguration());
            modelBuilder.ApplyConfiguration(new TipoTelefonesConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}

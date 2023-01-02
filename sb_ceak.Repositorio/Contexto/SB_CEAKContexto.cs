using Microsoft.EntityFrameworkCore;
using sb_ceak.Dominio.Entidade;

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

        public SB_CEAKContexto(DbContextOptions options) : base(options)
        {

        }

    }
}

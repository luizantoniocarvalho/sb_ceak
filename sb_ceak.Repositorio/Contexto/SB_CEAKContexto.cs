using Microsoft.EntityFrameworkCore;
using sb_ceak.Dominio.Entidade;
using sb_ceak.Repositorio.Config;
using System.Diagnostics;

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
        public DbSet<TipoAcervos> TipoAcervo                        { get; set; }


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
            modelBuilder.ApplyConfiguration(new TipoAcervosConfiguration());

            modelBuilder.Entity<TipoObras>().HasData(
                new TipoObras()
                {
                    tipo_obra_id =1,
                    ds_Nome_Tipo_Obra = "AUTOAJUDA",
                    in_Situacao_Registro = true,
                    criou_Registro_id = 1,
                    dt_Data_Criacao = System.DateTime.Today
                },
                new TipoObras()
                {
                    tipo_obra_id = 2,
                    ds_Nome_Tipo_Obra = "BIBLIOGRAFIA",
                    in_Situacao_Registro = true,
                    criou_Registro_id = 1,
                    dt_Data_Criacao = System.DateTime.Today
                },
                new TipoObras()
                {
                    tipo_obra_id = 3,
                    ds_Nome_Tipo_Obra = "BIOGRAFIA",
                    in_Situacao_Registro = true,
                    criou_Registro_id =1,
                    dt_Data_Criacao = System.DateTime.Today
                },
                new TipoObras()
                {
                    tipo_obra_id = 4,
                    ds_Nome_Tipo_Obra = "CARTAS",
                    in_Situacao_Registro = true,
                    criou_Registro_id = 1,
                    dt_Data_Criacao = System.DateTime.Today
                },
                new TipoObras()
                {
                    tipo_obra_id = 5,
                    ds_Nome_Tipo_Obra = "CITAÇÕES",
                    in_Situacao_Registro = true,
                    criou_Registro_id = 1,
                    dt_Data_Criacao = System.DateTime.Today
                },
                new TipoObras()
                {
                    tipo_obra_id = 6,
                    ds_Nome_Tipo_Obra = "CRÔNICA",
                    in_Situacao_Registro = true,
                    criou_Registro_id = 1,
                    dt_Data_Criacao = System.DateTime.Today
                },
                new TipoObras()
                {
                    tipo_obra_id = 7,
                    ds_Nome_Tipo_Obra = "CONFERÊNCIA",
                    in_Situacao_Registro = true,
                    criou_Registro_id = 1,
                    dt_Data_Criacao = System.DateTime.Today
                },
                new TipoObras()
                {
                    tipo_obra_id = 8,
                    ds_Nome_Tipo_Obra = "DOCUMENTÁRIO",
                    in_Situacao_Registro = true,
                    criou_Registro_id = 1,
                    dt_Data_Criacao = System.DateTime.Today
                },
                new TipoObras()
                {
                    tipo_obra_id = 9,
                    ds_Nome_Tipo_Obra = "ESTUDO",
                    in_Situacao_Registro = true,
                    criou_Registro_id = 1,
                    dt_Data_Criacao = System.DateTime.Today
                },
                new TipoObras()
                {
                    tipo_obra_id = 10,
                    ds_Nome_Tipo_Obra = "ENTREVISTA",
                    in_Situacao_Registro = true,
                    criou_Registro_id = 1,
                    dt_Data_Criacao = System.DateTime.Today
                },
                new TipoObras()
                {
                    tipo_obra_id = 11,
                    ds_Nome_Tipo_Obra = "FILME",
                    in_Situacao_Registro = true,
                    criou_Registro_id = 1,
                    dt_Data_Criacao = System.DateTime.Today
                },
                new TipoObras()
                {
                    tipo_obra_id = 12,
                    ds_Nome_Tipo_Obra = "HISTÓRIA",
                    in_Situacao_Registro = true,
                    criou_Registro_id = 1,
                    dt_Data_Criacao = System.DateTime.Today
                },
                new TipoObras()
                {
                    tipo_obra_id = 13,
                    ds_Nome_Tipo_Obra = "MEDITAÇÃO",
                    in_Situacao_Registro = true,
                    criou_Registro_id = 1,
                    dt_Data_Criacao = System.DateTime.Today
                },
                new TipoObras()
                {
                    tipo_obra_id = 14,
                    ds_Nome_Tipo_Obra = "MENSAGEM",
                    in_Situacao_Registro = true,
                    criou_Registro_id = 1,
                    dt_Data_Criacao = System.DateTime.Today
                },
                new TipoObras()
                {
                    tipo_obra_id = 15,
                    ds_Nome_Tipo_Obra = "PERGUNTAS",
                    in_Situacao_Registro = true,
                    criou_Registro_id = 1,
                    dt_Data_Criacao = System.DateTime.Today
                },
                new TipoObras()
                {
                    tipo_obra_id = 16,
                    ds_Nome_Tipo_Obra = "OUTRA",
                    in_Situacao_Registro = true,
                    criou_Registro_id = 1,
                    dt_Data_Criacao = System.DateTime.Today
                },
                new TipoObras()
                {
                    tipo_obra_id = 17,
                    ds_Nome_Tipo_Obra = "POESIA",
                    in_Situacao_Registro = true,
                    criou_Registro_id = 1,
                    dt_Data_Criacao = System.DateTime.Today
                },
                new TipoObras()
                {
                    tipo_obra_id = 18,
                    ds_Nome_Tipo_Obra = "PRECE",
                    in_Situacao_Registro = true,
                    criou_Registro_id = 1,
                    dt_Data_Criacao = System.DateTime.Today
                },
                new TipoObras()
                {
                    tipo_obra_id = 19,
                    ds_Nome_Tipo_Obra = "PALESTRA",
                    in_Situacao_Registro = true,
                    criou_Registro_id = 1,
                    dt_Data_Criacao = System.DateTime.Today
                },
                new TipoObras()
                {
                    tipo_obra_id = 20,
                    ds_Nome_Tipo_Obra = "REFLEXÃO",
                    in_Situacao_Registro = true,
                    criou_Registro_id = 1,
                    dt_Data_Criacao = System.DateTime.Today
                },
                new TipoObras()
                {
                    tipo_obra_id = 21,
                    ds_Nome_Tipo_Obra = "RÁDIO NOVELA",
                    in_Situacao_Registro = true,
                    criou_Registro_id = 1,
                    dt_Data_Criacao = System.DateTime.Today
                },
                new TipoObras()
                {
                    tipo_obra_id = 22,
                    ds_Nome_Tipo_Obra = "SEMINÁRIO",
                    in_Situacao_Registro = true,
                    criou_Registro_id = 1,
                    dt_Data_Criacao = System.DateTime.Today
                },
                new TipoObras()
                {
                    tipo_obra_id = 23,
                    ds_Nome_Tipo_Obra = "SEMINÁRIO MUSICAL",
                    in_Situacao_Registro = true,
                    criou_Registro_id = 1,
                    dt_Data_Criacao = System.DateTime.Today
                }
            );
             
            base.OnModelCreating(modelBuilder);
        }
    }
}

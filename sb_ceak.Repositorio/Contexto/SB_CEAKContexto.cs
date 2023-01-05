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
            modelBuilder.ApplyConfiguration(new Unidade_FederativasConfiguration());


            modelBuilder.Entity<Unidade_Federativas>().HasData(
                new Unidade_Federativas()
                {
                    uf_id =1,
                    ds_Nome_UF = "ACRE",
                    ds_Sigla_UF = "AC",
                    in_Situacao_Registro = true,
                    criou_Registro_id = 1,
                    dt_Data_Criacao = System.DateTime.Today
                },
                new Unidade_Federativas()
                {
                    uf_id = 2,
                    ds_Nome_UF = "ALAGOAS",
                    ds_Sigla_UF = "AL",
                    in_Situacao_Registro = true,
                    criou_Registro_id = 1,
                    dt_Data_Criacao = System.DateTime.Today
                },
                new Unidade_Federativas()
                {
                    uf_id = 3,
                    ds_Nome_UF = "AMAZONAS",
                    ds_Sigla_UF = "AM",
                    in_Situacao_Registro = true,
                    criou_Registro_id =1,
                    dt_Data_Criacao = System.DateTime.Today
                },
                new Unidade_Federativas()
                {
                    uf_id = 4,
                    ds_Nome_UF = "AMAPÁ",
                    ds_Sigla_UF = "AP",
                    in_Situacao_Registro = true,
                    criou_Registro_id = 1,
                    dt_Data_Criacao = System.DateTime.Today
                },
                new Unidade_Federativas()
                {
                    uf_id = 5,
                    ds_Nome_UF = "BAHIA",
                    ds_Sigla_UF = "BA",
                    in_Situacao_Registro = true,
                    criou_Registro_id = 1,
                    dt_Data_Criacao = System.DateTime.Today
                },
                new Unidade_Federativas()
                {
                    uf_id = 6,
                    ds_Nome_UF = "CEARÁ",
                    ds_Sigla_UF = "CE",
                    in_Situacao_Registro = true,
                    criou_Registro_id = 1,
                    dt_Data_Criacao = System.DateTime.Today
                },
                new Unidade_Federativas()
                {
                    uf_id = 7,
                    ds_Nome_UF = "DISTRITO FEDERAL",
                    ds_Sigla_UF = "DF",
                    in_Situacao_Registro = true,
                    criou_Registro_id = 1,
                    dt_Data_Criacao = System.DateTime.Today
                },
                new Unidade_Federativas()
                {
                    uf_id = 8,
                    ds_Nome_UF = "ESPÍRITO SANTO",
                    ds_Sigla_UF = "ES",
                    in_Situacao_Registro = true,
                    criou_Registro_id = 1,
                    dt_Data_Criacao = System.DateTime.Today
                },
                new Unidade_Federativas()
                {
                    uf_id = 9,
                    ds_Nome_UF = "GOIÁS",
                    ds_Sigla_UF = "GO",
                    in_Situacao_Registro = true,
                    criou_Registro_id = 1,
                    dt_Data_Criacao = System.DateTime.Today
                },
                new Unidade_Federativas()
                {
                    uf_id = 10,
                    ds_Nome_UF = "MARANHÃO",
                    ds_Sigla_UF = "MA",
                    in_Situacao_Registro = true,
                    criou_Registro_id = 1,
                    dt_Data_Criacao = System.DateTime.Today
                },
                new Unidade_Federativas()
                {
                    uf_id = 11,
                    ds_Nome_UF = "MINAS GERAIS",
                    ds_Sigla_UF = "MG",
                    in_Situacao_Registro = true,
                    criou_Registro_id = 1,
                    dt_Data_Criacao = System.DateTime.Today
                },
                new Unidade_Federativas()
                {
                    uf_id = 12,
                    ds_Nome_UF = "MATO GROSSO DO SUL",
                    ds_Sigla_UF = "MS",
                    in_Situacao_Registro = true,
                    criou_Registro_id = 1,
                    dt_Data_Criacao = System.DateTime.Today
                },
                new Unidade_Federativas()
                {
                    uf_id = 13,
                    ds_Nome_UF = "MATO GROSSO",
                    ds_Sigla_UF = "MT",
                    in_Situacao_Registro = true,
                    criou_Registro_id = 1,
                    dt_Data_Criacao = System.DateTime.Today
                },
                new Unidade_Federativas()
                {
                    uf_id = 14,
                    ds_Nome_UF = "PARÁ",
                    ds_Sigla_UF = "PA",
                    in_Situacao_Registro = true,
                    criou_Registro_id = 1,
                    dt_Data_Criacao = System.DateTime.Today
                },
                new Unidade_Federativas()
                {
                    uf_id = 15,
                    ds_Nome_UF = "PARAÍBA",
                    ds_Sigla_UF = "PB",
                    in_Situacao_Registro = true,
                    criou_Registro_id = 1,
                    dt_Data_Criacao = System.DateTime.Today
                },
                new Unidade_Federativas()
                {
                    uf_id = 16,
                    ds_Nome_UF = "PERNAMBUCO",
                    ds_Sigla_UF = "PE",
                    in_Situacao_Registro = true,
                    criou_Registro_id = 1,
                    dt_Data_Criacao = System.DateTime.Today
                },
                new Unidade_Federativas()
                {
                    uf_id = 17,
                    ds_Nome_UF = "PIAUÍ",
                    ds_Sigla_UF = "PI",
                    in_Situacao_Registro = true,
                    criou_Registro_id = 1,
                    dt_Data_Criacao = System.DateTime.Today
                },
                new Unidade_Federativas()
                {
                    uf_id = 18,
                    ds_Nome_UF = "PARANÁ",
                    ds_Sigla_UF = "PR",
                    in_Situacao_Registro = true,
                    criou_Registro_id = 1,
                    dt_Data_Criacao = System.DateTime.Today
                },
                new Unidade_Federativas()
                {
                    uf_id = 19,
                    ds_Nome_UF = "RIO DE JANEIRO",
                    ds_Sigla_UF = "RJ",
                    in_Situacao_Registro = true,
                    criou_Registro_id = 1,
                    dt_Data_Criacao = System.DateTime.Today
                },
                new Unidade_Federativas()
                {
                    uf_id = 20,
                    ds_Nome_UF = "RIO GRANDE DO NORTE",
                    ds_Sigla_UF = "RN",
                    in_Situacao_Registro = true,
                    criou_Registro_id = 1,
                    dt_Data_Criacao = System.DateTime.Today
                },
                new Unidade_Federativas()
                {
                    uf_id = 21,
                    ds_Nome_UF = "RONDÔNIA",
                    ds_Sigla_UF = "EO",
                    in_Situacao_Registro = true,
                    criou_Registro_id = 1,
                    dt_Data_Criacao = System.DateTime.Today
                },
                new Unidade_Federativas()
                {
                    uf_id = 22,
                    ds_Nome_UF = "RORAIMA",
                    ds_Sigla_UF = "RR",
                    in_Situacao_Registro = true,
                    criou_Registro_id = 1,
                    dt_Data_Criacao = System.DateTime.Today
                },
                new Unidade_Federativas()
                {
                    uf_id = 23,
                    ds_Nome_UF = "RIO GRANDE DO SUL",
                    ds_Sigla_UF = "RS",
                    in_Situacao_Registro = true,
                    criou_Registro_id = 1,
                    dt_Data_Criacao = System.DateTime.Today
                },
                new Unidade_Federativas()
                {
                    uf_id = 24,
                    ds_Nome_UF = "SANTA CATARINA",
                    ds_Sigla_UF = "SC",
                    in_Situacao_Registro = true,
                    criou_Registro_id = 1,
                    dt_Data_Criacao = System.DateTime.Today
                },
                new Unidade_Federativas()
                {
                    uf_id = 25,
                    ds_Nome_UF = "SERGIPE",
                    ds_Sigla_UF = "SE",
                    in_Situacao_Registro = true,
                    criou_Registro_id = 1,
                    dt_Data_Criacao = System.DateTime.Today
                },
                new Unidade_Federativas()
                {
                    uf_id = 26,
                    ds_Nome_UF = "SÃO PAULO",
                    ds_Sigla_UF = "SP",
                    in_Situacao_Registro = true,
                    criou_Registro_id = 1,
                    dt_Data_Criacao = System.DateTime.Today
                },
                new Unidade_Federativas()
                {
                    uf_id = 27,
                    ds_Nome_UF = "TOCANTINS",
                    ds_Sigla_UF = "TO",
                    in_Situacao_Registro = true,
                    criou_Registro_id = 1,
                    dt_Data_Criacao = System.DateTime.Today
                }
            );
            
            base.OnModelCreating(modelBuilder);
        }
    }
}

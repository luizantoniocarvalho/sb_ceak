using sb_ceak.Dominio.Enumerações;
using System;

namespace sb_ceak.Dominio.Entidade
{
    public class Obras : Entidades
    {
        public int obra_id                          { get; set; }
        public int tipo_obra_id                     { get; set; }
        public int autor_id                         { get; set; }
        public int prazo_id                         { get; set; }
        public string ds_Nome_Obra                  { get; set; }
        public string ds_Codigo_Obra                { get; set; }
        public string ds_Duracao_Obra               { get; set; }
        public string ds_Divulgadora_Obra           { get; set; }
        public string ds_Edicao_Obra                { get; set; }
        public string ds_Mes_Ano_Publicacao_Obra    { get; set; }
        public string ds_Ano_Publicacao_Obra        { get; set; }
        public string ds_Editora_Obra               { get; set; }
        public int qtd_Pagina_Obra                  { get; set; }
        public string ds_CDU_Obra                   { get; set; }
        public string ds_CDD_Obra                   { get; set; }
        public DateTime dt_Data_Cadastro_Obra       { get; set; }
        public bool in_Situacao_Registro            { get; set; }
        public int criou_Registro_id                { get; set; }
        public DateTime dt_Data_Criacao             { get; set; }
        public int alterou_Registro_id              { get; set; }
        public DateTime dt_Data_Alteracao           { get; set; }

        public bool TipoLivro
        {
            get { return tipo_obra_id == (int)TipoObras.Livros; }
        }

        public bool TipoDVD
        {
            get { return tipo_obra_id == (int)TipoObras.DVD; }
        }

        public bool Prazo15Dias
        {
            get { return prazo_id == (int)Prazos.Dias_15; }
        }

        public bool Prazo30Dias
        {
            get { return prazo_id == (int)Prazos.Dias_30; }
        }

        public override void Validate()
        {
            LimparMensagemValidacao();

            if (string.IsNullOrEmpty(ds_Nome_Obra))
                AdicionarMensagemValidacao("Nome da Obra é campo obrigatório.");
        }
    }
}

using System;

namespace sb_ceak.Dominio.Entidade
{
    public class Obras : Entidades
    {
        public int obra_id                          { get; set; }
        public int tipo_obra_id                     { get; set; }
        public int autor_id                         { get; set; }
        public int autor_sec_id                     { get; set; }
        public  int autor_ps1_id                    { get; set; }
        public int autor_ps2_id                     { get; set; }
        public int tipo_acervo_id                   { get; set; }
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

        public override void Validate()
        {
            LimparMensagemValidacao();

            if (string.IsNullOrEmpty(ds_Nome_Obra))
                AdicionarMensagemValidacao("Nome da Obra é campo obrigatório.");
        }
    }
}

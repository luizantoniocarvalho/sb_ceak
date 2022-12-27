using System;

namespace sb_ceak.Dominio.Entidade
{
    public class Pessoas
    {
        public int pessoa_id                        { get; set; }
        public int perfil_id                        { get; set; }
        public int telefone_id                      { get; set; }
        public string ds_Nome_Pessoa                { get; set; }
        public string ds_Endereco_Pessoa            { get; set; }
        public string ds_CEP_Pessoa                 { get; set; }
        public int uf_id                            { get; set; }
        public string ds_Email_Pessoa               { get; set; }
        public string ds_Senha_Pessoa               { get; set; }
        public DateTime dt_Data_Cadastro_Pessoa     { get; set; }
        public bool in_Situacao_Registro            { get; set; }
        public int criou_Registro_id                { get; set; }
        public DateTime dt_Data_Criacao             { get; set; }
        public int alterou_Registro_id              { get; set; }
        public DateTime dt_Data_Alteracao           { get; set; }
    }
}

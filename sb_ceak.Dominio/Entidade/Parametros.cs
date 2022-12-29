using System;

namespace sb_ceak.Dominio.Entidade
{
    public class Parametros : Entidades
    {
        public int parametro_id                     { get; set; }
        public int telefone_id                      { get; set; }
        public string ds_Nome_Parametro             { get; set; }
        public string ds_CNPJ_Parametro             { get; set; }
        public string ds_Endereco_Parametro         { get; set; }
        public string ds_CEP_Parametro              { get; set; }
        public int uf_id                            { get; set; }
        public string ds_Site_Parametro             { get; set; }
        public string ds_Email_Parametro            { get; set; }
        public string ds_Presidente_Parametro       { get; set; }
        public string ds_Tesoureiro_Parametro       { get; set; }
        public bool in_Situacao_Registro            { get; set; }
        public int criou_Registro_id                { get; set; }
        public DateTime dt_Data_Criacao             { get; set; }
        public int alterou_Registro_id              { get; set; }
        public DateTime dt_Data_Alteracao           { get; set; }

        public override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}

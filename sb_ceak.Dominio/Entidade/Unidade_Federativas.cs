using System;

namespace sb_ceak.Dominio.Entidade
{
    public class Unidade_Federativas
    {
        public int uf_id { get; set; }
        public string ds_Nome_UF { get; set; }
        public string ds_Sigla_UF { get; set; }
        public bool in_Situacao_Registro { get; set; }
        public int criou_Registro_id { get; set; }
        public DateTime dt_Data_Criacao { get; set; }
        public int alterou_Registro_id { get; set; }
        public DateTime dt_Data_Alteracao { get; set; }
    }
}

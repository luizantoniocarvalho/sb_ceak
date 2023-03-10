using System;

namespace sb_ceak.Dominio.Entidade
{
    public class Telefones : Entidades
    {
        public int telefone_id                  { get; set; }
        public int tipo_telefone_id             { get; set; }
        public string ds_DDD_Telefone           { get; set; }
        public string ds_Numero_Telefone        { get; set; }
        public bool in_Situacao_Registro        { get; set; }
        public int criou_Registro_id            { get; set; }
        public DateTime dt_Data_Criacao         { get; set; }
        public int alterou_Registro_id          { get; set; }
        public DateTime dt_Data_Alteracao       { get; set; }

        public override void Validate()
        {
            LimparMensagemValidacao();

            if (string.IsNullOrEmpty(ds_Numero_Telefone))
                AdicionarMensagemValidacao("Número de Telefone é campo obrigatório.");
        }
    }
}

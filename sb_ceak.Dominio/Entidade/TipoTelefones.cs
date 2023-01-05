using System;

namespace sb_ceak.Dominio.Entidade
{
    public class TipoTelefones : Entidades
    {
        public int tipo_telefone_id             { get; set; }
        public string ds_Tipo_Telefone          { get; set; }
        public bool in_Situacao_Registro        { get; set; }
        public int criou_Registro_id            { get; set; }
        public DateTime dt_Data_Criacao         { get; set; }
        public int alterou_Registro_id          { get; set; }
        public DateTime dt_Data_Alteracao       { get; set; }

        public override void Validate()
        {
            LimparMensagemValidacao();

            if (string.IsNullOrEmpty(ds_Tipo_Telefone))
                AdicionarMensagemValidacao("O Tipo de Telefone é campo obrigatório.");
        }
    }
}

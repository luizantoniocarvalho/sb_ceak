using System;

namespace sb_ceak.Dominio.Entidade
{
    public class TipoAutores : Entidades
    {
        public int tipo_autor_id                    { get; set; }
        public string ds_Nome_Tipo_Autor            { get; set; }
        public bool in_Situacao_Registro            { get; set; }
        public int criou_Registro_id                { get; set; }
        public DateTime dt_Data_Criacao             { get; set; }
        public int alterou_Registro_id              { get; set; }
        public DateTime dt_Data_Alteracao           { get; set; }

        public override void Validate()
        {
            LimparMensagemValidacao();

            if (string.IsNullOrEmpty(ds_Nome_Tipo_Autor))
                AdicionarMensagemValidacao("Nome do Tipo de Autor é campo obrigatório.");
        }

    }
}

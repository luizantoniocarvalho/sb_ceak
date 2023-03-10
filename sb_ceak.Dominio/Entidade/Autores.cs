using System;

namespace sb_ceak.Dominio.Entidade
{
    public class Autores : Entidades
    {
        public int autor_id                         { get; set; }
        public int tipo_autor_id                    { get; set; }
        public string ds_Nome_Autor                 { get; set; }
        public bool in_Situacao_Registro            { get; set; }
        public int criou_Registro_id                { get; set; }
        public DateTime dt_Data_Criacao             { get; set; }
        public int alterou_Registro_id              { get; set; }
        public DateTime dt_Data_Alteracao           { get; set; }

        public override void Validate()
        {
            LimparMensagemValidacao();

            if (string.IsNullOrEmpty(ds_Nome_Autor))
                AdicionarMensagemValidacao("Nome do Autor é campo obrigatório.");
        }
    }
}

using System;
using System.Collections.Generic;

namespace sb_ceak.Dominio.Entidade
{
    public class Perfis : Entidades
    {
        public int perfil_id                    { get; set; }
        public string ds_Nome_Perfil            { get; set; }
        public bool in_Situacao_Registro        { get; set; }
        public int criou_Registro_id            { get; set; }
        public DateTime dt_Data_Criacao         { get; set; }
        public int alterou_Registro_id          { get; set; }
        public DateTime dt_Data_Alteracao       { get; set; }
        
        /// <summary>
        /// Um perfil pode ter uma ou muitas funções.
        /// </summary>
        public ICollection<Funcoes> Funcao      { get; set; }

        public override void Validate()
        {
            LimparMensagemValidacao();

            if (string.IsNullOrEmpty(ds_Nome_Perfil))
                AdicionarMensagemValidacao("Nome do Perfil é campo obrigatório.");
        }
    }
}

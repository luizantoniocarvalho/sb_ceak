using sb_ceak.Dominio.Associação;
using System;
using System.Collections.Generic;

namespace sb_ceak.Dominio.Entidade
{
    public class Funcoes : Entidades
    {
        public int funcao_id                    { get; set; }
        public string ds_Nome_Funcao            { get; set; }
        public bool in_Situacao_Registro        { get; set; }
        public int criou_Registro_id            { get; set; }
        public DateTime dt_Data_Criacao         { get; set; }
        public int alterou_Registro_id          { get; set; }
        public DateTime dt_Data_Alteracao       { get; set; }
        
        /// <summary>
        /// Uma função pode ter um ou muitas operações.
        /// </summary>
        public virtual ICollection<Associa_Perf_Func_Oper> Associa_Perf_Func_Opers  { get; set; }

        public override void Validate()
        {
            LimparMensagemValidacao();

            if (string.IsNullOrEmpty(ds_Nome_Funcao))
                AdicionarMensagemValidacao("Nome da Função é campo obrigatório.");
        }
    }
}

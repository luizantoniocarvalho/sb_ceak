﻿using System;

namespace sb_ceak.Dominio.Entidade
{
    public class Operacoes
    {
        public int operacao_id                  { get; set; }
        public string ds_Nome_Operacao          { get; set; }
        public bool in_Situacao_Registro        { get; set; }
        public int criou_Registro_id            { get; set; }
        public DateTime dt_Data_Cadastro        { get; set; }
        public int alterou_Registro_id          { get; set; }
        public DateTime dt_Data_Alteracao       { get; set; }
    }
}
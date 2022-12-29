﻿using sb_ceak.Dominio.Enumerações;
using System;

namespace sb_ceak.Dominio.Entidade
{
    public class EmprestimoDevolucoes : Entidades
    {
        public int emp_dev_id                   { get; set; }
        public int tipo_obra_id                 { get; set; }
        public int pessoa_id                    { get; set; }
        public int obra_id                      { get; set; }
        public DateTime dt_Data_Emprestimo      { get; set; }
        public DateTime dt_Prevista_Devolucao   { get; set; }
        public DateTime dt_Data_Devolucao       { get; set; }

        public bool TipoLivro
        {
            get { return tipo_obra_id == (int)TipoObras.Livros; }
        }

        public bool TipoDVD
        {
            get { return tipo_obra_id == (int)TipoObras.DVD; }
        }

        public override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}

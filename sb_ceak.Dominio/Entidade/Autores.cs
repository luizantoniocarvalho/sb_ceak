using sb_ceak.Dominio.Enumerações;
using System;

namespace sb_ceak.Dominio.Entidade
{
    public class Autores
    {
        public int autor_id                         { get; set; }
        public int tipo_autor_id                    { get; set; }
        public string ds_Nome_Autor                 { get; set; }
        public bool in_Situacao_Registro            { get; set; }
        public int criou_Registro_id                { get; set; }
        public DateTime dt_Data_Criacao             { get; set; }
        public int alterou_Registro_id              { get; set; }
        public DateTime dt_Data_Alteracao           { get; set; }
        
        public bool TipoEhEspiritual
        {
            get { return tipo_autor_id == (int)TipoAutores.Espiritual; }
        }
        public bool TipoEhIntuido
        {
            get { return tipo_autor_id == (int)TipoAutores.Intuído; }
        }
        public bool TipoEhPsicografico
        {
            get { return tipo_autor_id == (int)TipoAutores.Psicográfico; }
        }

    }
}

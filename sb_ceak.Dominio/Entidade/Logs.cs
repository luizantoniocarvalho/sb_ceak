using System;

namespace sb_ceak.Dominio.Entidade
{
    public class Logs : Entidades
    {
        public int log_id                   { get; set; }
        public int pessoa_id                { get; set; }
        public DateTime dt_Data_Log         { get; set; }
        public string ds_Log_Realizado      { get; set; }

        public override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}

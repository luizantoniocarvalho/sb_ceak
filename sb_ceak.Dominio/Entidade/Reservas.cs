using System;

namespace sb_ceak.Dominio.Entidade
{
    public class Reservas
    {
        public int reserva_id               { get; set; }
        public int pessoa_id                { get; set; }
        public int obra_id                  { get; set; }
        public DateTime dt_Data_Reserva     { get; set; }
    }
}

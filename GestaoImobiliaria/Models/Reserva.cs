using System;

namespace Models
{
    public class Reserva
    {
        public int IdReserva { get; set; }
        public string StatusDaReserva { get; set; }
        public DateTime Prazo { get; set; }
        public DateTime DataReserva { get; set; }
        public Corretor Corretor { get; set; }
        public Terreno Terreno { get; set; }
    }
}

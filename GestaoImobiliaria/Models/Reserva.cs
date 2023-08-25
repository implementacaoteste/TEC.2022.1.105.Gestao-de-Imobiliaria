using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Reserva
    {
        public int IdReserva { get; set; }
        public string StatusDaReserva { get; set; }
        public DateTime Prazo { get; set; }
        public DateTime DataReserva { get; set; }
        public int PrazoDeRenovacao { get; set; }  
        public List<Corretor> ListCorretor { get; set; }
        public List<Terreno> ListTerreno { get; set; }
    }
}

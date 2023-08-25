using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Vendas
    {
        public int IDVenda { get; set; }
        public int IDTerreno { get; set; }
        public int IDCliente { get; set; }
        public int IDCorretor { get; set; }
        public DateTime DataVenda { get; set; }
        public Corretor Corretor { get; set; }
        public Terreno Terreno { get; set; }
        public Cliente Cliente { get; set; }
    }
}

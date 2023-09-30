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



        public int IDEmpreendimento { get; set; }

        public string Endereco
        {
            get
            {
                return Terreno != null ? Terreno.Endereco : "";
            }
        }
        public string NomeCliente
        {
            get
            {
                return Cliente != null ? Cliente.Nome : "";
            }
        }
        public string NomeCorretor
        {
            get
            {
                return Corretor != null ? Corretor.Nome : "";
            }
        }
        public string NomeEmpreendimento
        {
            get
            {
                return Terreno.Empreendimento.Nome;
            }
        }
        public Cliente Cliente { get; set; }



        public Corretor Corretor { get; set; }



        public Terreno Terreno { get; set; }
    }
}

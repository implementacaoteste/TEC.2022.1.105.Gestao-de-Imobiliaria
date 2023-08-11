using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Terreno
    {
        public int IdTerreno { get; set; }
        public int IdEmpreendimnto { get; set; }
        public float PrecoAVista { get; set; }
        public float PrecoParcelado { get; set; }
        public bool RedeAguaEnergia { get; set; }
        public float MetragemFrente { get; set; }
        public float MetragemFundo { get; set; }
        public float MetragemLaterais { get; set; }
        public float TamanhoTotal { get; set; }
        public float ConfrontacoesTerreno { get; set; }
        public string Endereco { get; set; }
        public string Matricula { get; set; }
    }
}

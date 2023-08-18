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
        public int IdEmpreendimento { get; set; }
        public double PrecoAVista { get; set; }
        public double PrecoParcelado { get; set; }
        public double MetragemFrente { get; set; }
        public double MetragemFundo { get; set; }
        public double TamanhoTotalTerreno { get; set; }
        public string ConfrontacoesTerreno { get; set; }
        public string Endereco { get; set; }
        public string Matricula { get; set; }
        public double MetragemEsquerda { get; set; }
        public double MetragemDireita { get; set; }
        public bool RedeAgua { get; set; }
        public bool RedeEnergia { get; set; }
    }
}

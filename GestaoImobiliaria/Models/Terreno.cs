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
        public float PrecoAVista { get; set; }
        public float PrecoParcelado { get; set; }
        public float MetragemFrente { get; set; }
        public float MetragemFundo { get; set; }
        public float TamanhoTotalTerreno { get; set; }
        public string ConfrontacoesTerreno { get; set; }
        public string Endereco { get; set; }
        public string Matricula { get; set; }
        public float MetragemEsquerda { get; set; }
        public float MetragemDireita { get; set; }
        public bool RedeAgua { get; set; }
        public bool RedeEnergia { get; set; }
    }
}

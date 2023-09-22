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
        public double PrecoAVista { get; set; }
        public double PrecoParcelado { get; set; }
        public double MetragemFrente { get; set; }
        public double MetragemFundo { get; set; }
        public double TamanhoTotalTerreno { get; set; }
        public string Esquina { get; set; }
        public string Endereco { get; set; }
        public string Matricula { get; set; }
        public string MetragemEsquerda { get; set; }
        public string MetragemDireita { get; set; }
        public bool RedeAgua { get; set; }
        public bool RedeEnergia { get; set; }
        public string NomeEmpreendimento { get { return this.Empreendimento.Nome; } }
        public Empreendimentos Empreendimento { get; set; }
        public int IdStatus_Terreno { get; set; }
    }
}

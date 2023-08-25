﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }
        public string  Renda { get; set; }
        public string EstadoCivil { get; set; }
        public string RGConjuge { get; set; }
        public string CPFConjuge { get; set; }
        public string Fone { get; set; }
        //public List<Vendas> ListVendas { get; set; }
    }
}
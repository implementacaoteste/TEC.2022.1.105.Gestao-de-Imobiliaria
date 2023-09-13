﻿using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class VendasBLL
    {
        public void Inserir(Vendas _vendas)
        {
            new VendasDAL().Inserir(_vendas);
        }





        public void Alterar(Vendas _vendas)
        {
            new VendasDAL().Alterar(_vendas);
        }





        public void Excluir(int _id)
        {
            new VendasDAL().Excluir(_id);
        }





        public List<Vendas> BuscarTodos()
        {
            return new VendasDAL().BuscarTodos();
        }





        public Vendas BuscarPorCorretor(int _idcorretor)
        {
            return new VendasDAL().BuscarPorCorretor(_idcorretor);
        }





        public Vendas BuscarPorCliente(int _idcliente)
        {
            return new VendasDAL().BuscarPorCliente(_idcliente);
        }





        public List<Vendas> BuscarPorData()
        {
            return new VendasDAL().BuscarPorData();
        }





        public Vendas BuscarPorId(int _id)
        {
            return new VendasDAL().BuscarPorId(_id);
        }





        public Vendas BuscarPorEmpreendimento(int _idempreendimento)
        {
            return new VendasDAL().BuscarPorEmpreendimento(_idempreendimento);
        }
    }
}

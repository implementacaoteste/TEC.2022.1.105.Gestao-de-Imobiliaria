using DAL;
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


        public List<Vendas> BuscarPorData()
        {
            return new VendasDAL().BuscarPorData();
        }


        public Vendas BuscarPorIdVendas(int _id)
        {
            return new VendasDAL().BuscarPorIdVendas(_id);
        }


        public List<Vendas> BuscarPorNomeCliente(string _nomeCliente)
        {
            return new VendasDAL().BuscarPorNomeCliente(_nomeCliente);
        }

        public object BuscarPorNomeCorretor(string _nomeCorretor)
        {
            return new VendasDAL().BuscarPorNomeCorretor(_nomeCorretor);
        }

        public object BuscarPorNomeEmpreendimento(string _nomeEmpreendimento)
        {
            return new VendasDAL().BuscarPorNomeEmpreendimento(_nomeEmpreendimento);
        }

        public object BuscarPorEnderecoTerreno(string _enderecoTerreno)
        {
            return new VendasDAL().BuscarPorEnderecoTerreno(_enderecoTerreno);
        }
    }
}

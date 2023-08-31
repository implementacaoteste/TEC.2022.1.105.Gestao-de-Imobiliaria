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
    }
}

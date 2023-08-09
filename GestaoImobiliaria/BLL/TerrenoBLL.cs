using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class TerrenoBLL
    {
        public void inserir(Terreno _terreno)
        {
            new TerrenoDAL().Inserir(_terreno);
        }
        public List<Terreno> BuscarTodos()
        {
            return new TerrenoDAL().BuscarTodos();
        }
        public Terreno BuscarPorId(int _id)
        {
            return new TerrenoDAL().BuscarPorId(_id);
        }
        public void Alterar(Terreno _corretor)
        {
            new TerrenoDAL().Alterar(_corretor);
        }
        public void Excluir(int _id)
        {
            new TerrenoDAL().Excluir(_id);
        }
    }
}
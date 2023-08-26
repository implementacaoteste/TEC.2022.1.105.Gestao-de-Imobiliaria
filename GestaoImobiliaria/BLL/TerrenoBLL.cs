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
        public Terreno BuscarPorMatricula(string _matricula)
        {
            return new TerrenoDAL().BuscarPorMatricula(_matricula);
        }
        public void AdicionarTerreno(int _idTerreno, int _idAdTerreno)
        {
            
        }
        public void Alterar(Terreno _terreno)
        {
            new TerrenoDAL().Alterar(_terreno);
        }
        public void Excluir(int _id)
        {
            new TerrenoDAL().Excluir(_id);
        }             
    }
}
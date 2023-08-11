using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class EmpreendimentoBLL
    {
        public void Inserir(Empreendimentos _empreendimentos)
        {
            new EmpreendimentoDAL().Inserir(_empreendimentos);
        }



        public Empreendimentos BuscarPorId(int _id)
        {
            return new EmpreendimentoDAL().BuscarPorId(_id);
        }



        public Empreendimentos BuscaPorCNPJ(string _CNPJEmpresaResponsavel)
        {
            return new EmpreendimentoDAL().BuscarPorCNPJ(_CNPJEmpresaResponsavel);
        }



        public void Excluir(int _id)
        {
            new EmpreendimentoDAL().Excluir(_id);
        }


        public void Alterar(Empreendimentos _empreendimentos)
        {
            new EmpreendimentoDAL().Alterar(_empreendimentos);
        }
    }
}

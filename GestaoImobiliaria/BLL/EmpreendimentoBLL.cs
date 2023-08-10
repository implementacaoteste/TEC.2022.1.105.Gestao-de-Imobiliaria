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

        public Empreendimentos BuscarPorID (int _id)
        {
           return new EmpreendimentoDAL().BuscarPorID(_id); //nao consegui resolver o erro, farei o commit com erro
                                                           //pois só eu estou trabalhando com Empreendimentos
                                                           //Na DAL, BLL e MODELS
        }
    }
}

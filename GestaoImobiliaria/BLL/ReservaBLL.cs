using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace BLL
{
    public class ReservaBLL
    {
        public void Inserir (Reserva _reserva)
        {
            new ReservaDAL().Inserir(_reserva);
        }
        public List<Reserva> BuscarTodos()
        {
            return new ReservaDAL().BuscarTodos();
        }
        public Reserva BuscarPorId(int _id)
        {
            return new ReservaDAL().BuscarPorId(_id);
        }
        public void Alterar (Reserva _reserva)
        {
            new ReservaDAL().Alterar(_reserva);
        }
        public void Excluir (int _id)
        {
            new ReservaDAL().Excluir(_id);
        }
    }
}

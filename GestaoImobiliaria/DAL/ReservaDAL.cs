using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ReservaDAL
    {
        public void Inserir(Reserva _reserva)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"INSERT INTO Reserva(StatusReserva, Prazo, DataReserva) 
                                    VALUES (@StatusReserva, @Prazo, @DataReserva)";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@StatusReserva", _reserva.StatusDaReserva);
                cmd.Parameters.AddWithValue("@Prazo", _reserva.Prazo);
                cmd.Parameters.AddWithValue("@DataReserva", _reserva.DataReserva);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar inserir uma Reserva no banco de dados.", ex) { Data = { { "Id", 28 } } };
            }
            finally
            {
                cn.Close();
            }
        }
        public List<Reserva> BuscarTodos()
        {
            List<Reserva> reservalist = new List<Reserva>();
            Reserva reserva = new Reserva();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT IdReserva,StatusDaReserva, Prazo, DataReserva, PrazoDeRenovacao FROM Reserva";
                cmd.CommandType = System.Data.CommandType.Text;

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        reserva = new Reserva();
                        reserva.IdReserva = (int)rd["IdReserva"];


                        reservalist.Add(reserva);
                    }
                }
                return reservalist;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar Reserva no banco de dados", ex) { Data = { { "Id", 29 } } };
            }
            finally
            {
                cn.Close();
            }
        } 
        public Reserva BuscarPorId(int _id)
        {
            Reserva reserva  = new Reserva();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT IdReserva,StatusDaReserva, Prazo, DataReserva, PrazoDeRenovacaoFROM Reserva WHERE IdReserva = @Id";

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", _id);

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        reserva.IdReserva = (int)rd["IdReserva"];
                        reserva.StatusDaReserva = (string)rd["StatusDaReserva"];
                        reserva.Prazo = (DateTime)rd["Prazo"];
                        reserva.DataReserva = (DateTime)rd["DataReserva"];
                    }
                }
            return reserva;
            }
                catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar Reserva por id no banco de dados", ex) { Data = { { "Id", 30 } } };
            }
            finally
            {
                cn.Close();
            }             
        }
        public void Alterar(Reserva _reserva)
        {

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"UPDATE Reserva SET 
                                        StatusDaReserva = @StatusDaReserva,
                                        Prazo = @Prazo,
                                        DataReserva = @DataReserva,
                                    WHERE IdReserva = @IdReserva";

                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _reserva.IdReserva);


                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar alterar Reserva no banco de dados", ex) { Data = { { "Id", 31 } } };
            }
            finally
            {
                cn.Close();
            }
        }
        public void Excluir(int _id)
        {

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"DELETE FROM Reserva WHERE IdReserva = @IdReserva";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@IdReserva", _id);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar excluir Reserva no banco de dados.", ex) { Data = { { "Id", 32 } } };
            }
            finally
            {
                cn.Close();
            }
        }
    }
}

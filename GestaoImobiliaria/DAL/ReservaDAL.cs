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
                cmd.CommandText = @"INSERT INTO Reservas(IDTerreno, IDCorretor, StatusReserva, Prazo, DataReserva) 
                                    VALUES (@IDTerreno, @IDCorretor, @StatusReserva, @Prazo, CONVERT(DATETIME, CONVERT(VARCHAR, GETDATE(),107)))";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@IDTerreno", _reserva.Terreno.IdTerreno);
                cmd.Parameters.AddWithValue("@IDCorretor", _reserva.Corretor.IdCorretor);
                cmd.Parameters.AddWithValue("@StatusReserva", _reserva.StatusDaReserva);
                cmd.Parameters.AddWithValue("@Prazo", _reserva.Prazo);
                cmd.Connection = cn;
                cn.Open();
                
                _reserva.Terreno.IdStatus_Terreno = 3;
                new TerrenoDAL().Alterar(_reserva.Terreno);
                
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
                cmd.CommandText = @"SELECT IdReserva, IDCorretor, IDTerreno,StatusReserva, Prazo, DataReserva FROM Reservas";
                cmd.CommandType = System.Data.CommandType.Text;

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        reserva = new Reserva();
                        reserva.IdReserva = (int)rd["IdReserva"];
                        reserva.Corretor = new CorretorDAL().BuscarPorId((int)rd["IDCorretor"]);
                        reserva.Terreno = new TerrenoDAL().BuscarPorId((int)rd["IDTerreno"]);
                        reserva.StatusDaReserva = rd["StatusReserva"].ToString();
                        reserva.Prazo = Convert.ToDateTime(rd["Prazo"]);
                        reserva.DataReserva = Convert.ToDateTime(rd["DataReserva"]);


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
            Reserva reserva = new Reserva();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT IdReserva,StatusReserva, Prazo, DataReserva, IDTerreno, IDCorretor FROM Reservas WHERE IdReserva = @Id";

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", _id);

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        reserva.IdReserva = (int)rd["IdReserva"];
                        reserva.StatusDaReserva = (string)rd["StatusReserva"];
                        reserva.Prazo = (DateTime)rd["Prazo"];
                        reserva.DataReserva = (DateTime)rd["DataReserva"];
                        reserva.Corretor = new CorretorDAL().BuscarPorId(Convert.ToInt32(rd["IDCorretor"]));
                        reserva.Terreno= new TerrenoDAL().BuscarPorId(Convert.ToInt32(rd["IDTerreno"]));
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
                cmd.CommandText = @"UPDATE Reservas SET 
                                        StatusReserva = @StatusReserva,
                                        Prazo = @Prazo,
                                        DataReserva = @DataReserva,
                                        IDCorretor = @IDCorretor,
                                        IDTerreno = @IDTerreno
                                        
                                    WHERE IdReserva = @IdReserva";

                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@IdReserva", _reserva.IdReserva);
                cmd.Parameters.AddWithValue("@StatusReserva", _reserva.StatusDaReserva);
                cmd.Parameters.AddWithValue("@Prazo", _reserva.Prazo);
                cmd.Parameters.AddWithValue("@DataReserva", _reserva.DataReserva);
                cmd.Parameters.AddWithValue("@IDTerreno", _reserva.Terreno.IdTerreno);
                cmd.Parameters.AddWithValue("@IDCorretor", _reserva.Corretor.IdCorretor);

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
                cmd.CommandText = @"DELETE FROM Reservas WHERE IdReserva = @IdReserva";
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

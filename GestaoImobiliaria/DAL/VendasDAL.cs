using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class VendasDAL
    {
        public void Alterar(Vendas _vendas)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"UPDATE Vendas SET
                                    IDTerreno = @IDTerreno,
                                    IDCliente = @IDCliente,
                                    IDCorretor = @IDCorretor
                                    WHERE IDVenda = @IDVenda";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@IDVenda", _vendas.IDVenda);
                cmd.Parameters.AddWithValue("@IDTerreno", _vendas.Terreno.IdTerreno);
                cmd.Parameters.AddWithValue("@IDCliente", _vendas.Cliente.Id);
                cmd.Parameters.AddWithValue("@IDCorretor", _vendas.Corretor.IdCorretor);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar alterar venda no banco de dados", ex) { Data = { { "Id", 2431 } } };
            }
        }



        public List<Vendas> BuscarTodos()
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            Vendas vendas = new Vendas();

            try
            {
                SqlCommand cmd = new SqlCommand();


                List<Vendas> vendasList = new List<Vendas>();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Vendas.IDVenda, Vendas.IDTerreno, Vendas.IDCliente, Vendas.IDCorretor, Terrenos.Endereco FROM Vendas
                                    INNER JOIN Terrenos ON Vendas.IDTerreno = Terrenos.IDTerreno";

                cmd.CommandType = System.Data.CommandType.Text;

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        vendas = new Vendas();
                        vendas.IDVenda = (int)rd["IDVenda"];
                        vendas.IDTerreno = (int)rd["IDTerreno"];
                        vendas.IDCliente = (int)rd["IDCliente"];
                        vendas.IDCorretor = (int)rd["IDCorretor"]; ;
                        vendas.Cliente = new ClienteDAL().BuscarPorId((int)rd["IDCliente"]);
                        vendas.Terreno = new TerrenoDAL().BuscarPorId((int)rd["IDTerreno"]);
                        vendas.Corretor = new CorretorDAL().BuscarPorId((int)rd["IDCorretor"]);
                        vendasList.Add(vendas);
                    }
                }
                return vendasList;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao buscar todas as vendas no banco de dados", ex) { Data = { { "Id", 2433 } } };
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
                cmd.CommandText = @"DELETE FROM Vendas WHERE IDVenda = @IDEmpreendimento";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _id);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar excluir uma VENDA no banco de dados", ex) { Data = { { "Id", 2432 } } };
            }
            finally
            {
                cn.Close();
            }
        }




        public void Inserir(Vendas _vendas)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"INSERT INTO Vendas(IDTerreno, IDCliente, IDCorretor) VALUES(@IDTerreno, @IDCliente, @IDCorretor)";
                cmd.CommandType = System.Data.CommandType.Text;

                
                cmd.Parameters.AddWithValue("@IDTerreno", _vendas.Terreno.IdTerreno);
                cmd.Parameters.AddWithValue("@IDCliente", _vendas.Cliente.Id);
                cmd.Parameters.AddWithValue("@IDCorretor", _vendas.Corretor.IdCorretor);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar inserir uma venda no banco de dados.", ex) { Data = { { "Id", 2430 } } };
            }
            finally
            {
                cn.Close();
            }
        }


        public List<Vendas> BuscarPorData()
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            Vendas vendas = new Vendas();

            try
            {
                SqlCommand cmd = new SqlCommand();


                List<Vendas> vendasList = new List<Vendas>();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT IDVenda, IDTerreno, IDCliente, IDCorretor FROM Vendas WHERE DataVenda = @DataVenda";
                cmd.CommandType = System.Data.CommandType.Text;

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        vendas = new Vendas();
                        vendas.IDVenda = (int)rd["IDVenda"];
                        vendas.IDTerreno = (int)rd["IDTerreno"];
                        vendas.IDCliente = (int)rd["IDCliente"];
                        vendas.IDCorretor = (int)rd["IDCorretor"]; ;
                        vendas.Cliente = new ClienteDAL().BuscarPorId((int)rd["IDCliente"]);
                        vendas.Terreno = new TerrenoDAL().BuscarPorId((int)rd["IDTerreno"]);
                        vendas.Corretor = new CorretorDAL().BuscarPorId((int)rd["IDCorretor"]);

                        vendasList.Add(vendas);
                    }
                }
                return vendasList;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao buscar as vendas por data no banco de dados", ex) { Data = { { "Id", 2435 } } };
            }
            finally
            {
                cn.Close();
            }
        }




        public Vendas BuscarPorIdVendas(int _idvenda)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            Vendas vendas = new Vendas();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT IDVenda, IDTerreno, IDCliente, IDCorretor FROM Vendas WHERE IDVenda = @IDVenda";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@IDVenda", _idvenda);

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        vendas = new Vendas();
                        vendas.IDVenda = (int)rd["IDVenda"];
                        vendas.IDTerreno = (int)rd["IDTerreno"];
                        vendas.IDCliente = (int)rd["IDCliente"];
                        vendas.IDCorretor = (int)rd["IDCorretor"];
                        vendas.Cliente = new ClienteDAL().BuscarPorId((int)rd["IDCliente"]);
                        vendas.Terreno = new TerrenoDAL().BuscarPorId((int)rd["IDTerreno"]);
                        vendas.Corretor = new CorretorDAL().BuscarPorId((int)rd["IDCorretor"]);
                    }
                }
                return vendas;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar venda por id no banco de dados", ex) { Data = { { "Id", 2437 } } };
            }
            finally
            {
                cn.Close();
            }
        }


        

        public List<Vendas> BuscarPorNomeCliente(string _nomeCliente)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            Vendas vendas = new Vendas();

            try
            {
                SqlCommand cmd = new SqlCommand();


                List<Vendas> vendasList = new List<Vendas>();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Vendas.IDVenda, Vendas.IDTerreno, Vendas.IDCliente, Vendas.IDCorretor FROM Vendas
                                    INNER JOIN Cliente ON Vendas.IDCliente = Cliente.Id
                                    WHERE Cliente.Nome LIKE @Nome";

                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Nome", $"%{_nomeCliente}%");
                
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        vendas = new Vendas();
                        vendas.IDVenda = (int)rd["IDVenda"];
                        vendas.IDTerreno = (int)rd["IDTerreno"];
                        vendas.IDCliente = (int)rd["IDCliente"];
                        vendas.IDCorretor = (int)rd["IDCorretor"]; ;
                        vendas.Cliente = new ClienteDAL().BuscarPorId((int)rd["IDCliente"]);
                        vendas.Terreno = new TerrenoDAL().BuscarPorId((int)rd["IDTerreno"]);
                        vendas.Corretor = new CorretorDAL().BuscarPorId((int)rd["IDCorretor"]);
                        vendasList.Add(vendas);
                    }
                }
                return vendasList;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao buscar as vendas por nome do cliente no banco de dados", ex) { Data = { { "Id", 2433 } } };
            }
            finally
            {
                cn.Close();
            }
        }

        public List <Vendas> BuscarPorNomeCorretor(string _nomeCorretor)
        {

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            Vendas vendas = new Vendas();

            try
            {
                SqlCommand cmd = new SqlCommand();


                List<Vendas> vendasList = new List<Vendas>();
                cmd.Connection = cn;
                cmd.CommandText = @"Select Vendas.IDVenda, Vendas.IDTerreno, Vendas.IDCliente, Vendas.IDCorretor FROM Vendas
                                    INNER JOIN Corretores ON Vendas.IDCorretor = Corretores.IDCorretor
                                    WHERE Corretores.Nome LIKE @Nome";

                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Nome", $"%{_nomeCorretor}%");

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        vendas = new Vendas();
                        vendas.IDVenda = (int)rd["IDVenda"];
                        vendas.IDTerreno = (int)rd["IDTerreno"];
                        vendas.IDCliente = (int)rd["IDCliente"];
                        vendas.IDCorretor = (int)rd["IDCorretor"]; ;
                        vendas.Cliente = new ClienteDAL().BuscarPorId((int)rd["IDCliente"]);
                        vendas.Terreno = new TerrenoDAL().BuscarPorId((int)rd["IDTerreno"]);
                        vendas.Corretor = new CorretorDAL().BuscarPorId((int)rd["IDCorretor"]);
                        vendasList.Add(vendas);
                    }
                }
                return vendasList;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao buscar as vendas por nome do cliente no banco de dados", ex) { Data = { { "Id", 2433 } } };
            }
            finally
            {
                cn.Close();
            }
        }

        public List <Vendas> BuscarPorNomeEmpreendimento(string _nomeEmpreendimento)
        {

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            Vendas vendas = new Vendas();

            try
            {
                SqlCommand cmd = new SqlCommand();


                List<Vendas> vendasList = new List<Vendas>();
                cmd.Connection = cn;
                cmd.CommandText = @"Select Vendas.IDVenda, Vendas.IDTerreno, Vendas.IDCliente, Vendas.IDCorretor from Vendas
									INNER JOIN Terrenos ON Vendas.IDTerreno = Terrenos.IDTerreno
									INNER JOIN Empreendimentos ON Terrenos.IDEmpreendimento = Empreendimentos.IDEmpreendimento
									WHERE Empreendimentos.Nome LIKE @Nome";

                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Nome", $"%{_nomeEmpreendimento}%");

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        vendas = new Vendas();
                        vendas.IDVenda = (int)rd["IDVenda"];
                        vendas.IDTerreno = (int)rd["IDTerreno"];
                        vendas.IDCliente = (int)rd["IDCliente"];
                        vendas.IDCorretor = (int)rd["IDCorretor"]; ;
                        vendas.Cliente = new ClienteDAL().BuscarPorId((int)rd["IDCliente"]);
                        vendas.Terreno = new TerrenoDAL().BuscarPorId((int)rd["IDTerreno"]);
                        vendas.Corretor = new CorretorDAL().BuscarPorId((int)rd["IDCorretor"]);
                        vendasList.Add(vendas);
                    }
                }
                return vendasList;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao buscar as vendas por nome do cliente no banco de dados", ex) { Data = { { "Id", 2433 } } };
            }
            finally
            {
                cn.Close();
            }
        }

        public object BuscarPorEnderecoTerreno(string _enderecoTerreno)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            Vendas vendas = new Vendas();

            try
            {
                SqlCommand cmd = new SqlCommand();


                List<Vendas> vendasList = new List<Vendas>();
                cmd.Connection = cn;
                cmd.CommandText = @"Select Vendas.IDVenda, Vendas.IDTerreno, Vendas.IDCliente, Vendas.IDCorretor FROM Vendas
                                    INNER JOIN Terrenos ON Vendas.IDTerreno = Terrenos.IDTerreno
                                    WHERE Terrenos.Endereco LIKE @Endereco";

                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Endereco", $"%{_enderecoTerreno}%");

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        vendas = new Vendas();
                        vendas.IDVenda = (int)rd["IDVenda"];
                        vendas.IDTerreno = (int)rd["IDTerreno"];
                        vendas.IDCliente = (int)rd["IDCliente"];
                        vendas.IDCorretor = (int)rd["IDCorretor"]; ;
                        vendas.Cliente = new ClienteDAL().BuscarPorId((int)rd["IDCliente"]);
                        vendas.Terreno = new TerrenoDAL().BuscarPorId((int)rd["IDTerreno"]);
                        vendas.Corretor = new CorretorDAL().BuscarPorId((int)rd["IDCorretor"]);
                        vendasList.Add(vendas);
                    }
                }
                return vendasList;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao buscar as vendas por nome do cliente no banco de dados", ex) { Data = { { "Id", 2433 } } };
            }
            finally
            {
                cn.Close();
            }
        }
    }
    }


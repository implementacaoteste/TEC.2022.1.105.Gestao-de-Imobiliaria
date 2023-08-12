using Models;
using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace DAL
{
    public class ClienteDAL
    {
        public void Inserir(Cliente _cliente)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"INSERT INTO Cliente(Nome, CPF, RG, Email, Fone, Endereco, EstadoCivil, Renda, CPFConjuge, RGConjuge) 
                                    VALUES(@Nome, @CPF, @RG, @Email, @Fone, @Endereco, @EstadoCivil, @Renda, @CPFConjuge, @RGConjuge)";

                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Nome", _cliente.Nome);
                cmd.Parameters.AddWithValue("@CPF", _cliente.CPF);
                cmd.Parameters.AddWithValue("@RG", _cliente.RG);
                cmd.Parameters.AddWithValue("@Email", _cliente.Email);
                cmd.Parameters.AddWithValue("@Fone", _cliente.Fone);
                cmd.Parameters.AddWithValue("@Endereco", _cliente.Endereco);
                cmd.Parameters.AddWithValue("@EstadoCivil", _cliente.EstadoCivil);
                cmd.Parameters.AddWithValue("@Renda", _cliente.Renda);
                cmd.Parameters.AddWithValue("@CPFConjuge", _cliente.CPFConjuge);
                cmd.Parameters.AddWithValue("@RGConjuge", _cliente.RGConjuge);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar inserir um cliente no banco de dados.", ex) { Data = { { "Id", 15 } } };
            }
            finally
            {
                cn.Close();
            }
        }
        public List<Cliente> BuscarTodos()
        {
            List<Cliente> clienteList = new List<Cliente>();
            Cliente cliente = new Cliente();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Id, Nome, CPF, RG, Email, Fone, Endereco, EstadoCivil, Renda, CPFConjuge, RGConjuge FROM Cliente";
                cmd.CommandType = System.Data.CommandType.Text;

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        cliente = new Cliente();
                        cliente.Id = (int)rd["Id"];
                        cliente.Nome = rd["Nome"].ToString();
                        cliente.CPF = rd["CPF"].ToString();
                        cliente.RG = rd["RG"].ToString();
                        cliente.Email = rd["email"].ToString();
                        cliente.Fone = rd["Fone"].ToString();
                        cliente.Endereco = rd["Endereco"].ToString();
                        cliente.EstadoCivil = rd["EstadoCivil"].ToString();
                        cliente.Renda = rd["Renda"].ToString();
                        cliente.CPFConjuge = rd["CPFConjuge"].ToString();
                        cliente.RGConjuge = rd["RGConjuge"].ToString();

                        clienteList.Add(cliente);
                    }
                }
                return clienteList;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar por clientes no banco de dados", ex) { Data = { { "Id", 16 } } };
            }
            finally
            {
                cn.Close();
            }
        }
        public List<Cliente> BuscarPorNome(string _nome)
        {
            List<Cliente> clienteList = new List<Cliente>();
            Cliente cliente = new Cliente();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Id, Nome, CPF, RG, Email, Fone, Endereco, EstadoCivil, Renda, CPFConjuge, RGConjuge FROM Cliente WHERE Nome LIKE @Nome";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Nome", "%" + _nome + "%");

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        cliente = new Cliente();
                        cliente.Id = (int)rd["Id"];
                        cliente.Nome = rd["Nome"].ToString();
                        cliente.CPF = rd["CPF"].ToString();
                        cliente.RG = rd["RG"].ToString();
                        cliente.Email = rd["email"].ToString();
                        cliente.Fone = rd["Fone"].ToString();
                        cliente.Endereco = rd["Endereco"].ToString();
                        cliente.EstadoCivil = rd["EstadoCIvil"].ToString();
                        cliente.Renda = rd["Renda"].ToString();
                        cliente.CPFConjuge = rd["CPFConjuge"].ToString();
                        cliente.RGConjuge = rd["RGConjuge"].ToString();

                        clienteList.Add(cliente);
                    }
                }
                return clienteList;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar clientes por nome no banco de dados", ex) { Data = { { "Id", 17 } } };
            }
            finally
            {
                cn.Close();
            }
        }
        public Cliente BuscarPorId(int _id)
        {
            Cliente cliente = new Cliente();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Id, Nome, CPF, RG, Email, Fone, Endereco, EstadoCivil, Renda, CPFConjuge, RGConjuge FROM Cliente WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", _id);

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        cliente.Id = (int)rd["Id"];
                        cliente.Nome = rd["Nome"].ToString();
                        cliente.CPF = rd["CPF"].ToString();
                        cliente.RG = rd["RG"].ToString();
                        cliente.Email = rd["email"].ToString();
                        cliente.Fone = rd["Fone"].ToString();
                        cliente.Endereco = rd["Endereco"].ToString();
                        cliente.EstadoCivil = rd["EstadoCivil"].ToString();
                        cliente.Renda = rd["Renda"].ToString();
                        cliente.CPFConjuge = rd["CPFConjuge"].ToString();
                        cliente.RGConjuge = rd["RGConjuge"].ToString();

                    }
                }
                return cliente;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar clientes por id no banco de dados", ex) { Data = { { "Id", 18 } } };
            }
            finally
            {
                cn.Close();
            }
        }
        public Cliente BuscarPorCPF(string _CPF)
        {
            Cliente cliente = new Cliente();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Id, Nome, CPF, RG, Email, Fone, Endereco, EstadoCivil, Renda, CPFConjuge, RGConjuge FROM Cliente WHERE CPF = @CPF";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@CPF", _CPF);

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        cliente.Id = (int)rd["Id"];
                        cliente.Nome = rd["Nome"].ToString();
                        cliente.CPF = rd["CPF"].ToString();
                        cliente.RG = rd["RG"].ToString();
                        cliente.Email = rd["email"].ToString();
                        cliente.Fone = rd["Fone"].ToString();
                        cliente.Endereco = rd["Endereco"].ToString();
                        cliente.EstadoCivil = rd["EstadoCivil"].ToString();
                        cliente.Renda = rd["Renda"].ToString();
                        cliente.CPFConjuge = rd["CPFConjuge"].ToString();
                        cliente.RGConjuge = rd["RGConjuge"].ToString();

                    }
                }
                return cliente;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar clientes por CPF no banco de dados", ex) { Data = { { "Id", 19 } } };
            }
            finally
            {
                cn.Close();
            }
        }
        public void Alterar(Cliente _cliente)
        {

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"UPDATE Cliente SET 
                                        Nome = @Nome, 
                                        CPF = @CPF, 
                                        RG = @RG, 
                                        Email = @Email, 
                                        Fone = @Fone,
                                        Endereco = @Endereco,
                                        EstadoCivil = @EstadoCivil,
                                        Renda = @Renda,
                                        CPFConjuge = @CPFConjuge,
                                        RGConjuge = @RGConjuge
                                    WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _cliente.Id);
                cmd.Parameters.AddWithValue("@Nome", _cliente.Nome);
                cmd.Parameters.AddWithValue("@CPF", _cliente.CPF);
                cmd.Parameters.AddWithValue("@RG", _cliente.RG);
                cmd.Parameters.AddWithValue("@Email", _cliente.Email);
                cmd.Parameters.AddWithValue("@Fone", _cliente.Fone);
                cmd.Parameters.AddWithValue("@Endereco", _cliente.Endereco);
                cmd.Parameters.AddWithValue("@EstadoCivil", _cliente.EstadoCivil);
                cmd.Parameters.AddWithValue("@Renda", _cliente.Renda);
                cmd.Parameters.AddWithValue("@CPFConjuge", _cliente.CPFConjuge);
                cmd.Parameters.AddWithValue("@RGConjuge", _cliente.RGConjuge);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar alterar um cliente no banco de dados", ex) { Data = { { "Id", 20 } } };
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
                cmd.CommandText = @"DELETE FROM Cliente WHERE id = @id";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _id);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar excluir cliente no banco de dados.", ex) { Data = { { "Id", 21 } } };
            }
            finally
            {
                cn.Close();
            }
        }
    }
}

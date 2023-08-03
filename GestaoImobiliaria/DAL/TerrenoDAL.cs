using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TerrenoDAL
    {
        public void Inserir(Terreno _terreno)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"INSERT INTO Terreno(Nome, CPF, RG, Email, Fone) 
                                    VALUES(@Nome, @CPF, @RG, @Email, @Fone)";

                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Nome", _terreno.Nome);
                cmd.Parameters.AddWithValue("@CPF", _terreno.CPF);
                cmd.Parameters.AddWithValue("@RG", _terreno.RG);
                cmd.Parameters.AddWithValue("@Email", _terreno.Email);
                cmd.Parameters.AddWithValue("@Fone", _terreno.Fone);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                //adicionar um id de error que nao esta sendo utilizado
                //throw new Exception("Ocorreu um erro ao tentar inserir um terreno no banco de dados.", ex) { Data = { { "Id", 15 } } };
            }
            finally
            {
                cn.Close();
            }
        }
        public List<Fornecedor> BuscarTodos()
        {
            List<Fornecedor> FornecedorList = new List<Fornecedor>();
            Fornecedor fornecedor = new Fornecedor();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Id, Nome, CPF, RG, Email, Fone FROM Fornecedor";
                cmd.CommandType = System.Data.CommandType.Text;

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        terreno = new Fornecedor();
                        terreno.Id = (int)rd["Id"];
                        terreno.Nome = rd["Nome"].ToString();
                        terreno.CPF = rd["CPF"].ToString();
                        terreno.RG = rd["RG"].ToString();
                        terreno.Email = rd["email"].ToString();
                        terreno.Fone = rd["Fone"].ToString();

                        terrenoList.Add(terreno);
                    }
                }
                return terrenoList;
            }
            catch (Exception ex)
            {
                //adicionar um id de erro que nao esta sendo utilizado
                //throw new Exception("Ocorreu um erro ao tentar buscar terrenos no banco de dados", ex) { Data = { { "Id", 16 } } };
            }
            finally
            {
                cn.Close();
            }
        }
        public Fornecedor BuscarPorId(int _id)
        {
            Fornecedor fornecedor = new Fornecedor();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Id, Nome, CPF, RG, Email, Fone FROM Fornecedor WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", _id);

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        fornecedor.Id = (int)rd["Id"];
                        fornecedor.Nome = rd["Nome"].ToString();
                        fornecedor.CPF = rd["CPF"].ToString();
                        fornecedor.RG = rd["RG"].ToString();
                        fornecedor.Email = rd["email"].ToString();
                        fornecedor.Fone = rd["Fone"].ToString();
                    }
                }
                return fornecedor;
            }
            catch (Exception ex)
            {
                //adicionar um id de erro que nao esta sendo utilizado
                //throw new Exception("Ocorreu um erro ao tentar buscar fornecedor por id no banco de dados", ex) { Data = { { "Id", 18 } } };
            }
            finally
            {
                cn.Close();
            }
        }
        public void Alterar(Fornecedor _fornecedor)
        {

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"UPDATE Fornecedor SET 
                                        Nome = @Nome, 
                                        CPF = @CPF, 
                                        RG = @RG, 
                                        Email = @Email, 
                                        Fone = @Fone 
                                    WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _fornecedor.Id);
                cmd.Parameters.AddWithValue("@Nome", _fornecedor.Nome);
                cmd.Parameters.AddWithValue("@CPF", _fornecedor.CPF);
                cmd.Parameters.AddWithValue("@RG", _fornecedor.RG);
                cmd.Parameters.AddWithValue("@Email", _fornecedor.Email);
                cmd.Parameters.AddWithValue("@Fone", _fornecedor.Fone);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                //adicionar um id de erro que nao esta sendo utilizado
                //throw new Exception("Erro ao tentar alterar cliente no banco de dados", ex) { Data = { { "Id", 20 } } };
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
                cmd.CommandText = @"DELETE FROM Fornecedor WHERE id = @id";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _id);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                //adicionar um id de erro que nao esta sendo utilizado
                //throw new Exception("Ocorreu um erro ao tentar excluir fornecdor no banco de dados.", ex) { Data = { { "Id", 21 } } };
            }
            finally
            {
                cn.Close();
            }
        }
    }
}

using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CorretorDAL
    {
        public void Inserir(Corretor _corretor)

        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"INSERT INTO Corretor(Nome, Endereco, RG, CPF, CRECI) VALUES(@Nome, @Endereco, @RG, @CPF, @CRECI, @Fone)";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Nome", _corretor.Nome);
                cmd.Parameters.AddWithValue("@Endereco", _corretor.Endereco);
                cmd.Parameters.AddWithValue("@RG", _corretor.RG);
                cmd.Parameters.AddWithValue("@CPF", _corretor.CPF);
                cmd.Parameters.AddWithValue("@CRECI", _corretor.CRECI);
                cmd.Parameters.AddWithValue("@Fone", _corretor.Telefone);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar inserir um corretor no banco de dados.", ex) { Data = { { "Id", 50 } } };
            }
            finally
            {
                cn.Close();
            }
        }




        public List<Corretor> BuscarTodos()

        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            Corretor corretor = new Corretor();

            try
            {

                SqlCommand cmd = new SqlCommand();


                List<Corretor> corretorList = new List<Corretor>();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Id, Nome, RG, CPF, CRECI, Fone FROM Corretor";
                cmd.CommandType = System.Data.CommandType.Text;


                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        corretor = new Corretor();
                        corretor.IdCorretor = (int)rd["Id"];
                        corretor.Nome = rd["Nome"].ToString();
                        corretor.RG = rd["RG"].ToString();
                        corretor.CPF = rd["CPF"].ToString();
                        corretor.CRECI = rd["CRECI"].ToString();
                        corretor.Telefone = rd["Fone"].ToString();


                        corretorList.Add(corretor);
                    }
                }
                return corretorList;


            }
            catch (Exception ex)
            {
                throw new Exception("ocorreu um erro ao tentar buscar corretores no banco de dados", ex) { Data = { { "Id", 51 } } };
            }
            finally
            {
                cn.Close();
            }
        }




        public Corretor BuscarPorId(int _id)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            Corretor corretor = new Corretor();

            try
            {

                SqlCommand cmd = new SqlCommand();


                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Id, Nome, Endereco, RG, CPF, CRECI, FROM Corretor WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", _id);


                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        corretor = new Corretor();
                        corretor.IdCorretor = (int)rd["Id"];
                        corretor.Nome = rd["Nome"].ToString();
                        corretor.RG = rd["RG"].ToString();
                        corretor.CPF = rd["CPF"].ToString();
                        corretor.CRECI = rd["CRECI"].ToString();
                        corretor.Telefone = rd["Fone"].ToString();
                    }
                }
                return corretor;


            }
            catch (Exception ex)
            {
                throw new Exception("ocorreu um erro ao tentar buscar corretor por id no banco de dados", ex) { Data = { { "Id", 52 } } };
            }
            finally
            {
                cn.Close();
            }
        }





        public List<Corretor> BuscarPorNome(string _nome)
        {
            List<Corretor> corretorList = new List<Corretor>();
            Corretor corretor = new Corretor();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Id, Nome, Endereco, RG, CPF, CRECI, FROM Corretor WHERE Nome LIKE @Nome";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Nome", "%" + _nome + "%");

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        corretor = new Corretor();
                        corretor.IdCorretor = (int)rd["Id"];
                        corretor.Nome = rd["Nome"].ToString();
                        corretor.RG = rd["RG"].ToString();
                        corretor.CPF = rd["CPF"].ToString();
                        corretor.CRECI = rd["CRECI"].ToString();
                        corretor.Telefone = rd["Fone"].ToString();

                        corretorList.Add(corretor);
                    }
                }
                return corretorList;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar corretor por nome no banco de dados", ex) { Data = { { "Id", 53 } } };
            }
            finally
            {
                cn.Close();
            }
        }




        public void Alterar(Corretor _corretor)
        {

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"UPDATE Corretor SET 
                                        Nome = @Nome,
                                        Endereco = @Endereco,
                                        RG = @RG, 
                                        CPF = @CPF, 
                                        CRECI = @CRECI,
                                        Fone = @Fone 
                                    WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _corretor.IdCorretor);
                cmd.Parameters.AddWithValue("@Nome", _corretor.Nome);
                cmd.Parameters.AddWithValue("@Endereco", _corretor.Endereco);
                cmd.Parameters.AddWithValue("@RG", _corretor.RG);
                cmd.Parameters.AddWithValue("@CPF", _corretor.CPF);
                cmd.Parameters.AddWithValue("@CRECI", _corretor.CRECI)
                cmd.Parameters.AddWithValue("@Fone", _corretor.Telefone);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar alterar corretor no banco de dados", ex) { Data = { { "Id", 53 } } };
            }
            finally
            {
                cn.Close();
            }
        }
        public Corretor BuscarPorCPF(string _cPF)
        {
            Corretor corretor = new Corretor();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT Id, Nome, NomeCorretor, Email, CPF, Ativo, Senha FROM Corretor WHERE CPF = @CPF";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@CPF", _cPF);
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        corretor.IdCorretor = Convert.ToInt32(rd["Id"]);
                        corretor.CRECI = rd["CRECI"].ToString();
                        corretor.Nome = rd["NomeCorretor"].ToString();
                        corretor.CPF = rd["CPF"].ToString();
                        corretor.RG = rd["RG"].ToString();
                        corretor.Telefone = rd["Telefone"].ToString();
                    }
                }
                return corretor;
            }
            catch (Exception ex)
            {
                //adicionar um id de error que nao esta sendo utilizado
                //throw new Exception("ocorreu um erro ao tentar buscar id do usuário do banco de dados", ex);
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
                cmd.CommandText = @"DELETE FROM Corretor WHERE id = @id";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _id);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar excluir corretor no banco de dados.", ex) { Data = { { "Id", 54 } } };
            }
            finally
            {
                cn.Close();
            }
        }
    }
}

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
                cmd.CommandText = @"INSERT INTO Corretores(Nome, Endereco, RG, CPF, CRECI, Fone, Email) VALUES(@Nome, @Endereco, @RG, @CPF, @CRECI, @Fone, @Email)";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Nome", _corretor.Nome);
                cmd.Parameters.AddWithValue("@Endereco", _corretor.Endereco);
                cmd.Parameters.AddWithValue("@RG", _corretor.RG);
                cmd.Parameters.AddWithValue("@CPF", _corretor.CPF);
                cmd.Parameters.AddWithValue("@CRECI", _corretor.CRECI);
                cmd.Parameters.AddWithValue("@Fone", _corretor.Fone);
                cmd.Parameters.AddWithValue("@Email", _corretor.Email);

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
                cmd.CommandText = @"SELECT IDCorretor, Nome, RG, CPF, CRECI, Fone, Email FROM Corretores";
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
                        corretor.Fone = rd["Fone"].ToString();
                        corretor.Email = rd["Email"].ToString();


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
                cmd.CommandText = @"SELECT IDCorretor, Nome, Endereco, RG, CPF, CRECI, Fone FROM Corretores WHERE IDCorretor = @Id";
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
                        corretor.Fone = rd["Fone"].ToString();
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
                cmd.CommandText = @"SELECT IDCorretor, Nome, Endereco, RG, CPF, CRECI, Fone FROM Corretores WHERE Nome LIKE @Nome";
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
                        corretor.Fone = rd["Fone"].ToString();

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
                cmd.CommandText = @"UPDATE Corretores SET 
                                        Nome = @Nome,
                                        Endereco = @Endereco,
                                        RG = @RG, 
                                        CPF = @CPF, 
                                        CRECI = @CRECI,
                                        Fone = @Fone 
                                    WHERE Id = @IDCorretor";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@IDCorretor", _corretor.IdCorretor);
                cmd.Parameters.AddWithValue("@Nome", _corretor.Nome);
                cmd.Parameters.AddWithValue("@Endereco", _corretor.Endereco);
                cmd.Parameters.AddWithValue("@RG", _corretor.RG);
                cmd.Parameters.AddWithValue("@CPF", _corretor.CPF);
                cmd.Parameters.AddWithValue("@CRECI", _corretor.CRECI);
                cmd.Parameters.AddWithValue("@Fone", _corretor.Fone);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar alterar corretor no banco de dados", ex) { Data = { { "Id", 54 } } };
            }
            finally
            {
                cn.Close();
            }
        }

        public Corretor BuscarPorCPF(string _CPF)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            Corretor corretor = new Corretor();

            try
            {

                SqlCommand cmd = new SqlCommand();


                cmd.Connection = cn;
                cmd.CommandText = @"SELECT IDCorretor, Nome, Endereco, RG, CPF, CRECI, Fone FROM Corretores WHERE CPF = @CPF";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@CPF", _CPF);


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
                        corretor.Fone = rd["Fone"].ToString();
                    }
                }
                return corretor;


            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar por um CPF no banco de dados", ex) { Data = { { "Id", 52 } } };
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
                cmd.CommandText = @"DELETE FROM Corretores WHERE IDCorretor = @id";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _id);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar excluir Corretor no banco de dados.", ex) { Data = { { "Id", 53 } } };
            }
            finally
            {
                cn.Close();
            }
        }
    }
    
}

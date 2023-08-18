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
    public class EmpreendimentoDAL
    {
        public Empreendimentos BuscarPorCNPJ(string _CNPJEmpresaResponsavel)
        {
            Empreendimentos empreendimentos = new Empreendimentos();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT IDEmpreendimeto, TotalTerrenos, CNPJEmpresaResponsavel, TamanhoArea FROM Empreendimentos WHERE CNPJEmpresaResponsavel = @CNPJEmpresaResponsavel";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", _CNPJEmpresaResponsavel);

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        empreendimentos.IDEmpreendimento = (int)rd["IDEmpreendimento"];
                        empreendimentos.TotalTerrenos = (int)rd["TotalTerrenos"];
                        empreendimentos.CNPJEmpresaResponsavel = rd["CNPJEmpresaResponsavel"].ToString();
                        empreendimentos.TamanhoArea = rd["TamanhoArea"].ToString();
                        empreendimentos.Nome = rd["Nome"].ToString();


                    }
                }
                return empreendimentos;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar empreendimento no banco de dados", ex) { Data = { { "Id", 300 } } };
            }
            finally
            {
                cn.Close();
            }

        }





        public Empreendimentos BuscarPorId(int _id)
        {

            Empreendimentos empreendimentos = new Empreendimentos();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT IDEmpreendimeto, TotalTerrenos, CNPJEmpresaResponsavel, TamanhoArea FROM Empreendimentos WHERE IDEmpreendimeto = @Id";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", _id);

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        empreendimentos.IDEmpreendimento = (int)rd["IDEmpreendimento"];
                        empreendimentos.TotalTerrenos = (int)rd["TotalTerrenos"];
                        empreendimentos.CNPJEmpresaResponsavel = rd["CNPJEmpresaResponsavel"].ToString();
                        empreendimentos.TamanhoArea = rd["TamanhoArea"].ToString();
                        empreendimentos.Nome = rd["Nome"].ToString();


                    }
                }
                return empreendimentos;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar empreendimento por id no banco de dados", ex) { Data = { { "Id", 301 } } };
            }
            finally
            {
                cn.Close();
            }
        }





        public void Inserir(Empreendimentos _empreendimentos)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"INSERT INTO Empreendimentos(TotalTerrenos, CNPJEmpresaResponsavel, TamanhoArea, Nome) VALUES(@TotalTerrenos, @CNPJEmpresaResponsavel, @TamanhoArea, @Nome)";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@TotalTerrenos", _empreendimentos.TotalTerrenos);
                cmd.Parameters.AddWithValue("@CNPJEmpresaResponsavel", _empreendimentos.CNPJEmpresaResponsavel);
                cmd.Parameters.AddWithValue("@TamanhoArea", _empreendimentos.TamanhoArea);
                cmd.Parameters.AddWithValue("@Nome", _empreendimentos.Nome);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar inserir um empreendimento no banco de dados.", ex) { Data = { { "Id", 200 } } };
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
                cmd.CommandText = @"DELETE FROM Empreendimentos WHERE IDEmpreendimento = @IDEmpreendimento";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _id);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar excluir Empreendimento no banco de dados", ex) { Data = { { "Id", 302 } } };
            }
            finally
            {
                cn.Close();
            }
        }





        public void Alterar(Empreendimentos _empreendimentos)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"UPDATE Empreendimentos SET
                                    TotalTerrenos = @TotalTerrenos,
                                    CNPJEmpresaResponsavel = @CNPJEmpresaResponsavel,
                                    TamanhoArea = @TamanhoArea,
                                    Nome = @Nome
                                    WHERE Id = @IDEmpreendimento";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@TotalTerrenos", _empreendimentos.TotalTerrenos);
                cmd.Parameters.AddWithValue("@CNPJEmpresaResponsavel", _empreendimentos.CNPJEmpresaResponsavel);
                cmd.Parameters.AddWithValue("@TamanhoArea", _empreendimentos.TamanhoArea);
                cmd.Parameters.AddWithValue("@Nome", _empreendimentos.Nome);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar alterar empreendimento no banco de dados", ex) { Data = { { "Id", 250 } } };
            }
        }






        public List<Empreendimentos> BuscarTodos()
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            Empreendimentos empreendimentos = new Empreendimentos();

            try
            {
                SqlCommand cmd = new SqlCommand();


                List<Empreendimentos> empreendimentosList = new List<Empreendimentos>();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT IDEmpreendimento, TotalTerrenos,CNPJEmpresaResponsavel, TamanhoArea, Nome FROM Empreendimentos";
                cmd.CommandType = System.Data.CommandType.Text;

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        empreendimentos = new Empreendimentos();
                        empreendimentos.IDEmpreendimento = (int)rd["IDEmpreendimento"];
                        empreendimentos.TotalTerrenos = (int)rd["TotalTerrenos"];
                        empreendimentos.CNPJEmpresaResponsavel = rd["CNPJEmpresaResponsavel"].ToString();
                        empreendimentos.TamanhoArea = rd["TamanhoArea"].ToString();
                        empreendimentos.Nome = rd["Nome"].ToString();

                        empreendimentosList.Add(empreendimentos);
                    }
                }
                return empreendimentosList;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao buscar todos os empreendimentos no banco de dados", ex) { Data = { { "Id", 444 } } };
            }
            finally
            {
                cn.Close();
            }
        }





        public List<Empreendimentos> BuscarPorNome(string _nome)
        {
            List<Empreendimentos> empreendimentosList = new List<Empreendimentos>();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            Empreendimentos empreendimentos = new Empreendimentos();

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT IDEmpreendimento, TotalTerrenos,CNPJEmpresaResponsavel, TamanhoArea, Nome FROM Empreendimentos WHERE Nome LIKE @Nome";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Nome", "%" + _nome + "%");

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        empreendimentos = new Empreendimentos();
                        empreendimentos.IDEmpreendimento = (int)rd["IDEmpreendimento"];
                        empreendimentos.TotalTerrenos = (int)rd["TotalTerrenos"];
                        empreendimentos.CNPJEmpresaResponsavel = rd["CNPJEmpresaResponsavel"].ToString();
                        empreendimentos.TamanhoArea = rd["TamanhoArea"].ToString();
                        empreendimentos.Nome = rd["Nome"].ToString();

                        empreendimentosList.Add(empreendimentos);
                    }
                }
                return empreendimentosList;
            }
            catch (Exception ex)
            {
                throw new Exception("ocorreu um erro ao buscar por nome de empreendimentos no banco de dados", ex) { Data = { { "Id", 445 } } };
            }
            finally
            {
                cn.Close();
            }

            
        }
    }
}

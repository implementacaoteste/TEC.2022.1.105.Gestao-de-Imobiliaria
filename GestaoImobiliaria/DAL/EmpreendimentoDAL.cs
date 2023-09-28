﻿using Models;
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
                cmd.CommandText = @"SELECT Empreendimentos.IDEmpreendimento, Terrenos.TotalTerrenos, Empreendimentos.CNPJEmpresaResponsavel, Empreendimentos.Nome FROM Empreendimentos
                                    INNER JOIN
                                    (SELECT IDEmpreendimento, COUNT(IDEmpreendimento) AS TotalTerrenos FROM Terrenos GROUP BY IDEmpreendimento) AS Terrenos
                                    ON Empreendimentos.IDEmpreendimento = Terrenos.IDEmpreendimento 

                                    WHERE Empreendimentos.CNPJEmpresaResponsavel = @CNPJEmpresaResponsavel";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@CNPJEmpresaResponsavel", _CNPJEmpresaResponsavel);

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        empreendimentos.IDEmpreendimento = (int)rd["IDEmpreendimento"];
                        empreendimentos.TotalTerrenos = rd["TotalTerrenos"].ToString();
                        empreendimentos.CNPJEmpresaResponsavel = rd["CNPJEmpresaResponsavel"].ToString();
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
                cmd.CommandText = @"SELECT Empreendimentos.IDEmpreendimento, Terrenos.TotalTerrenos, Empreendimentos.CNPJEmpresaResponsavel,  Empreendimentos.Nome FROM Empreendimentos
                                    INNER JOIN
                                    (SELECT IDEmpreendimento, COUNT(IDEmpreendimento) AS TotalTerrenos FROM Terrenos GROUP BY IDEmpreendimento) AS Terrenos
                                    ON Empreendimentos.IDEmpreendimento = Terrenos.IDEmpreendimento 

                                    WHERE Empreendimentos.IDEmpreendimento = @Id";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", _id);

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        empreendimentos.IDEmpreendimento = (int)rd["IDEmpreendimento"];
                        empreendimentos.TotalTerrenos = rd["TotalTerrenos"].ToString();
                        empreendimentos.CNPJEmpresaResponsavel = rd["CNPJEmpresaResponsavel"].ToString();
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
                cmd.CommandText = @"INSERT INTO Empreendimentos(CNPJEmpresaResponsavel, Nome) VALUES(@CNPJEmpresaResponsavel, @Nome)";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@CNPJEmpresaResponsavel", _empreendimentos.CNPJEmpresaResponsavel);
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
                
                if (new TerrenoDAL().ExistePorIdEmpreendimento(_id))
                    throw new Exception("Não é possível excluir um empreendimento com terrenos vinculados.") { Data = { { "Id", 302 } } };

                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"DELETE FROM Empreendimentos WHERE IDEmpreendimento = @IDEmpreendimento";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@IDEmpreendimento", _id);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar excluir empreendimento.", ex) { Data = { { "Id", 303 } } };
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
                                    CNPJEmpresaResponsavel = @CNPJEmpresaResponsavel,
                                    Nome = @Nome
                                    WHERE IDEmpreendimento = @IDEmpreendimento";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@IDEmpreendimento", _empreendimentos.IDEmpreendimento);
                cmd.Parameters.AddWithValue("@CNPJEmpresaResponsavel", _empreendimentos.CNPJEmpresaResponsavel);
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
                cmd.CommandText = @"SELECT Empreendimentos.IDEmpreendimento, ISNULL(Terrenos.TotalTerrenos, 0) AS TotalTerrenos, Empreendimentos.CNPJEmpresaResponsavel, 
                                     Empreendimentos.Nome 
                                    FROM Empreendimentos
                                    LEFT JOIN
                                    (SELECT IDEmpreendimento, COUNT(IDEmpreendimento) AS TotalTerrenos FROM Terrenos GROUP BY IDEmpreendimento) AS Terrenos
                                    ON Empreendimentos.IDEmpreendimento = Terrenos.IDEmpreendimento 
                                    ";
                cmd.CommandType = System.Data.CommandType.Text;

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        empreendimentos = new Empreendimentos();
                        empreendimentos.IDEmpreendimento = (int)rd["IDEmpreendimento"];
                        empreendimentos.TotalTerrenos = rd["TotalTerrenos"].ToString();
                        empreendimentos.CNPJEmpresaResponsavel = rd["CNPJEmpresaResponsavel"].ToString();
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
                cmd.CommandText = @"SELECT Empreendimentos.IDEmpreendimento, Terrenos.TotalTerrenos, Empreendimentos.CNPJEmpresaResponsavel, Empreendimentos.Nome FROM Empreendimentos
                                    INNER JOIN
                                    (SELECT IDEmpreendimento, COUNT(IDEmpreendimento) AS TotalTerrenos FROM Terrenos GROUP BY IDEmpreendimento) AS Terrenos
                                    ON Empreendimentos.IDEmpreendimento = Terrenos.IDEmpreendimento 

                                    WHERE Empreendimentos.Nome LIKE @Nome";

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Nome", "%" + _nome + "%");

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        empreendimentos = new Empreendimentos();
                        empreendimentos.IDEmpreendimento = (int)rd["IDEmpreendimento"];
                        empreendimentos.TotalTerrenos = rd["TotalTerrenos"].ToString();
                        empreendimentos.CNPJEmpresaResponsavel = rd["CNPJEmpresaResponsavel"].ToString();
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

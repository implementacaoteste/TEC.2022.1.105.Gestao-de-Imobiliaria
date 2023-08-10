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
            Empreendimentos empreendimento = new Empreendimentos();
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
                        empreendimento.IDEmpreendimento = (int)rd["IDEmpreendimento"];
                        empreendimento.TotalTerrenos = rd["TotalTerrenos"].ToString();
                        empreendimento.CNPJEmpresaResponsavel = rd["CNPJEmpresaResponsavel"].ToString();
                        empreendimento.TamanhoArea = rd["TamanhoArea"].ToString();


                    }
                }
                return empreendimento;
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





        public Empreendimentos BuscarPorId(int _id)
        {

            Empreendimentos empreendimento = new Empreendimentos();
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
                        empreendimento.IDEmpreendimento = (int)rd["IDEmpreendimento"];
                        empreendimento.TotalTerrenos = rd["TotalTerrenos"].ToString();
                        empreendimento.CNPJEmpresaResponsavel = rd["CNPJEmpresaResponsavel"].ToString();
                        empreendimento.TamanhoArea = rd["TamanhoArea"].ToString();


                    }
                }
                return empreendimento;
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





        public void Inserir(Empreendimentos _empreendimentos)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"INSERT INTO Empreendimentos(TotalTerrenos, CNPJEmpresaResponsavel, TamanhoArea) VALUES(@TotalTerrenos, @CNPJEmpresaResponsavel, @TamanhoArea)";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@TotalTerrenos", _empreendimentos.TotalTerrenos);
                cmd.Parameters.AddWithValue("@CNPJEmpresaResponsavel", _empreendimentos.CNPJEmpresaResponsavel);
                cmd.Parameters.AddWithValue("@TamanhoArea", _empreendimentos.TamanhoArea);

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




        
    }

}

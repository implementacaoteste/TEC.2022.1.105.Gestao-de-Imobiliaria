using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class EmpreendimentoDAL
    {
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
            catch(Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar inserir um empreendimento no banco de dados.", ex) { Data = { { "Id", 200 } } };
            }
            finally
            {
                cn.Close();
            }
        }
    }


    //nao consegui resolver o erro, farei o commit com erro
    //pois só eu estou trabalhando com Empreendimentos
    //Na DAL, BLL e MODELS
    public Empreendimentos BuscarPorID(int _id) //Erro no método não identificado
    {
        SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
        Empreendimentos empreendimentos = new Empreendimentos();

        try
        {

        }
        catch
        {

        }
    }
}

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
                cmd.CommandText = @"INSERT INTO Terreno(PrecoAVista, PrecoParcelado, RedeAguaEnergia, MetragemFrente, MetragemFundo, MetragemLaterais,
                    TamanhoTotalTerreno, ConfrontacoesTerreno, Endereco, NumeroMatricula) 
                                    VALUES (@PrecoAVista, @PrecoParcelado, @RedeAguaEnergia, @MetragemFrente, @MetragemFundo, @MetragemLaterais,
                    @TamanhoTotalTerreno, @ConfrontacoesTerreno, @Endereco, @NumeroMatricula";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@PrecoAVista", _terreno.PrecoAVista);
                cmd.Parameters.AddWithValue("@PrecoParcelado", _terreno.PrecoParcelado);
                cmd.Parameters.AddWithValue("@RedeAguaEnergia", _terreno.RedeAguaEnergia);
                cmd.Parameters.AddWithValue("@MetragemFrente", _terreno.MetragemFrente);
                cmd.Parameters.AddWithValue("@MetragemFundo", _terreno.MetragemFundo);
                cmd.Parameters.AddWithValue("@MetragemLaterais", _terreno.MetragemLaterais);
                cmd.Parameters.AddWithValue("@TamanhoTotalTerreno", _terreno.TamanhoTotal);
                cmd.Parameters.AddWithValue("@ConfrontacoesTerreno", _terreno.ComfrontacoesTerreno);
                cmd.Parameters.AddWithValue("@Endereco", _terreno.Endereco);
                cmd.Parameters.AddWithValue("@NumeroMatricula", _terreno.Matricula);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar inserir um terreno no banco de dados.", ex) { Data = { { "Id", 22 } } };
            }
            finally
            {
                cn.Close();
            }
        }
        public List<Terreno> BuscarTodos()
        {
            List<Terreno> terrenoList = new List<Terreno>();
            Terreno terreno = new Terreno();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Id, Nome, CPF, RG, Email, Fone FROM Terreno";
                cmd.CommandType = System.Data.CommandType.Text;

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        terreno = new Terreno();
                        terreno.IdTerreno = (int)rd["Id"];
                       

                        terrenoList.Add(terreno);
                    }
                }
                return terrenoList;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar terrenos no banco de dados", ex) { Data = { { "Id", 23 } } };
            }
            finally
            {
                cn.Close();
            }
        }
        public Terreno BuscarPorId(int _id)
        {
            Terreno terreno = new Terreno();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Id, Nome, CPF, RG, Email, Fone FROM Terreno WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", _id);

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        terreno.IdTerreno = (int)rd["Id"];
                       
                    }
                }
                return terreno;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar fornecedor por id no banco de dados", ex) { Data = { { "Id", 24 } } };
            }
            finally
            {
                cn.Close();
            }
        }
        public void Alterar(Terreno _terreno)
        {

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"UPDATE Terreno SET 
                                        Nome = @Nome, 
                                        CPF = @CPF, 
                                        RG = @RG, 
                                        Email = @Email, 
                                        Fone = @Fone 
                                    WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _terreno.IdTerreno);
               

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar alterar cliente no banco de dados", ex) { Data = { { "Id", 25 } } };
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
                throw new Exception("Ocorreu um erro ao tentar excluir fornecdor no banco de dados.", ex) { Data = { { "Id", 26 } } };
            }
            finally
            {
                cn.Close();
            }
        }
    }
}

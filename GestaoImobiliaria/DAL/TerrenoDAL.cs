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
                cmd.CommandText = @"INSERT INTO Terrenos (IDEmpreendimento,PrecoAVista, PrecoParcelado,
						MetragemFrente, MetragemFundo, TamanhoTotalTerreno, ConfrontacoesTerreno,
						Endereco, NumeroMatricula, MetragemEsquerda, MetragemDireita, RedeAgua,
						RedeEnergia) VALUES (@IDEmpreendimento, @PrecoAVista, @PrecoParcelado,
                                    @MetragemFrente, @MetragemFundo, @TamanhoTotalTerreno,
                                    @ConfrontacoesTerreno, @Endereco, @NumeroMatricula, @MetragemEsquerda,
                                    @MetragemDireita, @RedeAgua, @RedeEnergia)";


                cmd.CommandType = System.Data.CommandType.Text;
                //OBS: Só consegui inserir um terreno, quando existe um "Empreendimento" cadastrado
                //tem que inserir um IdTerreno e um IdEmpreendimento

                cmd.Parameters.AddWithValue("@IDEmpreendimento", _terreno.IdEmpreendimento);
                cmd.Parameters.AddWithValue("@PrecoAVista", _terreno.PrecoAVista);
                cmd.Parameters.AddWithValue("@PrecoParcelado", _terreno.PrecoParcelado);
                cmd.Parameters.AddWithValue("@MetragemFrente", _terreno.MetragemFrente);
                cmd.Parameters.AddWithValue("@MetragemFundo", _terreno.MetragemFundo);
                cmd.Parameters.AddWithValue("@TamanhoTotalTerreno", _terreno.TamanhoTotalTerreno);
                cmd.Parameters.AddWithValue("@ConfrontacoesTerreno", _terreno.ConfrontacoesTerreno);
                cmd.Parameters.AddWithValue("@Endereco", _terreno.Endereco);
                cmd.Parameters.AddWithValue("@NumeroMatricula", _terreno.Matricula);
                cmd.Parameters.AddWithValue("@MetragemEsquerda", _terreno.MetragemEsquerda);
                cmd.Parameters.AddWithValue("@MetragemDireita", _terreno.MetragemDireita);
                cmd.Parameters.AddWithValue("@RedeAgua", _terreno.RedeAgua);
                cmd.Parameters.AddWithValue("@RedeEnergia", _terreno.RedeEnergia);

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
                cmd.CommandText = @"SELECT IDTerreno, IDEmpreendimento,PrecoAVista, PrecoParcelado,
						MetragemFrente, MetragemFundo, TamanhoTotalTerreno, ConfrontacoesTerreno,
						Endereco, NumeroMatricula, MetragemEsquerda, MetragemDireita, RedeAgua,
						RedeEnergia FROM Terrenos";

                cmd.CommandType = System.Data.CommandType.Text;

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        terreno = new Terreno();
                        terreno.IdTerreno = (int)rd["IDTerreno"];
                        terreno.IdEmpreendimento = (int)rd["IdEmpreendimento"];
                        terreno.PrecoAVista = (double)rd["PrecoAVista"];
                        terreno.PrecoParcelado = (double)rd["PrecoParcelado"];
                        terreno.MetragemFrente = (double)rd["MetragemFrente"];
                        terreno.MetragemFundo = (double)rd["MetragemFundo"];
                        terreno.TamanhoTotalTerreno = (double)rd["TamanhoTotalTerreno"];
                        terreno.ConfrontacoesTerreno = (string)rd["ConfrontacoesTerreno"];
                        terreno.Endereco = (string)rd["Endereco"];
                        terreno.Matricula = (string)rd["NumeroMatricula"];
                        terreno.MetragemEsquerda = (double)rd["MetragemEsquerda"];
                        terreno.MetragemDireita = (double)rd["MetragemDireita"];
                        terreno.RedeAgua = (bool)rd["RedeAgua"];
                        terreno.RedeEnergia = (bool)rd["RedeEnergia"];

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
                cmd.CommandText = @"SELECT IdTerreno, IdEmpreendimento, PrecoAVista, PrecoParcelado,
                                    MetragemFrente, MetragemFundo, TamanhoTotalTerreno, ConfrontacoesTerreno,
                                    Endereco, NumeroMatricula, MetragemEsquerda, MetragemDireita, RedeAgua,
                                    RedeEnergia FROM Terrenos WHERE IdTerreno = @Id";

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", _id);
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {

                        terreno.IdTerreno = (int)rd["IdTerreno"];
                        terreno.IdEmpreendimento = (int)rd["IdEmpreendimento"];
                        terreno.PrecoAVista = (double)rd["PrecoAVista"];
                        //decisao a microsoft entre o double e o float
                        terreno.PrecoParcelado = (double)rd["PrecoParcelado"];
                        terreno.RedeAgua = (bool)rd["RedeAgua"];
                        terreno.RedeEnergia = (bool)rd["RedeEnergia"];
                        terreno.MetragemFrente = (double)rd["MetragemFrente"];
                        terreno.MetragemFundo = (double)rd["MetragemFundo"];
                        terreno.TamanhoTotalTerreno = (double)rd["TamanhoTotalTerreno"];
                        terreno.ConfrontacoesTerreno = (string)rd["ConfrontacoesTerreno"];
                        terreno.Endereco = (string)rd["Endereco"].ToString();
                        terreno.Matricula = (string)rd["NumeroMatricula"];
                        terreno.MetragemEsquerda = (double)rd["MetragemEsquerda"];
                        terreno.MetragemDireita = (double)rd["MetragemDireita"];
                    }
                }
                return terreno;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar o Id de um Terreno no banco de dados", ex) { Data = { { "Id", 24 } } };
            }
            finally
            {
                cn.Close();
            }
        }
        public Terreno BuscarPorMatricula(string _matricula)
        {
            Terreno terreno = new Terreno();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;

                cmd.CommandText = @"SELECT IdTerreno, IdEmpreendimento, PrecoAVista, PrecoParcelado,
                MetragemFrente, MetragemFundo, TamanhoTotalTerreno, ConfrontacoesTerreno,
                Endereco, NumeroMatricula, MetragemEsquerda, MetragemDireita, RedeAgua,
                RedeEnergia FROM Terrenos WHERE NumeroMatricula = @Matricula";

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Matricula", _matricula);

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        terreno.IdTerreno = (int)rd["IdTerreno"];
                        terreno.IdEmpreendimento = (int)rd["IdEmpreendimento"];
                        terreno.PrecoAVista = (double)rd["PrecoAVista"];
                        //decisao a microsoft entre o double e o float
                        terreno.PrecoParcelado = (double)rd["PrecoParcelado"];
                        terreno.RedeAgua = (bool)rd["RedeAgua"];
                        terreno.RedeEnergia = (bool)rd["RedeEnergia"];
                        terreno.MetragemFrente = (double)rd["MetragemFrente"];
                        terreno.MetragemFundo = (double)rd["MetragemFundo"];
                        terreno.TamanhoTotalTerreno = (double)rd["TamanhoTotalTerreno"];
                        terreno.ConfrontacoesTerreno = (string)rd["ConfrontacoesTerreno"];
                        terreno.Endereco = (string)rd["Endereco"].ToString();
                        terreno.Matricula = (string)rd["NumeroMatricula"];
                        terreno.MetragemEsquerda = (double)rd["MetragemEsquerda"];
                        terreno.MetragemDireita = (double)rd["MetragemDireita"];
                    }
                }
                return terreno;

            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar por Numero de matricula no banco de dados", ex) { Data = { { "Id", 25 } } };
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
                                        PrecoAVista = @PrecoAVista,
                                        PrecoParcelado = @PrecoParcelado,
                                        MetragemFrente = @MetragemFrente,
                                        MetragemFundo = @MetragemFundo,
                                        TamanhoTotalTerreno = @TamanhoTotalTerreno,
                                        ConfrontacoesTerreno = @ConfrontacoesTerreno,
                                        Endereco = @Endereco,
                                        NumeroMatricula = @NumeroMatricula
                                        MetragemEsquerda = @MetragemLaterais,
                                        MetragemDireita = @MetragemLaterais,
                                        RedeAgua = @RedeAgua,
                                        RedeEnergia = @RedeEnergia,
                                    WHERE IdTerreno = @IdTerreno";

                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _terreno.IdTerreno);


                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar alterar cliente no banco de dados", ex) { Data = { { "Id", 26 } } };
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
                cmd.CommandText = @"DELETE FROM Terrenos WHERE IdTerreno = @IdTerreno";

                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@IdTerreno", _id);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar excluir fornecdor no banco de dados.", ex) { Data = { { "Id", 27 } } };
            }
            finally
            {
                cn.Close();
            }
        }
    }
}

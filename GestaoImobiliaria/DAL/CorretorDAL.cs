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
                        corretor.Id = Convert.ToInt32(rd["Id"]);
                        corretor.Nome = rd["Nome"].ToString();
                        corretor.NomeCorretor = rd["NomeCorretor"].ToString();
                        corretor.Email = rd["Email"].ToString();
                        corretor.CPF = rd["CPF"].ToString();
                        corretor.Ativo = Convert.ToBoolean(rd["Ativo"].ToString());
                        corretor.Senha = rd["Senha"].ToString();
                        corretor.GrupoCorretors = new GrupoCorretorDAL().BuscarPorIdCorretor(corretor.Id);
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
    }
}

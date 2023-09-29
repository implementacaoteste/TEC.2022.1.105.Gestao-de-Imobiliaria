using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DAL
{
    public class Status_TerrenoDAL
    {
        //TODO: Implementar este método
        public Status_Terreno BuscarPorId(int _id)
        {
            Status_Terreno status_Terreno = new Status_Terreno();

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT Id, Status_Atual FROM Status_Terrenos WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;
                
                cmd.Parameters.AddWithValue("@Id", _id);

                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        status_Terreno.Id = Convert.ToInt32(rd["Id"]);
                        status_Terreno.Status_Atual = rd["Status_Atual"].ToString();
                    }
                }
                return status_Terreno;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar status do terreno por id no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
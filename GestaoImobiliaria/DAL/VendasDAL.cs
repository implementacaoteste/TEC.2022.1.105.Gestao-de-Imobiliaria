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
    public class VendasDAL
    {
        public void Alterar(Vendas _vendas)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"UPDATE Vendas SET
                                    IDVenda = @IDVenda,
                                    IDTerreno = @IDTerreno,
                                    IDCliente = @IDCliente,
                                    IDCorretor = @IDCorretor
                                    WHERE IDVenda = @IDVenda";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@IDVenda", _vendas.IDVenda);
                cmd.Parameters.AddWithValue("@IDTerreno", _vendas.IDTerreno);
                cmd.Parameters.AddWithValue("IDCliente", _vendas.IDCliente);
                cmd.Parameters.AddWithValue("IDCorretor", _vendas.IDCorretor);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar alterar venda no banco de dados", ex) { Data = { { "Id", 2431 } } };
            }
        }







        public List<Vendas> BuscarTodos()
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            Vendas vendas = new Vendas();

            try
            {
                SqlCommand cmd = new SqlCommand();


                List<Vendas> vendasList = new List<Vendas>();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT IDVenda, IDTerreno, IDCliente, IDCorretor, Nome FROM Vendas";
                cmd.CommandType = System.Data.CommandType.Text;

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        vendas = new Vendas();
                        vendas.IDVenda = (int)rd["IDVenda"];
                        vendas.IDTerreno = (int)rd["IDTerreno"];
                        vendas.IDCliente = (int)rd["IDCliente"];
                        vendas.IDCorretor = (int)rd["IDCorretor"]; ;
                        

                        vendasList.Add(vendas);
                    }
                }
                return vendasList;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao buscar todas as vendas no banco de dados", ex) { Data = { { "Id", 2433 } } };
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
                cmd.CommandText = @"DELETE FROM Vendas WHERE IDVenda = @IDEmpreendimento";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _id);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar excluir uma VENDA no banco de dados", ex) { Data = { { "Id", 2432 } } };
            }
            finally
            {
                cn.Close();
            }
        }







        public void Inserir(Vendas _vendas)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"INSERT INTO Vendas(IDVenda, IDTerreno, IDCliente, IDCorretor) VALUES(@IDVenda, @IDTerreno, @IDCliente, @IDCorretor)";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@IDVenda", _vendas.IDVenda);
                cmd.Parameters.AddWithValue("@IDTerreno", _vendas.IDTerreno);
                cmd.Parameters.AddWithValue("IDCliente", _vendas.IDCliente);
                cmd.Parameters.AddWithValue("IDCorretor", _vendas.IDCorretor);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar inserir uma venda no banco de dados.", ex) { Data = { { "Id", 2430 } } };
            }
            finally
            {
                cn.Close();
            }
        }






        public Vendas BuscarPorCorretor(int _idcorretor)
        {

            Vendas vendas = new Vendas();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT IDVenda, IDTerreno, IDCliente, IDCorretor, Nome FROM Vendas WHERE IDCorretor = @IDCorretor";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@IDCorretor", _idcorretor);

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        vendas = new Vendas();
                        vendas.IDVenda = (int)rd["IDVenda"];
                        vendas.IDTerreno = (int)rd["IDTerreno"];
                        vendas.IDCliente = (int)rd["IDCliente"];
                        vendas.IDCorretor = (int)rd["IDCorretor"]; ;


                    }
                }
                return vendas;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar venda por corretor no banco de dados", ex) { Data = { { "Id", 2434 } } };
            }
            finally
            {
                cn.Close();
            }
        }






        public Vendas BuscarPorCliente(int _idcliente)
        {
            Vendas vendas = new Vendas();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT IDVenda, IDTerreno, IDCliente, IDCorretor, Nome FROM Vendas WHERE IDCliente = @IDCliente";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@IDCorretor", _idcliente);

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        vendas = new Vendas();
                        vendas.IDVenda = (int)rd["IDVenda"];
                        vendas.IDTerreno = (int)rd["IDTerreno"];
                        vendas.IDCliente = (int)rd["IDCliente"];
                        vendas.IDCorretor = (int)rd["IDCorretor"]; ;


                    }
                }
                return vendas;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar venda por corretor no banco de dados", ex) { Data = { { "Id", 2434 } } };
            }
            finally
            {
                cn.Close();
            }
        }
    }
}

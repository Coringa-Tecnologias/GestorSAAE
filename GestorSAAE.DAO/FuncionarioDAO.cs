using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using GestorSAAE.Entidades;
using System.Data;

namespace GestorSAAE.DAO
{
    public class FuncionarioDAO
    {
        public bool Inserir(FuncionarioEnt objTabela)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;

                con.Open();

                cn.CommandText = "INSERT INTO Funcionario ([nome], [identificador], [senha], [autenticacao],[celular], [email], [tipo]) VALUES(@nome, @identificador, @senha, @autenticacao, @celular, @email, @tipo)";

                cn.Parameters.Add("nome", SqlDbType.VarChar).Value = objTabela.Nome;
                cn.Parameters.Add("identificador", SqlDbType.VarChar).Value = objTabela.Identificador;
                cn.Parameters.Add("senha", SqlDbType.VarChar).Value = objTabela.Senha;
                cn.Parameters.Add("autenticacao", SqlDbType.Bit).Value = objTabela.Autenticacao;
                cn.Parameters.Add("celular", SqlDbType.VarChar).Value = objTabela.Celular;
                cn.Parameters.Add("email", SqlDbType.VarChar).Value = objTabela.Email;
                cn.Parameters.Add("tipo", SqlDbType.Int).Value = objTabela.Tipo;

                cn.Connection = con;

                int qtd = cn.ExecuteNonQuery();

                if (qtd > 0)
                    return true;
                else
                    return false;
            }


        }

        public FuncionarioEnt Login(FuncionarioEnt obj)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;

                con.Open();

                cn.CommandText = "SELECT * FROM Funcionario WHERE identificador = @identificador AND senha = @senha";

                cn.Connection = con;

                cn.Parameters.Add("identificador", SqlDbType.VarChar).Value = obj.Identificador;
                cn.Parameters.Add("senha", SqlDbType.VarChar).Value = obj.Senha;

                SqlDataReader dr;

                dr = cn.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        FuncionarioEnt dado = new FuncionarioEnt();
                        dado.Identificador = Convert.ToString(dr["identificador"]);
                        dado.Senha = Convert.ToString(dr["senha"]);
                    }
                }
                else
                {
                    obj.Identificador = null;
                    obj.Senha = null;
                }

                return obj;
            }
        }

        public List<FuncionarioEnt> Lista()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;

                con.Open();

                cn.CommandText = "SELECT * FROM Funcionario ORDER BY nome";

                cn.Connection = con;

                SqlDataReader dr;
                List<FuncionarioEnt> lista = new List<FuncionarioEnt>();

                dr = cn.ExecuteReader();

                if(dr.HasRows)
                {
                    while(dr.Read())
                    {
                        FuncionarioEnt dado = new FuncionarioEnt();
                        dado.Codigo = Convert.ToInt32(dr["codigo"]);
                        dado.Nome = Convert.ToString(dr["nome"]);
                        dado.Identificador = Convert.ToString(dr["identificador"]);
                        dado.Senha = Convert.ToString(dr["senha"]);
                        dado.Autenticacao = Convert.ToBoolean(dr["autenticacao"]);
                        dado.Celular = Convert.ToString(dr["celular"]);
                        dado.Email = Convert.ToString(dr["email"]);
                        dado.Tipo = Convert.ToInt32(dr["tipo"]);

                        lista.Add(dado);
                    }
                }

                return lista;
            }
        }
    }
}

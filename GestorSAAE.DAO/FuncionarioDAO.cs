using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using GestorSAAE.Entidades;
using System.Data;
using ThoughtWorks.QRCode.Codec;
using ThoughtWorks.QRCode.Codec.Data;
using ThoughtWorks.QRCode.Codec.Util;

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

        public bool GerarQr(FuncionarioEnt objTabela)
        {
            QRCodeEncoder qrCodeEncoder = new QRCodeEncoder();
            String encoding = "Byte";
            if (encoding == "Byte")
            {
                qrCodeEncoder.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE;
            }
            else if (encoding == "AlphaNumeric")
            {
                qrCodeEncoder.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.ALPHA_NUMERIC;
            }
            else if (encoding == "Numeric")
            {
                qrCodeEncoder.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.NUMERIC;
            }
            try
            {
                int scale = Convert.ToInt32("40");
                qrCodeEncoder.QRCodeScale = scale;
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Tamanho inválido!");
                return false;
            }
            try
            {
                int version = Convert.ToInt32("12");
                qrCodeEncoder.QRCodeVersion = version;
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Versão inválida!");
                return false;
            }

            string errorCorrect = "H";
            if (errorCorrect == "L")
                qrCodeEncoder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.L;
            else if (errorCorrect == "M")
                qrCodeEncoder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.M;
            else if (errorCorrect == "Q")
                qrCodeEncoder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.Q;
            else if (errorCorrect == "H")
                qrCodeEncoder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.H;

            String data = "BEGIN:VCARD" + Environment.NewLine;
            data += "VERSION:2.1" + Environment.NewLine;
            data += "FN:" + objTabela.Nome + Environment.NewLine;
            data += "TEL;CELL;VOICE:" + objTabela.Celular + Environment.NewLine;
            data += "EMAIL;PREF;INTERNET:" + objTabela.Email + Environment.NewLine;
            data += "END:VCARD" + Environment.NewLine;
            objTabela.QrContato = qrCodeEncoder.Encode(data);

            if (objTabela.QrContato != null)
                return true;
            else
                return false;

        }

        public bool Editar(FuncionarioEnt objTabela)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;

                con.Open();

                cn.CommandText = "UPDATE Funcionario SET nome  = @nome, identificador = @identificador, senha = @senha, autenticacao = @autenticacao, celular = @celular, email = @email, tipo = @tipo WHERE codigo = @codigo";

                cn.Parameters.Add("codigo", SqlDbType.Int).Value = objTabela.Codigo;
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

        public bool Excluir(FuncionarioEnt objTabela)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;

                con.Open();

                cn.CommandText = "DELETE FROM Funcionario WHERE codigo = @codigo";

                cn.Parameters.Add("codigo", SqlDbType.Int).Value = objTabela.Codigo;

                cn.Connection = con;

                int qtd = cn.ExecuteNonQuery();

                if (qtd > 0)
                    return true;
                else
                    return false;
            }
        }

        public List<FuncionarioEnt> Exibe(FuncionarioEnt objTabela)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;

                con.Open();

                cn.CommandText = "SELECT * FROM Funcionario WHERE codigo = @codigo ORDER BY nome";
                cn.Parameters.Add("codigo", SqlDbType.Int).Value = objTabela.Codigo;

                cn.Connection = con;

                SqlDataReader dr;
                List<FuncionarioEnt> lista = new List<FuncionarioEnt>();

                dr = cn.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
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

        public List<FuncionarioEnt> Lista(string campo, FuncionarioEnt objTabela)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;

                con.Open();

                if (campo == "Código")
                {
                    cn.CommandText = "SELECT * FROM Funcionario WHERE codigo = @codigo ORDER BY nome";
                    cn.Parameters.Add("codigo", SqlDbType.Int).Value = objTabela.Codigo;
                }
                else if (campo == "Nome")
                {
                    cn.CommandText = "SELECT * FROM Funcionario WHERE nome like @nome ORDER BY nome";
                    cn.Parameters.Add("nome", SqlDbType.VarChar).Value = "%" + objTabela.Nome + "%";
                }
                else if (campo == "E-mail")
                {
                    cn.CommandText = "SELECT * FROM Funcionario WHERE email like @email ORDER BY nome";
                    cn.Parameters.Add("email", SqlDbType.VarChar).Value = "%" + objTabela.Email + "%";
                }

                cn.Connection = con;

                SqlDataReader dr;
                List<FuncionarioEnt> lista = new List<FuncionarioEnt>();

                dr = cn.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
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

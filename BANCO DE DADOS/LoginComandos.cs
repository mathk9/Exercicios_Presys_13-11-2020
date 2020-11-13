using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Criptografia_Exemplo
{
    class LoginComandos
    {
        public bool existe = false;
        public string mensagem = "";
        SqlCommand cmd = new SqlCommand();
        Conexao connect = new Conexao();
        SqlDataReader dr;


        public bool VerificarLogin(string login, string senha)
        {
            //comandos sql para verificar se existe no banco
            cmd.CommandText = "Select * from table1 where email = @login and senha = @senha";
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@senha", senha);

            try
            {
                cmd.Connection = connect.conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    existe = true;
                }
                connect.desconectar();
                dr.Close();
            }
            catch (SqlException)
            {
                this.mensagem = "ERRO COM BANCO DE DADOS!!!";
            }

            return existe;
        }

        public string Cadastrar(string email, string senha, string confirmar)
        {
            existe = false;

            //comandos para inserir no banco 
            if (senha.Equals(confirmar))
            {
                cmd.CommandText = "insert into Table1 values (@e,@s);";
                cmd.Parameters.AddWithValue("@e", email);
                cmd.Parameters.AddWithValue("@s", senha);


                try
                {
                    cmd.Connection = connect.conectar();
                    cmd.ExecuteNonQuery();
                    connect.desconectar();
                    this.mensagem = "Cadastrado com sucesso!!!";
                    existe = true;
                }
                catch (SqlException)
                {
                    this.mensagem = "Erro com banco de dados;";
                }
            }
            else
            {
                this.mensagem = "As senhas não corresondem!!!";
            }

            
            return mensagem;
        }

        public void Deleta(string login, string senha)
        {
            existe = false;
                       

            cmd.CommandText = "delete from table1 where email = @l and senha = @s";
            cmd.Parameters.AddWithValue("@l", login);
            cmd.Parameters.AddWithValue("@s", senha);

            cmd.Connection = connect.conectar();
            cmd.ExecuteNonQuery();
            connect.desconectar();
            existe = true;
             
        }

        public string MudarSenha(string email, string senha, string confirmar)
        {
            existe = false;

            //comandos para inserir no banco 
            if (senha.Equals(confirmar))
            {
                cmd.CommandText = "UPDATE Table1 SET senha = @key WHERE email = @email;";
                cmd.Parameters.AddWithValue("@key", senha);
                cmd.Parameters.AddWithValue("@email", email);
                
                try
                {
                    cmd.Connection = connect.conectar();
                    cmd.ExecuteNonQuery();
                    connect.desconectar();
                    this.mensagem = "Senha alterada com sucesso!!!";
                    existe = true;
                }
                catch (SqlException)
                {
                    this.mensagem = "Erro com banco de dados;";
                }
            }
            else
            {
                this.mensagem = "As senhas não corresondem!!!";
            }


            return mensagem;
        }
    }
}

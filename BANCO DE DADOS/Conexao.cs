using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Criptografia_Exemplo
{
    public class Conexao
    {
        SqlConnection connect = new SqlConnection();

        public Conexao()
        {
            connect.ConnectionString = "Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\andre.cini\\Documents\\Visual Studio 2008\\Projects\\Criptografia_Exemplo\\Criptografia_Exemplo\\ProjetoSQL.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
        }

        public SqlConnection conectar()
        {
            if (connect.State == System.Data.ConnectionState.Closed)
            {
                connect.Open();
            }

            return connect;
        }

        public void desconectar()
        {
            if (connect.State == System.Data.ConnectionState.Open)
            {
                connect.Close();
            }
        }
    }
}

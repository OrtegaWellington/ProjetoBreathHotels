using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoHotel
{
    class Conexao
    {

        public NpgsqlConnection getConexao()
        {
            string serverName = "127.0.0.1"; //localhost
            string port = "5432"; //porta
            string userName = "postgres"; //nome do user do banco
            string password = "postgres"; //senha do user do banco
            string databaseName = "postgres"; //nome do database

            NpgsqlConnection pgsqlConnection = null;
            string connString = String.Format("Server={0};Port={1};User Id={2};Password={3};Database={4};", serverName, port, userName, password, databaseName);

            pgsqlConnection = new NpgsqlConnection(connString);

            return pgsqlConnection;
        }

    }
}

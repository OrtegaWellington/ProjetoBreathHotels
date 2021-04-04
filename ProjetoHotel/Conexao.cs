using Npgsql;

namespace ProjetoHotel
{
    class Conexao
    {

        public NpgsqlConnection getConexao()
        {
            NpgsqlConnection pgsqlConnection = null;
            string connString = "Server=127.0.0.1;Port=5432;User Id=postgres;Password=postgres;Database=postgres;";

            pgsqlConnection = new NpgsqlConnection(connString);

            return pgsqlConnection;
        }
    }
}

using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoHotel
{
    class Usuario
    {

        private int id;
        private string nomeuser;
        private string senha;


        public int Id
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }

        public string Nomeuser
        {
            get
            {
                return this.nomeuser;
            }
            set
            {
                this.nomeuser = value;
            }
        }

        public string Senha
        {
            get
            {
                return this.senha;
            }
            set
            {
                this.senha = value;
            }
        }

        public bool logar()
        {

            NpgsqlConnection pgsqlConnection = null; 
            try
            {
                Conexao objconexao = new Conexao();

                pgsqlConnection = objconexao.getConexao();
                pgsqlConnection.Open();

                string sql = ""; //monta o comando SQL

                sql = "SELECT * FROM login WHERE username ='" + this.nomeuser + "' and userpassword='" + this.senha + "' LIMIT 1;";

                NpgsqlCommand cmd = new NpgsqlCommand(sql, pgsqlConnection);

                NpgsqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {

                    if (this.nomeuser == dr["username"].ToString() && (this.senha) == dr["userpassword"].ToString())
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }

                else
                {
                    return false;
                }
            }

            catch (Exception ex)
            {
                return false;
            }

            finally
            {
                pgsqlConnection.Close();
            }
        }
    }
}

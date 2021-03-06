using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoHotel
{
    class Cls_Login
    {        
        private string nomeuser;
        private string senha;        

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
                Cls_Conexao objconexao = new Cls_Conexao();

                pgsqlConnection = objconexao.getConexao();
                pgsqlConnection.Open();

                string sql = "SELECT * FROM login WHERE username ='" + this.nomeuser + "' and userpassword='" + this.senha + "' and ativo= 1 LIMIT 1;"; //monta o comando SQL

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
            finally
            {
                pgsqlConnection.Close();
            }
        }
    }
}
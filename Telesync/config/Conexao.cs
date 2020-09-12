using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Telesync.config
{
    class Conexao
    {
        MySqlConnection conexao = new MySqlConnection();

        public Conexao()
        {
            conexao.ConnectionString = ("Server=localhost;Database=bd_telesync;Uid=root;Pwd=;");
        }

        public MySqlConnection conectar()
        {
            if (conexao.State == ConnectionState.Closed)
            {
                conexao.Open();
            }
            return conexao;
        }
        public void desconectar()
        {
            if (conexao.State == ConnectionState.Open)
            {
                conexao.Close();
            }
        }
    }
}

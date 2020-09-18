using System.Data;
using MySql.Data.MySqlClient;

namespace Telesync.config
{
    public class Conexao
    {
        private MySqlConnection conexao = new MySqlConnection();

        public Conexao() => conexao.ConnectionString = ("Server=localhost;Database=bd_telesync;Uid=root;Pwd=;");

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

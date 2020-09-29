using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telesync.config;
using Telesync.models;

namespace Telesync.repositories
{
    public class LoginDao
    {
        private static Conexao _conexao = new Conexao();
        private static MySqlCommand comando = new MySqlCommand();

        public bool validarLogin(Login login)
        {
            comando.Parameters.Clear();

            comando.CommandText = "SELECT 1 FROM tlogin WHERE codLogin = @UsuarioId AND senha = @Senha";
            comando.Parameters.AddWithValue("@UsuarioId", login.usuarioId);
            comando.Parameters.AddWithValue("@Senha", login.senha);

            try
            {
                comando.Connection = _conexao.conectar();
                MySqlDataReader result = comando.ExecuteReader();
                bool hasRows = result.HasRows;
                _conexao.desconectar();
                return hasRows;
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.ToString());
                return false;
            }
        }
        public bool inserirLogin(Login login, int codPermissao)
        {
            comando.Parameters.Clear();

            comando.CommandText = "INSERT INTO TLogin (CODLOGIN, EMAIL, SENHA, CODPERMISSAO) VALUE (@CODLOGIN, @EMAIL, @SENHA, @CODPERMISSAO)";
            comando.Parameters.AddWithValue("@CODLOGIN", login.usuarioId);
            comando.Parameters.AddWithValue("@EMAIL", login.email);
            comando.Parameters.AddWithValue("@SENHA", login.senha);
            comando.Parameters.AddWithValue("@CODPERMISSAO", codPermissao);

            return rodarInsert();
        }

        private bool rodarInsert()
        {
            return rodarDml();
        }

        private bool rodarDml()
        {
            try
            {
                comando.Connection = _conexao.conectar();
                comando.ExecuteNonQuery();
                _conexao.desconectar();
                return true;
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.ToString(), "MySQL exception");
                return false;
            }
        }
    }

    
}

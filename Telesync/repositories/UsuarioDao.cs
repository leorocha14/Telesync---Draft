using MySql.Data.MySqlClient;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telesync.config;
using Telesync.models;

namespace Telesync.repositories
{
    public class UsuarioDao
    {
        private static Conexao _conexao = new Conexao();
        private static MySqlCommand comando = new MySqlCommand();
        private static readonly string CADASTRO_SUCESSO = "Cadastrado com Sucesso!";
        private static readonly string CADASTRO_ERRO = "Erro! Cadastro falhou devido a: ";

        public string inserirUsuario(Usuario usuario, Login login)
        {
            comando.CommandText = "INSERT INTO TCliente (CPF, NOME, NOMEMAE, SEXO, EMAIL, BAIRRO, CEP, LOGRADOURO, NUMERO, UF, CIDADE, COMPLEMENTO) VALUE (@CPF, @NOME, @NOMEMAE, @SEXO, @EMAIL, @BAIRRO, @CEP, @LOGRADOURO, @NUMERO, @UF, @CIDADE, @COMPLEMENTO)";

            comando.Parameters.AddWithValue("@CPF", usuario.cpf);
            comando.Parameters.AddWithValue("@NOME", usuario.nome);
            comando.Parameters.AddWithValue("@NOMEMAE", usuario.nomeMae);
            comando.Parameters.AddWithValue("@SEXO", usuario.sexo);
            comando.Parameters.AddWithValue("@EMAIL", usuario.email);
            comando.Parameters.AddWithValue("@BAIRRO", usuario.bairro);
            comando.Parameters.AddWithValue("@CEP", usuario.cep);
            comando.Parameters.AddWithValue("@LOGRADOURO", usuario.logradouro);
            comando.Parameters.AddWithValue("@NUMERO", usuario.numero);
            comando.Parameters.AddWithValue("@UF", usuario.uf);
            comando.Parameters.AddWithValue("@CIDADE", usuario.cidade);
            comando.Parameters.AddWithValue("@COMPLEMENTO", usuario.complemento);

            try
            {
                comando.Connection = _conexao.conectar();
                comando.ExecuteNonQuery();
                inserirLogin(login, usuario.cpf);
                _conexao.desconectar();
                return CADASTRO_SUCESSO;
            }
            catch (MySqlException e)
            {
                return String.Concat(CADASTRO_ERRO, e.Message);
            }
        }
        private void inserirLogin(Login login, string cpf)
        {
            comando.CommandText = "INSERT INTO TLogin (LOGIN, SENHA, CPF_USUARIO) VALUE (@LOGIN, @SENHA, @CPF_USUARIO)";

            comando.Parameters.AddWithValue("@LOGIN", login.usuarioId);
            comando.Parameters.AddWithValue("@SENHA", login.senha);
            comando.Parameters.AddWithValue("@CPF_USUARIO", cpf);

            comando.ExecuteNonQuery();
        }
    }
}

using MySql.Data.MySqlClient;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telesync.config;
using Telesync.models;
using System.Windows.Forms;
using System.Collections;
using System.Runtime.Remoting.Messaging;

namespace Telesync.repositories
{
    public class UsuarioDao
    {
        private static Conexao _conexao = new Conexao();
        private static MySqlCommand comando = new MySqlCommand();
        private static readonly string OPERACAO_SUCESSO = "Operação realizada com Sucesso!";
        private static readonly string OPERACAO_ERRO = "Erro! A Operação falhou";

        public string inserirUsuario(Usuario usuario, Login login)
        {
            comando.Parameters.Clear();

            comando.CommandText = "INSERT INTO TCliente (CPF, NOME, NOME_MAE, SEXO, EMAIL, DT_NASC, BAIRRO, CEP, LOGRADOURO, NUMERO, UF, CIDADE, COMPLEMENTO) " +
                "VALUE (@CPF, @NOME, @NOMEMAE, @SEXO, @EMAIL, @DT_NASC, @BAIRRO, @CEP, @LOGRADOURO, @NUMERO, @UF, @CIDADE, @COMPLEMENTO)";

            comando.Parameters.AddWithValue("@CPF", usuario.cpf);
            comando.Parameters.AddWithValue("@NOME", usuario.nome);
            comando.Parameters.AddWithValue("@NOMEMAE", usuario.nomeMae);
            comando.Parameters.AddWithValue("@SEXO", usuario.sexo);
            comando.Parameters.AddWithValue("@EMAIL", usuario.email);
            comando.Parameters.AddWithValue("@DT_NASC", usuario.dtNasc);
            comando.Parameters.AddWithValue("@BAIRRO", usuario.bairro);
            comando.Parameters.AddWithValue("@CEP", usuario.cep);
            comando.Parameters.AddWithValue("@LOGRADOURO", usuario.logradouro);
            comando.Parameters.AddWithValue("@NUMERO", usuario.numero);
            comando.Parameters.AddWithValue("@UF", usuario.uf);
            comando.Parameters.AddWithValue("@CIDADE", usuario.cidade);
            comando.Parameters.AddWithValue("@COMPLEMENTO", usuario.complemento);

            var insertUsuario = rodarInsert();
            
            var insertLogin = inserirLogin(login, usuario.cpf);

            return insertUsuario && insertLogin ? OPERACAO_SUCESSO : OPERACAO_ERRO;
        }

        public Usuario encontrarUsuario(Login login)
        {
            comando.Parameters.Clear();

            comando.CommandText = "SELECT * FROM TCliente WHERE CPF = (SELECT CPF_USUARIO FROM TLogin WHERE login = @LOGIN)"; 

            comando.Parameters.AddWithValue("@LOGIN", login.usuarioId);

            return rodarSelect();
        }

        public string atualizarUsuario(Usuario usuario)
        {
            comando.Parameters.Clear();

            comando.CommandText = "UPDATE TCliente SET NOME = @NOME, SEXO = @SEXO, EMAIL = @EMAIL, BAIRRO = @BAIRRO, CEP = @CEP, LOGRADOURO = @LOGRADOURO, " +
                "NUMERO = @NUMERO, UF = @UF, CIDADE = @CIDADE, COMPLEMENTO = @COMPLEMENTO WHERE CPF = @CPF";

            comando.Parameters.AddWithValue("@CPF", usuario.cpf);
            comando.Parameters.AddWithValue("@NOME", usuario.nome);
            comando.Parameters.AddWithValue("@SEXO", usuario.sexo);
            comando.Parameters.AddWithValue("@EMAIL", usuario.email);
            comando.Parameters.AddWithValue("@BAIRRO", usuario.bairro);
            comando.Parameters.AddWithValue("@CEP", usuario.cep);
            comando.Parameters.AddWithValue("@LOGRADOURO", usuario.logradouro);
            comando.Parameters.AddWithValue("@NUMERO", usuario.numero);
            comando.Parameters.AddWithValue("@UF", usuario.uf);
            comando.Parameters.AddWithValue("@CIDADE", usuario.cidade);
            comando.Parameters.AddWithValue("@COMPLEMENTO", usuario.complemento);

            return rodarUpdate();
        }

        public string excluirUsuario(string cpf)
        {
            comando.Parameters.Clear();

            comando.CommandText = "DELETE FROM TCLIENTE WHERE CPF = @CPF";

            comando.Parameters.AddWithValue("@CPF", cpf);

            return rodarDelete();
        }

        private bool inserirLogin(Login login, string cpf)
        {
            comando.Parameters.Clear();

            comando.CommandText = "INSERT INTO TLogin (LOGIN, SENHA, CPF_USUARIO) VALUE (@LOGIN, @SENHA, @CPF_USUARIO)";

            comando.Parameters.AddWithValue("@LOGIN", login.usuarioId);
            comando.Parameters.AddWithValue("@SENHA", login.senha);
            comando.Parameters.AddWithValue("@CPF_USUARIO", cpf);

            return rodarInsert();
        }

        private string rodarDelete()
        {
            return rodarDml() ? OPERACAO_SUCESSO : OPERACAO_ERRO;
        }

        private string rodarUpdate()
        {
            return rodarDml() ? OPERACAO_SUCESSO : OPERACAO_ERRO;
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

        private Usuario rodarSelect()
        {
            try

            {
                comando.Connection = _conexao.conectar();

                var dr = comando.ExecuteReader();

                dr.Read();

                var cpf = Convert.ToString(dr["cpf"]);
                var nome = Convert.ToString(dr["nome"]);
                var nomeMae = Convert.ToString(dr["nome_mae"]);
                var sexo = Convert.ToString(dr["sexo"]);
                var email = Convert.ToString(dr["email"]);
                var dtNasc = Convert.ToDateTime(dr["dt_nasc"]);
                var bairro = Convert.ToString(dr["bairro"]);
                var cep = Convert.ToString(dr["cep"]);
                var logradouro = Convert.ToString(dr["logradouro"]);
                var numero = Convert.ToString(dr["numero"]);
                var uf = Convert.ToString(dr["uf"]);
                var cidade = Convert.ToString(dr["cidade"]);
                var complemento = Convert.ToString(dr["complemento"]);

                Usuario usuario = new Usuario(cpf, nome, nomeMae, sexo, email, dtNasc.ToString(), bairro, cep, logradouro, numero, uf, cidade, complemento);

                _conexao.desconectar();

                return usuario;

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return null;
            }
        }
    }
}

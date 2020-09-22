using MySql.Data.MySqlClient;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telesync.config;
using Telesync.models;
using System.Security.Cryptography;

namespace Telesync.repositories
{
    public class UsuarioDao
    {
        private static Conexao _conexao = new Conexao();
        private static MySqlCommand comando = new MySqlCommand();
        MySqlDataReader dr;
        private static readonly string OPERACAO_SUCESSO = "Operação realizada com Sucesso!";
        private static readonly string OPERACAO_ERRO = "Erro! Operação falhou devido a: ";

        public string inserirUsuario(Usuario usuario, Login login)
        {
            comando.Parameters.Clear();

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
                return OPERACAO_SUCESSO;
            }
            catch (MySqlException e)
            {
                return String.Concat(OPERACAO_ERRO, e.Message);
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

        public string excluirUsuario(string cpf)
        {
            comando.Parameters.Clear();

            comando.CommandText = "DELETE FROM TCLIENTE WHERE CPF = @CPF";

            comando.Parameters.AddWithValue("@CPF", cpf);

            try
            {
                comando.Connection = _conexao.conectar();
                comando.ExecuteNonQuery();
                _conexao.desconectar();
                return OPERACAO_SUCESSO;
            }
            catch (MySqlException e)
            {
                return String.Concat(OPERACAO_ERRO, e.Message);
            }
        }

        public string alterarSenha(string cpf, string novaSenha)
        {
            comando.Parameters.Clear();

            comando.CommandText = "UPDATE TLOGIN SET SENHA = @SENHA WHERE CPF_USUARIO = @CPF_USUARIO";

            comando.Parameters.AddWithValue("@CPF_USUARIO", cpf);
            comando.Parameters.AddWithValue("@SENHA", novaSenha);


            try
            {
                comando.Connection = _conexao.conectar();
                comando.ExecuteNonQuery();
                _conexao.desconectar();
                return OPERACAO_SUCESSO;
            }
            catch (MySqlException e)
            {
                return String.Concat(OPERACAO_ERRO, e.Message);
            }
        }
        public string inserirPedido(Pedido pedido)
        {
            comando.Parameters.Clear();

            comando.CommandText = "INSERT INTO TPEDIDO (NUMPEDIDO) VALUE (@NUMEROPEDIDO)";

            comando.Parameters.AddWithValue("@NUMEROPEDIDO", pedido.numPedido);
            try
            {
                comando.Connection = _conexao.conectar();
                comando.ExecuteNonQuery();
                _conexao.desconectar();
                return OPERACAO_SUCESSO;
            }
            catch (MySqlException e)
            {
                return String.Concat(OPERACAO_ERRO, e.Message);
            }

        }
        public string inserirPlanoCliente(PedidoCliente pedidoCliente)
        {
            comando.Parameters.Clear();

            comando.CommandText = "INSERT INTO TPEDIDO_CLIENTE (NUMPEDCLI, CPFCLIENTE, NUMPED, NOMEPLANO, DDD, NUMERO) VALUE (@NUMEROPEDCLIENTE, @CPFCLI, @NUMPED, @NOMEPLANO, @DDD, @NUMERO)";

            comando.Parameters.AddWithValue("@NUMEROPEDCLIENTE", pedidoCliente.numPedCli);
            comando.Parameters.AddWithValue("@CPFCLI", pedidoCliente.cpfCliente);
            comando.Parameters.AddWithValue("@NUMPED", pedidoCliente.numPed);
            comando.Parameters.AddWithValue("@NOMEPLANO", pedidoCliente.nomePlano);
            comando.Parameters.AddWithValue("@DDD", pedidoCliente.ddd);
            comando.Parameters.AddWithValue("@NUMERO", pedidoCliente.numero);
            try
            {
                comando.Connection = _conexao.conectar();
                comando.ExecuteNonQuery();
                _conexao.desconectar();
                return OPERACAO_SUCESSO;
            }
            catch (MySqlException e)
            {
                return String.Concat(OPERACAO_ERRO, e.Message);
            }
        }
        public bool verificarPlanoCliente(PedidoCliente pedidoCliente)
        {
            bool verifica;
            var cpf = "";
            var numPedido = "";
            comando.Parameters.Clear();

            comando.CommandText = "SELECT NUMPEDIDO, CPF FROM TCLIENTE JOIN TPEDIDO WHERE CPF = @CPFCLI AND NUMPEDIDO = @NUMPED";

            comando.Parameters.AddWithValue("@CPFCLI", pedidoCliente.cpfCliente);
            comando.Parameters.AddWithValue("NUMPED", pedidoCliente.numPed);
            try
            {
                comando.Connection = _conexao.conectar();

                dr = comando.ExecuteReader();
                
                while (dr.Read()){
                    cpf = "cpf".ToString();
                    numPedido = "numPedido".ToString();                   
                }
                if (cpf == pedidoCliente.cpfCliente && numPedido == pedidoCliente.numPed)
                {
                    verifica = true;
                }
                else
                {
                    verifica = false;
                }
                return verifica;
            }
            catch(MySqlException e)
            {
                throw e;
            }
        }
    }
}

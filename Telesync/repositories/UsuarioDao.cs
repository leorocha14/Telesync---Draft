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
        public string inserirVenda(Venda venda)
        {
            comando.Parameters.Clear();

            comando.CommandText = "INSERT INTO TVENDA (CODVENDA, QTDDPLANOS, DTVENDA, DTVENCIMENTO, VALORTOTAL, OBS) VALUE (@CODVENDA, @QTDDPLANOS, @DTVENDA, @DTVENCIMENTO, @VALORTOTAL, @OBS)";

            comando.Parameters.AddWithValue("@CODVENDA", venda.codVenda);
            comando.Parameters.AddWithValue("@QTDDPLANOS", venda.qtddPlanos);
            comando.Parameters.AddWithValue("@DTVENDA", venda.dtVenda);
            comando.Parameters.AddWithValue("@DTVENCIMENTO", venda.dtVencimento);
            comando.Parameters.AddWithValue("@VALORTOTAL", venda.valorTotal);
            comando.Parameters.AddWithValue("@OBS", venda.obs);
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
        public string inserirVendaCliente(VendaCliente vendaCliente)
        {
            comando.Parameters.Clear();

            comando.CommandText = "INSERT INTO TVENDACLIENTE (CODVENDACLI, CPFCLIENTE, CODVENDA, DDD, NUMERO, NUMCHIP) VALUE (@CODVENDACLI, @CPFCLIENTE, @CODVENDA, @DDD, @NUMERO, @NUMCHIP)";

            comando.Parameters.AddWithValue("@CODVENDACLI", vendaCliente.codVendaCli);
            comando.Parameters.AddWithValue("@CPFCLIENTE", vendaCliente.cpfCliente);
            comando.Parameters.AddWithValue("@CODVENDA", vendaCliente.codVenda);
            comando.Parameters.AddWithValue("@DDD", vendaCliente.ddd);
            comando.Parameters.AddWithValue("@NUMERO", vendaCliente.numero);
            comando.Parameters.AddWithValue("@NUMCHIP", vendaCliente.numChip);
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
        public void inserirVendaPlano(VendaPlano vendaPlano)
        {
            comando.Parameters.Clear();

            comando.CommandText = "INSERT INTO TVENDAPLANO (CODVENDAPLANO, CODPLANO, CODVENDA) VALUE (@CODVENDAPLANO, @CODPLANO, @CODVENDA)";

            comando.Parameters.AddWithValue("@CODVENDAPLANO", vendaPlano.codVendaPlano);
            comando.Parameters.AddWithValue("@CODPLANO", vendaPlano.codPlano);
            comando.Parameters.AddWithValue("@CODVENDA", vendaPlano.codVenda);
            try
            {
                comando.Connection = _conexao.conectar();
                comando.ExecuteNonQuery();
                _conexao.desconectar();
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }
        public string verificarValorPlano(Plano plano)
        {
            string valorPlano = "";
            comando.Parameters.Clear();

            comando.CommandText = "SELECT VALOR FROM TPLANO WHERE CODPLANO = @CODPLANO";

            comando.Parameters.AddWithValue("@CODPLANO", plano.codPlano);

            try
            {
                comando.Connection = _conexao.conectar();
                dr = comando.ExecuteReader();
                while (dr.Read())
                {
                    valorPlano = Convert.ToString(dr["valor"]);
                }
                dr.Close();
                return valorPlano;
            }
            catch(MySqlException e)
            {
                throw e;
            }          
        }
        public string verificarCodPlano(string nomePlano)
        {
            string codPlano = "";

            comando.Parameters.Clear();

            comando.CommandText = "SELECT CODPLANO FROM TPLANO WHERE NOMEPLANO = @NOMEPLANO";

            comando.Parameters.AddWithValue("@NOMEPLANO", nomePlano);

            try
            {
                comando.Connection = _conexao.conectar();
                dr = comando.ExecuteReader();
                while (dr.Read())
                {
                    codPlano = Convert.ToString(dr["codPlano"]);
                }
                dr.Close();
                return codPlano;
            }
            catch (MySqlException e)
            {
                throw e;
            }           
        }
        public bool verificarPlanoCliente(VendaCliente pedidoCliente)
        {
            bool verifica;
            var cpf = "";
            var numPedido = "";
            comando.Parameters.Clear();

            comando.CommandText = "SELECT CODVENDA, CPF FROM TCLIENTE JOIN TVENDA WHERE CPF = @CPFCLI AND CODVENDA = @CODVENDA";

            comando.Parameters.AddWithValue("@CPFCLI", pedidoCliente.cpfCliente);
            comando.Parameters.AddWithValue("NUMPED", pedidoCliente.codVenda);
            try
            {
                comando.Connection = _conexao.conectar();

                dr = comando.ExecuteReader();
                
                while (dr.Read()){
                    cpf = "cpf".ToString();
                    numPedido = "numPedido".ToString();                   
                }
                if (cpf == pedidoCliente.cpfCliente && numPedido == pedidoCliente.codVenda)
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

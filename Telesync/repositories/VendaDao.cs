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
    class VendaDao
    {
        private static Conexao _conexao = new Conexao();
        private static MySqlCommand comando = new MySqlCommand();
        private static readonly string OPERACAO_SUCESSO = "Operação realizada com Sucesso!";
        private static readonly string OPERACAO_ERRO = "Erro! A Operação falhou";


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

        private string rodarSelect(string nomeColuna)
        {
            try

            {
                comando.Connection = _conexao.conectar();

                var dr = comando.ExecuteReader();

                dr.Read();

                var retornoColuna = Convert.ToString(dr[nomeColuna]);

                dr.Close();

                return retornoColuna;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

                public string inserirVenda(Venda venda)
        {
            comando.Parameters.Clear();

            comando.CommandText = "INSERT INTO TVENDA (CODVENDA, CPFCLIENTE, CODFORMAPAG, QTDDPLANOS, DTVENDA, DTVENCIMENTO, VALORTOTAL, OBS) VALUE (@CODVENDA, @CPFCLIENTE, @CODFORMAPAG, @QTDDPLANOS, @DTVENDA, @DTVENCIMENTO, @VALORTOTAL, @OBS)";

            comando.Parameters.AddWithValue("@CODVENDA", venda.codVenda);
            comando.Parameters.AddWithValue("@CPFCLIENTE", venda.cpfCliente);
            comando.Parameters.AddWithValue("@CODFORMAPAG", venda.codFormaPagamento);
            comando.Parameters.AddWithValue("@QTDDPLANOS", venda.qtddPlanos);
            comando.Parameters.AddWithValue("@DTVENDA", venda.dtVenda);
            comando.Parameters.AddWithValue("@DTVENCIMENTO", venda.dtVencimento);
            comando.Parameters.AddWithValue("@VALORTOTAL", venda.valorTotal);
            comando.Parameters.AddWithValue("@OBS", venda.obs);

            return rodarInsert() ? OPERACAO_SUCESSO : OPERACAO_ERRO;

        }
        public string inserirVendaPlano(VendaPlano vendaPlano)
        {
            comando.Parameters.Clear();

            comando.CommandText = "INSERT INTO TVENDAPLANO (CODVENDAPLANO, CODPLANO, CODVENDA, DDD, NUMERO, NUMCHIP) VALUE (@CODVENDAPLANO, @CODPLANO, @CODVENDA, @DDD, @NUMERO, @NUMCHIP)";

            comando.Parameters.AddWithValue("@CODVENDAPLANO", vendaPlano.codVendaPlano);
            comando.Parameters.AddWithValue("@CODPLANO", vendaPlano.codPlano);
            comando.Parameters.AddWithValue("@CODVENDA", vendaPlano.codVenda);
            comando.Parameters.AddWithValue("@DDD", vendaPlano.ddd);
            comando.Parameters.AddWithValue("@NUMERO", vendaPlano.numero);
            comando.Parameters.AddWithValue("@NUMCHIP", vendaPlano.numChip);

            return rodarInsert() ? OPERACAO_SUCESSO : OPERACAO_ERRO;
        }
        public string verificarValorPlano(Plano plano)
        {
            comando.Parameters.Clear();

            comando.CommandText = "SELECT VALOR FROM TPLANO WHERE CODPLANO = @CODPLANO";

            comando.Parameters.AddWithValue("@CODPLANO", plano.codPlano);

            return rodarSelect("valor");

        }
        public string verificarCodPlano(string nomePlano)
        {           
            comando.Parameters.Clear();

            comando.CommandText = "SELECT CODPLANO FROM TPLANO WHERE NOMEPLANO = @NOMEPLANO";

            comando.Parameters.AddWithValue("@NOMEPLANO", nomePlano);

            return rodarSelect("codPlano");
        }
        public string verificarFormaPag(string formaPagamento)
        {

            comando.Parameters.Clear();

            comando.CommandText = "SELECT CODFORMAPAG FROM TFORMAPAGAMENTO WHERE FORMAPAGAMENTO = @FORMAPAGAMENTO";

            comando.Parameters.AddWithValue("@FORMAPAGAMENTO", formaPagamento);

            return rodarSelect("codFormaPag");
        }
    }
}

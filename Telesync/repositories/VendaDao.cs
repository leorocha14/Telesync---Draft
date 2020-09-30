using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
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
                _conexao.desconectar();

                return retornoColuna;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private VendaPlano rodarSelectVendaPlano()
        {
            try

            {
                comando.Connection = _conexao.conectar();

                var dr = comando.ExecuteReader();

                dr.Read();
                                
                var codPlano = Convert.ToString(dr["codPlano"]);
                var codVendaPlano = Convert.ToString(dr["codVendaPlano"]);
                var codVenda = Convert.ToString(dr["codVenda"]);
                var ddd = Convert.ToString(dr["ddd"]);
                var numero = Convert.ToString(dr["numero"]);
                var numeroChip = Convert.ToString(dr["numChip"]);

                VendaPlano vendaPlano = new VendaPlano(codPlano, codVendaPlano, codVenda, ddd, numero, numeroChip);

                dr.Close();
                _conexao.desconectar();

                return vendaPlano;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return null;
            }
        }

        private Venda rodarSelectVenda()
        {
            try

            {
                comando.Connection = _conexao.conectar();

                var dr = comando.ExecuteReader();

                dr.Read();

                var codVenda = Convert.ToString(dr["codVenda"]);
                var cpfCliente = Convert.ToString(dr["cpfCliente"]);
                var codFormaPag = Convert.ToString(dr["codFormaPag"]);
                var qttdPlanos = Convert.ToString(dr["qtddPlanos"]);
                var dtVenda = Convert.ToDateTime(dr["dtVenda"]).ToString();
                var dtVencimento = Convert.ToDateTime(dr["dtVencimento"]).ToString();
                var valorTotal = Convert.ToString(dr["valorTotal"]);
                var codStatusPag = Convert.ToString(dr["codStatusPag"]);
                var obs = Convert.ToString(dr["obs"]);

                Venda venda = new Venda(codVenda, cpfCliente, codFormaPag, qttdPlanos, dtVenda, dtVencimento, obs, valorTotal, codStatusPag);

                dr.Close();
                _conexao.desconectar();

                return venda;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return null;
            }
        }

        private DataTable rodarSelectTodasVendas()
        {
            DataTable dt = new DataTable();
            try
            {
                comando.Connection = _conexao.conectar();

                dt.Columns.Add("codVenda", typeof(int));
                dt.Columns.Add("cpfCliente", typeof(int));
                dt.Columns.Add("codFormaPag", typeof(int));
                dt.Columns.Add("codStatusPag", typeof(int));
                dt.Columns.Add("dtVenda", typeof(string));
                dt.Columns.Add("dtVencimento", typeof(string));
                dt.Columns.Add("valorTotal", typeof(string));
                dt.Columns.Add("obs", typeof(string));

                MySqlDataAdapter dta = new MySqlDataAdapter(comando);

                dta.Fill(dt);

                _conexao.desconectar();

                return dt;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return null;
            }
        }
        private DataTable rodarSelectTodosVendaPlano()
        {
            DataTable dt = new DataTable();
            try
            {
                comando.Connection = _conexao.conectar();

                

                dt.Columns.Add("codVendaPlano", typeof(int));
                dt.Columns.Add("codVenda", typeof(int));
                dt.Columns.Add("ddd", typeof(string));
                dt.Columns.Add("numero", typeof(string));
                dt.Columns.Add("numChip", typeof(string));

                MySqlDataAdapter dta = new MySqlDataAdapter(comando);

                dta.Fill(dt);

                _conexao.desconectar();

                return dt;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return null;
            }
        }

        private Plano rodarSelectPlano()
        {
            try

            {
                comando.Connection = _conexao.conectar();

                var dr = comando.ExecuteReader();

                dr.Read();

                var codPlano = Convert.ToString(dr["codPlano"]);
                var NomePlano = Convert.ToString(dr["nomePlano"]);
                var ValorPlano = Convert.ToString(dr["valor"]);

                Plano plano = new Plano(codPlano, NomePlano, ValorPlano);

                dr.Close();
                _conexao.desconectar();

                return plano;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public bool campoVazio(Control controle, string campo, ErrorProvider erro)
        {
            erro.Clear();
            if (string.IsNullOrEmpty(controle.Text))
            {
                erro.SetError(controle, "Obrigatório!");
                MessageBox.Show("O " + campo + " é obrigatório!");
                controle.Focus();
                return true;
            }
            else
            {
                return false;
            }
        }

        public string inserirVenda(Venda venda)
        {
            comando.Parameters.Clear();

            comando.CommandText = "INSERT INTO TVENDA (CODVENDA, CPFCLIENTE, CODFORMAPAG, QTDDPLANOS, DTVENDA, DTVENCIMENTO, VALORTOTAL, CODSTATUSPAG, OBS) VALUE (@CODVENDA, @CPFCLIENTE, @CODFORMAPAG, @QTDDPLANOS, @DTVENDA, @DTVENCIMENTO, @VALORTOTAL, @CODSTATUSPAG, @OBS)";

            comando.Parameters.AddWithValue("@CODVENDA", venda.codVenda);
            comando.Parameters.AddWithValue("@CPFCLIENTE", venda.cpfCliente);
            comando.Parameters.AddWithValue("@CODFORMAPAG", venda.codFormaPagamento);
            comando.Parameters.AddWithValue("@QTDDPLANOS", venda.qtddPlanos);
            comando.Parameters.AddWithValue("@DTVENDA", venda.dtVenda);
            comando.Parameters.AddWithValue("@DTVENCIMENTO", venda.dtVencimento);
            comando.Parameters.AddWithValue("@VALORTOTAL", venda.valorTotal);
            comando.Parameters.AddWithValue("@CODSTATUSPAG", venda.codStatusPag);
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
        public string verificarCodPlano(string nomePlano)
        {           
            comando.Parameters.Clear();

            comando.CommandText = "SELECT CODPLANO FROM TPLANO WHERE NOMEPLANO = @NOMEPLANO";

            comando.Parameters.AddWithValue("@NOMEPLANO", nomePlano);

            return rodarSelect("codPlano");
        }

        public Plano encontrarPlano(string codPlano)
        {
            comando.Parameters.Clear();

            comando.CommandText = "SELECT * FROM TPLANO WHERE CODPLANO = @CODPLANO";

            comando.Parameters.AddWithValue("@CODPLANO", codPlano);

            return rodarSelectPlano();

        }

        public string verificarCodFormaPag(string formaPagamento)
        {

            comando.Parameters.Clear();

            comando.CommandText = "SELECT CODFORMAPAG FROM TFORMAPAGAMENTO WHERE FORMAPAGAMENTO = @FORMAPAGAMENTO";

            comando.Parameters.AddWithValue("@FORMAPAGAMENTO", formaPagamento);

            return rodarSelect("codFormaPag");
        }

        public string verificarFormaPag(string codFormaPag)
        {

            comando.Parameters.Clear();

            comando.CommandText = "SELECT FORMAPAGAMENTO FROM TFORMAPAGAMENTO WHERE CODFORMAPAG = @CODFORMAPAG";

            comando.Parameters.AddWithValue("@CODFORMAPAG", codFormaPag);

            return rodarSelect("formaPagamento");
        }

        public string alterarVendaPlano(VendaPlano vendaPlano)
        {
            comando.Parameters.Clear();

            comando.CommandText = "UPDATE TVENDAPLANO SET CODPLANO = @CODPLANO, DDD = @DDD, NUMERO = @NUMERO, NUMCHIP = @NUMCHIP WHERE CODVENDAPLANO = @CODVENDAPLANO";

            comando.Parameters.AddWithValue("@CODVENDAPLANO", vendaPlano.codVendaPlano);
            comando.Parameters.AddWithValue("@CODPLANO", vendaPlano.codPlano);
            comando.Parameters.AddWithValue("@DDD", vendaPlano.ddd);
            comando.Parameters.AddWithValue("@NUMERO", vendaPlano.numero);
            comando.Parameters.AddWithValue("@NUMCHIP", vendaPlano.numChip);

            return rodarUpdate();
        }

        public VendaPlano encontrarVendaPlano(string codVendaPlano)
        {
            comando.Parameters.Clear();

            comando.CommandText = "SELECT * FROM TVENDAPLANO WHERE CODVENDAPLANO = @CODVENDAPLANO";

            comando.Parameters.AddWithValue("@CODVENDAPLANO", codVendaPlano);

            return rodarSelectVendaPlano();
        }

        public string excluirVendaPlano(string codVendaPlano)
        {
            comando.Parameters.Clear();

            comando.CommandText = "DELETE FROM TVENDAPLANO WHERE CODVENDAPLANO = @CODVENDAPLANO";

            comando.Parameters.AddWithValue("@CODVENDAPLANO", codVendaPlano);

            return rodarDelete();
        }

        public Venda encontrarVenda(string codVenda)
        {
            comando.Parameters.Clear();

            comando.CommandText = "SELECT * FROM TVENDA WHERE CODVENDA = @CODVENDA";

            comando.Parameters.AddWithValue("@CODVENDA", codVenda);

            return rodarSelectVenda();
        }

        public DataTable encontrarTodasVendas(Usuario usuario, Login login)
        {
            comando.Parameters.Clear();

            comando.CommandText = "SELECT TV.* FROM TVENDA AS TV JOIN TCLIENTE AS TC JOIN TLOGIN AS TL ON TC.CODLOGIN = TL.CODLOGIN AND TV.CPFCLIENTE = TC.CPF WHERE TC.CODLOGIN = @CODLOGIN AND TC.CPF = @CPF";

            comando.Parameters.AddWithValue("@CODLOGIN", login.usuarioId);
            comando.Parameters.AddWithValue("@CPF", usuario.cpf);

            return rodarSelectTodasVendas();
        }

        public DataTable encontrarTodosVendaPlano(string codVenda)
        {
            comando.Parameters.Clear();

            comando.CommandText = "SELECT * FROM TVENDAPLANO WHERE CODVENDA = @CODVENDA";

            comando.Parameters.AddWithValue("@CODVENDA", codVenda);
            
            return rodarSelectTodosVendaPlano();
        }

        public string alterarVenda(string codVenda, string qtddPlanos, string valorTotal)
        {
            comando.Parameters.Clear();

            comando.CommandText = "UPDATE TVENDA SET QTDDPLANOS = @QTDDPLANOS, VALORTOTAL = @VALORTOTAL WHERE CODVENDA = @CODVENDA";

            comando.Parameters.AddWithValue("@CODVENDA", codVenda);
            comando.Parameters.AddWithValue("@QTDDPLANOS", qtddPlanos);
            comando.Parameters.AddWithValue("@VALORTOTAL", valorTotal);

            return rodarUpdate();
        }
        public string excluirVendaVazia(string codVenda)
        {
            comando.Parameters.Clear();

            comando.CommandText = "SELECT * FROM TVENDA WHERE CODVENDA = @CODVENDA";

            comando.Parameters.AddWithValue("@CODVENDA", codVenda);

            return rodarDelete();
        }
    }
}

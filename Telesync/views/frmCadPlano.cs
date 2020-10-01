using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telesync.models;
using Telesync.repositories;

namespace Telesync.views
{
    public partial class frmCadPlano : Form
    {
        private bool ehAlteracao = false;
        int contL = 0;
        int qtddePlan = 0;
        double valorTotal = 0;
        private static VendaDao vendaDao = new VendaDao();
        private static UsuarioDao usuarioDao = new UsuarioDao();

        public frmCadPlano(Login login, bool ehAlteracao)
        {
            InitializeComponent();
            this.ehAlteracao = ehAlteracao;

            preencherFormVenda(login);

        }
        private void preencherFormVenda(Login login)
        {
            dgvVendas.Columns.Add("CodVenda", "CodVenda");

            Usuario usuario = null;
            try
            {
                usuario = usuarioDao.encontrarUsuario(login);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Usuario não encontrado para " + login.usuarioId);
                Application.Restart();
            }
            if (ehAlteracao) {
                var dt = vendaDao.encontrarTodasVendas(usuario, login);

                dgvVendas.Rows.Add(dt.Rows.Count);

                btnGerarVenda.Enabled = false;
                gbAutoIncremento.Visible = true;
                gbDadosPlano.Visible = true;
                btnAdicionar.Visible = true;
                btnAlterar.Visible = true;
                btnExcluir.Visible = true;
                dgvPlanos.Visible = true;
                dgvVendas.Visible = true;

                for(var i = 0; i < dt.Rows.Count; i++)
                    dgvVendas.Rows[i].Cells[0].Value = dt.Rows[i]["codVenda"];
            }

            txtCPF.Text = usuario.cpf;
        }

        public static string gerarNumero(int x, int y)
        {
            string num = "";
            Random randNum = new Random();
            num = randNum.Next(x, y).ToString();
            return num;
        }

        private void frmCadPlano_Load(object sender, EventArgs e)
        {

            dgvPlanos.Columns.Add("CodPlano", "CodPlano");

            dgvPlanos.Columns.Add("CodVendaPlano", "CodVendaPlano");

            dgvPlanos.Columns.Add("Numero", "Numero");

            dgvPlanos.Columns.Add("DDD", "DDD");

            dgvPlanos.Columns.Add("NumChip", "NumChip");

            dgvPlanos.Rows.Add(Top);

            DateTime data = DateTime.Today;
            txtData.Text = data.ToString();
            txtDtVencimento.Text = data.AddMonths(1).ToString();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if(vendaDao.campoVazio(cbPlano, "Plano", errorProvider1))
            {
                return;
            }
            else if (vendaDao.campoVazio(txtDDD, "DDD", errorProvider1))
            {
                return;
            }

            txtNumero.Text = gerarNumero(99000000, 99999999);
                txtCodVendaPlano.Text = gerarNumero(20001, 30000);
                txtNumChip.Text = gerarNumero(100000000, 1000000000);

                qtddePlan += 1;


                VendaPlano vendaPlano = new VendaPlano(txtCodPlano.Text, txtCodVendaPlano.Text, txtCodVenda.Text, txtDDD.Text, txtNumero.Text, txtNumChip.Text);

                var resultado = vendaDao.inserirVendaPlano(vendaPlano);


                MessageBox.Show(resultado);


                dgvPlanos.Rows[contL].Cells[0].Value = txtCodVenda.Text;

                dgvPlanos.Rows[contL].Cells[0].Value = txtCodPlano.Text;
                dgvPlanos.Rows[contL].Cells[1].Value = txtCodVendaPlano.Text;
                dgvPlanos.Rows[contL].Cells[2].Value = txtNumero.Text;
                dgvPlanos.Rows[contL].Cells[3].Value = txtDDD.Text;
                dgvPlanos.Rows[contL].Cells[4].Value = txtNumChip.Text;
                contL += 1;

                txtQttdPlanos.Text = qtddePlan.ToString();

                valorTotal += Convert.ToDouble(txtValor.Text);

                txtValorTotal.Text = valorTotal.ToString();

                vendaDao.alterarVenda(txtCodVenda.Text, txtQttdPlanos.Text, txtValorTotal.Text);

            btnFinalizar.Visible = true;

        }

        private void dgvPlanos_CellContentClick(object sender, DataGridViewCellEventArgs e)

        {
            if (dgvPlanos.CurrentCell.ColumnIndex == 1)
            {
                var vendaPlano = vendaDao.encontrarVendaPlano(dgvPlanos.CurrentCell.Value.ToString());
                var plano = vendaDao.encontrarPlano(vendaPlano.codPlano);

                txtValor.Text = plano.valor;
                cbPlano.Text = plano.nomePlano;
                txtCodVendaPlano.Text = vendaPlano.codVendaPlano;
                txtCodPlano.Text = vendaPlano.codPlano;
                txtDDD.Text = vendaPlano.ddd;
                txtNumero.Text = vendaPlano.numero;
                txtNumChip.Text = vendaPlano.numChip;

            }
        }

        private void cbPlano_SelectedIndexChanged(object sender, EventArgs e)
        {      
            txtCodPlano.Text = vendaDao.verificarCodPlano(cbPlano.Text);

            var plano = vendaDao.encontrarPlano(txtCodPlano.Text);
            txtValor.Text = plano.valor;
        }

        private void cbFormaPag_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCodFormaPag.Text = vendaDao.verificarCodFormaPag(cbFormaPag.Text);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {      

            var venda = vendaDao.encontrarVenda(txtCodVenda.Text);
            if (venda.codStatusPag == "2" && qtddePlan > 0) 
            {
                var vendaPlanoVerifica = vendaDao.encontrarVendaPlano(txtCodVendaPlano.Text);
                var plano = vendaDao.encontrarPlano(vendaPlanoVerifica.codPlano);
                var valorPlano = plano.valor;

                valorTotal = (Convert.ToDouble(txtValorTotal.Text) - Convert.ToDouble(valorPlano));

                VendaPlano vendaPlano = new VendaPlano(txtCodPlano.Text, txtCodVendaPlano.Text, txtCodVenda.Text, txtDDD.Text, txtNumero.Text, txtNumChip.Text);

                var resultado = vendaDao.alterarVendaPlano(vendaPlano);

                dgvPlanos.Rows[dgvPlanos.CurrentRow.Index].Cells[0].Value = vendaPlano.codPlano;

                txtValorTotal.Text = (valorTotal + Convert.ToDouble(txtValor.Text)).ToString();

                vendaDao.alterarVenda(txtCodVenda.Text, txtQttdPlanos.Text, txtValorTotal.Text);

                MessageBox.Show(resultado);
            }else if(venda.codStatusPag == "1")
            {
                MessageBox.Show("Essa venda Já foi Paga, não é possivel alterar!");
            }
            else if (venda.codStatusPag == "3")
            {
                MessageBox.Show("Venda Suspensa, não é possivel alterar!");
            }
            else
            {
                MessageBox.Show("Não é possivel alterar, pois não há planos vinculado a essa venda");
            }
        }

        private void btnGerarVenda_Click(object sender, EventArgs e)
        {
            if(vendaDao.campoVazio(txtCPF, "CPF", errorProvider1))
            {
                return;
            }else if(vendaDao.campoVazio(cbFormaPag, "Forma de Pagamento", errorProvider1))
            {
                return;
            }

            if (string.IsNullOrEmpty(txtCodVenda.Text))
            {

                txtCodVenda.Text = gerarNumero(0, 10000);
                txtQttdPlanos.Text = "0";
                txtValorTotal.Text = "0";

                Venda venda = new Venda(txtCodVenda.Text, txtCPF.Text, txtCodFormaPag.Text, txtQttdPlanos.Text, txtData.Text, txtDtVencimento.Text, txtObs.Text, txtValorTotal.Text, "2");

                var resultado = vendaDao.inserirVenda(venda);
               
                txtCodVenda.ReadOnly = true;
                txtCPF.ReadOnly = true;
                btnAdicionar.Enabled = true;
                btnAlterar.Enabled = true;
                btnExcluir.Enabled = true;
                cbPlano.Enabled = true;
                txtDDD.ReadOnly = false;

                MessageBox.Show(resultado);

            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var qttdPlan = Convert.ToInt32(txtQttdPlanos.Text);
            var resultado = vendaDao.excluirVendaPlano(txtCodVendaPlano.Text);
            if(qttdPlan > 0)
            {          
                if (txtCodPlano.Text == "1")
                {
                    txtValorTotal.Text = (valorTotal - 300).ToString();
                    valorTotal -= 300;

                }
                else if (txtCodPlano.Text == "2")
                {
                    txtValorTotal.Text = (valorTotal - 100).ToString();
                    valorTotal -= 100;

                }
                else if (txtCodPlano.Text == "3")
                {
                    txtValorTotal.Text = (valorTotal - 120).ToString();
                    valorTotal -= 120;

                }
                else
                {
                    txtValorTotal.Text = (valorTotal - 150).ToString();
                    valorTotal -= 150;

                }

                txtQttdPlanos.Text = (qttdPlan - 1).ToString();

                dgvPlanos.Rows.RemoveAt(dgvPlanos.CurrentRow.Index);

                contL -= 1;

                vendaDao.alterarVenda(txtCodVenda.Text, txtQttdPlanos.Text, txtValorTotal.Text);

                MessageBox.Show(resultado);
            }
            else
            {
                MessageBox.Show("Não é possivel excluir devido a não haver planos");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodVenda.Text) == false)
            {
                var venda = vendaDao.encontrarVenda(txtCodVenda.Text);

                if (venda.qtddPlanos == "0" && venda.valorTotal == "0")
                {
                    var resultado = vendaDao.excluirVendaVazia(txtCodVenda.Text);

                    MessageBox.Show(resultado);

                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Existem planos vinculados a essa venda, delete todos para poder cancelar!");
                }
            }else
            {
                this.Dispose();
            }
        }

        private void dgvVendas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

            var venda = vendaDao.encontrarVenda(dgvVendas.CurrentCell.Value.ToString());

            valorTotal = Convert.ToDouble(venda.valorTotal);
            txtCodVenda.Text = venda.codVenda;
            txtCodFormaPag.Text = venda.codFormaPagamento;
            cbFormaPag.Text = vendaDao.verificarFormaPag(venda.codFormaPagamento);
            txtQttdPlanos.Text = venda.qtddPlanos;
            txtData.Text = venda.dtVenda;
            txtDtVencimento.Text = venda.dtVencimento;
            txtValorTotal.Text = venda.valorTotal;
            txtObs.Text = venda.obs;

            var dt = vendaDao.encontrarTodosVendaPlano(dgvVendas.CurrentCell.Value.ToString());

            for (var i = 0; i < dt.Rows.Count; i++)
            {
                dgvPlanos.Rows[i].Cells[0].Value = dt.Rows[i]["codPlano"];
                dgvPlanos.Rows[i].Cells[1].Value = dt.Rows[i]["codVendaPlano"];
                dgvPlanos.Rows[i].Cells[2].Value = dt.Rows[i]["numero"];
                dgvPlanos.Rows[i].Cells[3].Value = dt.Rows[i]["ddd"];
                dgvPlanos.Rows[i].Cells[4].Value = dt.Rows[i]["numChip"];
                contL += 1;
            }
            dt.Clear();

            btnAdicionar.Enabled = true;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            cbPlano.Enabled = true;
            txtDDD.ReadOnly = false;
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}

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
        int contL = 0;
        int contC = 0;
        int qtddePlan = 0;
        double valorTotal = 0;
        private static VendaDao vendaDao = new VendaDao();
        public frmCadPlano()
        {
            InitializeComponent();
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

            dgvPlanos.Columns.Add("CodVenda", "CodVenda");

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


                dgvPlanos.Rows[contL].Cells[contC].Value = txtCodVenda.Text;
                dgvPlanos.Rows[contL].Cells[contC + 1].Value = txtCodPlano.Text;
                dgvPlanos.Rows[contL].Cells[contC + 2].Value = txtCodVendaPlano.Text;
                dgvPlanos.Rows[contL].Cells[contC + 3].Value = txtNumero.Text;
                dgvPlanos.Rows[contL].Cells[contC + 4].Value = txtDDD.Text;
                dgvPlanos.Rows[contL].Cells[contC + 5].Value = txtNumChip.Text;
                contL += 1;

                txtQttdPlanos.Text = qtddePlan.ToString();

                valorTotal += Convert.ToDouble(txtValor.Text);

                txtValorTotal.Text = valorTotal.ToString();

                vendaDao.alterarVenda(txtCodVenda.Text, txtQttdPlanos.Text, txtValorTotal.Text);

        }

        private void dgvPlanos_CellContentClick(object sender, DataGridViewCellEventArgs e)

        {
            if (dgvPlanos.CurrentCell.ColumnIndex == 2)
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
            txtCodFormaPag.Text = vendaDao.verificarFormaPag(cbFormaPag.Text);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            var vendaPlanoVerifica = vendaDao.encontrarVendaPlano(txtCodVendaPlano.Text);
            var plano = vendaDao.encontrarPlano(vendaPlanoVerifica.codPlano);
            var valorPlano = plano.valor;

            var venda = vendaDao.encontrarVenda(txtCodVenda.Text);
            if (venda.codStatusPag == "2") 
            {

                valorTotal = (Convert.ToDouble(txtValorTotal.Text) - Convert.ToDouble(valorPlano));

                VendaPlano vendaPlano = new VendaPlano(txtCodPlano.Text, txtCodVendaPlano.Text, txtCodVenda.Text, txtDDD.Text, txtNumero.Text, txtNumChip.Text);

                var resultado = vendaDao.alterarVendaPlano(vendaPlano);

                txtValorTotal.Text = (valorTotal + Convert.ToDouble(txtValor.Text)).ToString();

                vendaDao.alterarVenda(txtCodVenda.Text, txtQttdPlanos.Text, txtValorTotal.Text);

                MessageBox.Show(resultado);
            }else if(venda.codStatusPag == "1")
            {
                MessageBox.Show("Essa venda Já foi Paga, não é possivel alterar!");
            }
            else
            {
                MessageBox.Show("Venda Suspensa, não é possivel alterar!");
            }
        }

        private void btnEncVenda_Click(object sender, EventArgs e)
        {
            if(vendaDao.campoVazio(txtCodVenda, "Código da Venda", errorProvider1))
            {
                return;
            }    

            var venda = vendaDao.encontrarVenda(txtCodVenda.Text);

            valorTotal = Convert.ToDouble(venda.valorTotal);
            txtCPF.Text = venda.cpfCliente;
            txtCodFormaPag.Text = venda.codFormaPagamento;
            txtQttdPlanos.Text = venda.codFormaPagamento;
            txtData.Text = venda.codFormaPagamento;
            txtDtVencimento.Text = venda.codFormaPagamento;
            txtValorTotal.Text = venda.valorTotal;
            txtObs.Text = venda.codFormaPagamento;

            var dt = vendaDao.encontrarTodosVendaPlano(txtCodVenda.Text);

            for(var i = 0; i < dt.Rows.Count; i++)
            {
                dgvPlanos.Rows[i].Cells[0].Value = dt.Rows[i]["codVenda"];
                dgvPlanos.Rows[i].Cells[1].Value = dt.Rows[i]["codPlano"];
                dgvPlanos.Rows[i].Cells[2].Value = dt.Rows[i]["codVendaPlano"];
                dgvPlanos.Rows[i].Cells[3].Value = dt.Rows[i]["numero"];
                dgvPlanos.Rows[i].Cells[4].Value = dt.Rows[i]["ddd"];
                dgvPlanos.Rows[i].Cells[5].Value = dt.Rows[i]["numChip"];
                contL += 1;
            }
            dt.Clear();

            txtCodVenda.ReadOnly = true;
            txtCPF.ReadOnly = true;
            btnAdicionar.Enabled = true;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            cbPlano.Enabled = true;
            txtDDD.ReadOnly = false;
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
            var valorTotal = Convert.ToInt32(txtValorTotal.Text);
            var resultado = vendaDao.excluirVendaPlano(txtCodVendaPlano.Text);

            if (txtCodPlano.Text == "1")
            {
                txtValorTotal.Text = (valorTotal - 300).ToString();

            }
            else if (txtCodPlano.Text == "2")
            {
                txtValorTotal.Text = (valorTotal - 100).ToString();

            }
            else if (txtCodPlano.Text == "3")
            {
                txtValorTotal.Text = (valorTotal - 120).ToString();

            }
            else
            {
                txtValorTotal.Text = (valorTotal - 150).ToString();

            }

            txtQttdPlanos.Text = (qttdPlan - 1).ToString();

            dgvPlanos.Rows.RemoveAt(dgvPlanos.CurrentRow.Index);

            contL -= 1;

            vendaDao.alterarVenda(txtCodVenda.Text, txtQttdPlanos.Text, txtValorTotal.Text);

            MessageBox.Show(resultado);
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
    }
}

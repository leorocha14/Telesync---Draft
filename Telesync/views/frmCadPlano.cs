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
            txtCodVenda.Text = gerarNumero(0, 10000);


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
            txtNumero.Text = gerarNumero(99000000, 99999999);
            txtCodVendaPlano.Text = gerarNumero(20001, 30000);
            txtNumChip.Text = gerarNumero(100000000, 1000000000);

            qtddePlan += 1;


            VendaPlano vendaPlano = new VendaPlano(txtCodPlano.Text, txtCodVendaPlano.Text, txtCodVenda.Text, txtDDD.Text, txtNumero.Text, txtNumChip.Text);

            var resultado = vendaDao.inserirVendaPlano(vendaPlano);


            MessageBox.Show(resultado);


            dgvPlanos.Rows[contL].Cells[contC].Value = txtCodVenda.Text;
            dgvPlanos.Rows[contL].Cells[contC+1].Value = txtCodVenda.Text;
            dgvPlanos.Rows[contL].Cells[contC+2].Value = txtCodVendaPlano.Text;
            dgvPlanos.Rows[contL].Cells[contC+3].Value = txtNumero.Text;
            dgvPlanos.Rows[contL].Cells[contC+4].Value = txtDDD.Text;
            dgvPlanos.Rows[contL].Cells[contC+5].Value = txtNumChip.Text;
            contL += 1;

            txtQttdPlanos.Text = qtddePlan.ToString();

            Plano plano = new Plano(txtCodPlano.Text);

            txtValor.Text = vendaDao.verificarValorPlano(plano);

            valorTotal += Convert.ToDouble(txtValor.Text);

            txtValorTotal.Text = valorTotal.ToString();

        }

        private void dgvPlanos_CellContentClick(object sender, DataGridViewCellEventArgs e)

        {
            if (dgvPlanos.CurrentCell.ColumnIndex == 2)
            {
                var vendaPlano = vendaDao.encontrarVendaPlano(dgvPlanos.CurrentCell.Value.ToString());

                txtCodVendaPlano.Text = vendaPlano.codVendaPlano;
                txtCodPlano.Text = vendaPlano.codPlano;
                txtDDD.Text = vendaPlano.ddd;
                txtNumero.Text = vendaPlano.numero;
                txtNumChip.Text = vendaPlano.numChip;
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            var resultado = vendaDao.alterarVenda(txtCodVenda.Text, txtQttdPlanos.Text, txtValorTotal.Text);

            MessageBox.Show(resultado);
        }

        private void cbPlano_SelectedIndexChanged(object sender, EventArgs e)
        {           
            txtCodPlano.Text = vendaDao.verificarCodPlano(cbPlano.Text);
        }

        private void cbFormaPag_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCodFormaPag.Text = vendaDao.verificarFormaPag(cbFormaPag.Text);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            var venda = vendaDao.encontrarVenda(txtCodVenda.Text);
            if (venda.codStatusPag == "2") 
            { 
                VendaPlano vendaPlano = new VendaPlano(txtCodPlano.Text, txtCodVendaPlano.Text, txtCodVenda.Text, txtDDD.Text, txtNumero.Text, txtNumChip.Text);

                var resultado = vendaDao.alterarVendaPlano(vendaPlano);

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
            var venda = vendaDao.encontrarVenda(txtCodVenda.Text);

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
                dgvPlanos.Rows[i].Cells[3].Value = dt.Rows[i]["ddd"];
                dgvPlanos.Rows[i].Cells[4].Value = dt.Rows[i]["numero"];
                dgvPlanos.Rows[i].Cells[5].Value = dt.Rows[i]["numChip"];
            }
            dt.Clear();
        }

        private void btnGerarVenda_Click(object sender, EventArgs e)
        {
            txtQttdPlanos.Text = "0";
            txtValorTotal.Text = "0";

            Venda venda = new Venda(txtCodVenda.Text, txtCPF.Text, txtCodFormaPag.Text, txtQttdPlanos.Text, txtData.Text, txtDtVencimento.Text, txtObs.Text, txtValorTotal.Text, "2");

            var resultado = vendaDao.inserirVenda(venda);

            MessageBox.Show(resultado);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var qttdPlan = Convert.ToInt32(txtQttdPlanos.Text);
            var valorTotal = Convert.ToInt32(txtValorTotal.Text);
            var resultado = vendaDao.excluirVendaPlano(txtCodVendaPlano.Text);

            dgvPlanos.Rows.RemoveAt(dgvPlanos.CurrentRow.Index);

            if(txtCodPlano.Text == "1")
            {
                txtValorTotal.Text = (valorTotal - 300).ToString();

            }else if(txtCodPlano.Text == "2")
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

            MessageBox.Show(resultado);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var venda = vendaDao.encontrarVenda(txtCodVenda.Text);
            if (venda.qtddPlanos == "0" && valorTotal == 0)
            {
                var resultado = vendaDao.excluirVendaVazia(txtCodVenda.Text);

                MessageBox.Show(resultado);
            }
            else
            {
                MessageBox.Show("Existem vinculados a essa venda, delete todos para poder cancelar!");
            }
        }
    }
}

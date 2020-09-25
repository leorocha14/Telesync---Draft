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
        private static UsuarioDao usuarioDao = new UsuarioDao();
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

            dgvPlanos.Columns.Add("Numero", "Numero");

            dgvPlanos.Columns.Add("DDD", "DDD");

            dgvPlanos.Columns.Add("CPF", "CPF");

            dgvPlanos.Columns.Add("NumChip", "NumChip");

            dgvPlanos.Rows.Add(Top);

            DateTime data = DateTime.Today;
            txtData.Text = data.ToString();
            txtDtVencimento.Text = data.AddMonths(1).ToString();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            txtNumero.Text = gerarNumero(99000000, 99999999);
            txtCodVendaCli.Text = gerarNumero(10001, 20000);
            txtCodVendaPlano.Text = gerarNumero(20001, 30000);
            txtNumChip.Text = gerarNumero(100000000, 1000000000);

            qtddePlan += 1;


            VendaPlano vendaPlano = new VendaPlano(txtCodPlano.Text, txtCodVendaPlano.Text, txtCodVenda.Text, txtDDD.Text, txtNumero.Text, txtNumChip.Text);

            var resultado = usuarioDao.inserirVendaPlano(vendaPlano);


            MessageBox.Show(resultado);


            dgvPlanos.Rows[contL].Cells[contC].Value = txtCodVenda.Text;
            dgvPlanos.Rows[contL].Cells[contC+1].Value = txtNumero.Text;
            dgvPlanos.Rows[contL].Cells[contC+2].Value = txtDDD.Text;
            dgvPlanos.Rows[contL].Cells[contC+4].Value = txtNumChip.Text;
            contL += 1;

            txtQttdPlanos.Text = qtddePlan.ToString();

            Plano plano = new Plano(txtCodPlano.Text);

            txtValor.Text = usuarioDao.verificarValorPlano(plano);

            valorTotal += Convert.ToDouble(txtValor.Text);

            txtValorTotal.Text = valorTotal.ToString();

        }

        private void dgvPlanos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            Venda venda = new Venda(txtCodVenda.Text, txtCPF.Text, txtCodFormaPag.Text, txtQttdPlanos.Text, txtData.Text, txtDtVencimento.Text, txtObs.Text, txtValorTotal.Text);

            var resultado = usuarioDao.inserirVenda(venda);

            MessageBox.Show(resultado);
        }

        private void cbPlano_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            txtCodPlano.Text = usuarioDao.verificarCodPlano(cbPlano.Text);
        }

        private void cbFormaPag_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCodFormaPag.Text = usuarioDao.verificarFormaPag(cbFormaPag.Text);
        }
    }
}

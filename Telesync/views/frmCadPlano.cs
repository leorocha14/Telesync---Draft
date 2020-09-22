using System;
using System.Collections.Generic;
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
        private static UsuarioDao usuarioDao = new UsuarioDao();
        public frmCadPlano()
        {
            InitializeComponent();
        }
        public static string gerarNumero(int x, int y)
        {
            string tel = "";
            Random randNum = new Random();
            tel = randNum.Next(x, y).ToString();
            return tel;
        }

        private void frmCadPlano_Load(object sender, EventArgs e)
        {
            txtNumPedido.Text = gerarNumero(0, 10000);


            dgvPlanos.Columns.Add("NumPedido", "NumPedido");

            dgvPlanos.Columns.Add("Numero", "Numero");

            dgvPlanos.Columns.Add("DDD", "DDD");

            dgvPlanos.Columns.Add("CPF", "CPF");

            dgvPlanos.Rows.Add(Top);
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            txtNumero.Text = gerarNumero(99000000, 99999999);
            txtNumPedCli.Text = gerarNumero(10001, 20001);

            VendaCliente pedidoCliente = new VendaCliente(txtNumPedCli.Text, txtCPF.Text, txtNumPedido.Text, cbPlano.Text, txtDDD.Text, txtNumero.Text);

            var resultado = usuarioDao.inserirPlanoCliente(pedidoCliente);

            MessageBox.Show(resultado);


            dgvPlanos.Rows[contL].Cells[contC].Value = txtNumPedido.Text;
            dgvPlanos.Rows[contL].Cells[contC+1].Value = txtNumero.Text;
            dgvPlanos.Rows[contL].Cells[contC+2].Value = txtDDD.Text;
            dgvPlanos.Rows[contL].Cells[contC+3].Value = txtCPF.Text;
            contL += 1;
            
        }

        private void dgvPlanos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            Venda pedido = new Venda(txtNumPedido.Text);

            var resultado = usuarioDao.inserirPedido(pedido);

            MessageBox.Show(resultado);
        }
    }
}

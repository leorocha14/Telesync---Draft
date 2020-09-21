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
    public partial class frmCadastroPlano : Form
    {
        private static UsuarioDao usuarioDao = new UsuarioDao();
        public frmCadastroPlano()
        {
            InitializeComponent();
        }

        public static string gerarNumero()
        {
            string tel = "";
            Random randNum = new Random();
            tel = randNum.Next().ToString();
            return tel;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            txtNumero.Text = gerarNumero();
            Pedido pedido = new Pedido(cbPlano.Text, txtDDD.Text, txtNumero.Text, txtCPF.Text);

            var resultado = usuarioDao.inserirPlano(pedido);

            MessageBox.Show(resultado);
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {

        }
    }
}

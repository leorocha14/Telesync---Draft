using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using Telesync.models;
using Telesync.repositories;

namespace Telesync
{
    public partial class frmCadClientes : Form
    {
        private static UsuarioDao usuarioDao = new UsuarioDao();

        public frmCadClientes()
        {
            InitializeComponent();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario(txtCPF.Text, txtNome.Text, txtNomemae.Text, txtSexo.Text, txtEmail.Text, txtBairro.Text, txtCEP.Text, txtLogradouro.Text, txtNumero.Text, txtCidade.Text, txtUF.Text, txtComplemento.Text);

            Login login = new Login(txtUsuarioId.Text, txtSenha.Text);

            var resultado = usuarioDao.inserirUsuario(usuario, login);

            MessageBox.Show(resultado);
        }

        private void btnPular_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnExcluir_Click_1(object sender, EventArgs e)
        {
            var resultado = usuarioDao.excluirUsuario(txtCPF.Text);
            MessageBox.Show(resultado);
        }
    }
}

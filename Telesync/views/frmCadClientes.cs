using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using Telesync.models;
using Telesync.repositories;

namespace Telesync
{
    public partial class frmCadClientes : Form
    {

        MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        string strSQL;
        public frmCadClientes()
        {
            InitializeComponent();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario(txtCPF.Text, txtNome.Text, txtNomemae.Text, txtSexo.Text, txtEmail.Text, txtBairro.Text, txtSenha.Text, txtCEP.Text, txtLogradouro.Text, txtNumero.Text, txtCidade.Text, txtUF.Text, txtComplemento.Text);

            UsuarioDao cadastrar = new UsuarioDao(usuario);
            MessageBox.Show(cadastrar.mensagem);
        }

        private void btnPular_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

using MySql.Data.MySqlClient;
using System;
using System.Security.AccessControl;
using System.Windows.Forms;
using Telesync.models;
using Telesync.repositories;

namespace Telesync
{
    public partial class frmCadClientes : Form
    {
        private static UsuarioDao usuarioDao = new UsuarioDao();
        private bool ehAlteracao = false;

        public frmCadClientes()
        {
            InitializeComponent();
        }

        public frmCadClientes(Login login)
        {
            InitializeComponent();
            preencherFormulario(login);
        }

        private void preencherFormulario(Login login)
        {
            ehAlteracao = true;
            try
            {
                var usuario = usuarioDao.encontrarUsuario(login);
                txtCPF.Text = usuario.cpf;
                txtNome.Text = usuario.nome;
                txtNomemae.Text = usuario.nomeMae;
                txtSexo.Text = usuario.sexo;
                txtEmail.Text = usuario.email;
                txtDtNasc.Text = usuario.dtNasc;
                txtBairro.Text = usuario.bairro;
                txtLogradouro.Text = usuario.logradouro;
                txtNumero.Text = usuario.numero;
                txtCidade.Text = usuario.cidade;
                txtUF.Text = usuario.uf;
                txtComplemento.Text = usuario.complemento;
                txtCEP.Text = usuario.cep;
                txtUsuarioId.Text = login.usuarioId;
                txtSenha.Text = login.senha;

                txtCPF.Enabled = false;
                txtDtNasc.Enabled = false;
                txtNomemae.Enabled = false;
                txtUsuarioId.Enabled = false;
                txtSenha.Enabled = false;
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Usuario não encontrado para " + login.usuarioId);
                Application.Restart();
            }

        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            string resultado;
            Usuario usuario = new Usuario(txtCPF.Text, txtNome.Text, txtNomemae.Text, txtSexo.Text, 
                txtEmail.Text, txtDtNasc.Text, txtBairro.Text, txtCEP.Text, txtLogradouro.Text, 
                txtNumero.Text, txtUF.Text, txtCidade.Text, txtComplemento.Text);

            Login login = new Login(txtUsuarioId.Text, txtSenha.Text);

            if (ehAlteracao)
            {
                resultado = usuarioDao.atualizarUsuario(usuario);
                this.Dispose();
            } 
            else
            {
                resultado = usuarioDao.inserirUsuario(usuario, login);
                limparForm();
            }

            MessageBox.Show(resultado);
        }

        private void limparForm()
        {
            foreach (Control control in this.Controls)
            {
                if (control.GetType().Equals(typeof(TextBox)))
                {
                    control.Text = String.Empty;
                }
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var resultado = usuarioDao.excluirUsuario(txtCPF.Text);
            MessageBox.Show(resultado);
            this.Dispose();
        }
    }
}

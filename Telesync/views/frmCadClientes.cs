using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Telesync.models;
using Telesync.repositories;

namespace Telesync
{
    public partial class frmCadClientes : Form
    {
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

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmCadClientes_Load(object sender, EventArgs e)
        {

        }
    }
}

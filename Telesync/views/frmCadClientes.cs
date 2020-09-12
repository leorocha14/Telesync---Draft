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
﻿using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

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
            try
            {
                conexao = new MySqlConnection("Server=localhost;Database=bd_telesync;Uid=root;Pwd=;");

                strSQL = "INSERT INTO CAD_CLIENTE (CPF, NOME, NOMEMAE, SEXO, EMAIL, BAIRRO, CEP, LOGRADOURO, NUMERO, UF, CIDADE, COMPLEMENTO, SENHA) VALUE (@CPF, @NOME, @NOMEMAE, @SEXO, @EMAIL, @BAIRRO, @CEP, @LOGRADOURO, @NUMERO, @UF, @CIDADE, @COMPLEMENTO, @SENHA)";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@CPF", txtCPF.Text);
                comando.Parameters.AddWithValue("@NOME", txtNome.Text);
                comando.Parameters.AddWithValue("@NOMEMAE", txtNomemae.Text);
                comando.Parameters.AddWithValue("@SEXO", txtSexo.Text);
                comando.Parameters.AddWithValue("@EMAIL", txtEmail.Text);
                comando.Parameters.AddWithValue("@BAIRRO", txtBairro.Text);
                comando.Parameters.AddWithValue("@CEP", txtCEP.Text);
                comando.Parameters.AddWithValue("@LOGRADOURO", txtLogradouro.Text);
                comando.Parameters.AddWithValue("@NUMERO", txtNumero.Text);
                comando.Parameters.AddWithValue("@UF", txtUF.Text);
                comando.Parameters.AddWithValue("@CIDADE", txtCidade.Text);
                comando.Parameters.AddWithValue("@COMPLEMENTO", txtComplemento.Text);
                comando.Parameters.AddWithValue("@SENHA", txtSenha.Text);

                conexao.Open();

                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }
        }

        private void btnPular_Click(object sender, EventArgs e)
        {

            this.Dispose();
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

using System;
using System.Windows.Forms;
using Telesync.models;
using Telesync.validations;
using Telesync.views;

namespace Telesync
{
    public partial class LoginForm : Form
    {
        private IValidation<LoginValidation> _validation;

        public LoginForm(IValidation<LoginValidation> validation)
        {
            InitializeComponent();
            this._validation = validation;
        }

        private void LogarBtn_Click(object sender, EventArgs e)
        {
            Login login = new Login(userTextBox.Text, null, pwdTextBox.Text); // null - email não é informado no login
            _validation.validar(login);
            var homePage = new HomePage(login);
            homePage.Show();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            frmCadClientes cadastroForm = new frmCadClientes();
            cadastroForm.Show();
        }

        private void btnAlterarSenha_Click(object sender, EventArgs e)
        {
            frmAlterarSenha alterarForm = new frmAlterarSenha();
            alterarForm.Show();
        }

        private void btnInserirPedido_Click(object sender, EventArgs e)
        {
            frmCadPlano cadPlanoForm = new frmCadPlano();
            cadPlanoForm.Show();
        }

        private void btnAlterarPedido_Click(object sender, EventArgs e)
        {
            frmCadPlano cadPlanoForm = new frmCadPlano();
            cadPlanoForm.Show();
        }
    }
}

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
            Login login = new Login(userTextBox.Text, pwdTextBox.Text);
            _validation.validar(login);
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
    }
}

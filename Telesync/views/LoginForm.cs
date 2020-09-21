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

        private void btnCadPlanos_Click(object sender, EventArgs e)
        {
            frmCadastroPlano cadPlanoForm = new frmCadastroPlano();
            cadPlanoForm.Show();
        }
    }
}

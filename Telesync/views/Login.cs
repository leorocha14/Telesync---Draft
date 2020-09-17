using System;
using System.Windows.Forms;
using Telesync.models;
using Telesync.validations;

namespace Telesync
{
    public partial class Login : Form
    {
        private IValidation<Usuario> _validation;

        public Login(IValidation<Usuario> validation)
        {
            InitializeComponent();
            this._validation = validation;
        }

        private void LogarBtn_Click(object sender, EventArgs e)
        {

            _validation.validar();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            frmCadClientes cadastroForm = new frmCadClientes();
            cadastroForm.Show();
        }
    }
}

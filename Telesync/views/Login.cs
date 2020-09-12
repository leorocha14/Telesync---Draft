using System;
using System.Windows.Forms;
using Telesync.validations;

namespace Telesync
{
    public partial class Login : Form
    {
        private IValidation _validation;

        public Login(IValidation validation)
        {
            InitializeComponent();
            this._validation = validation;
        }

        private void LogarBtn_Click(object sender, EventArgs e)
        {
            _validation.validate();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            frmCadClientes cadastroForm = new frmCadClientes();
            cadastroForm.Show();
        }
    }
}

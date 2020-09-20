using System;
using System.Windows.Forms;

namespace Telesync
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void LogarBtn_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            frmCadClientes cadastroForm = new frmCadClientes();
            cadastroForm.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telesync.models;

namespace Telesync.views
{
    public partial class HomePage : Form
    {
        private Login login;

        public HomePage(Login login)
        {
            this.login = login;
            InitializeComponent();
        }


        private void acessarPerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void verPerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void alterarCadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var cadastroCliente = new frmCadClientes(login, true); // true - eh uma alteracao
            cadastroCliente.Show();
        }

        private void canceleSeuPerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var cadastroCliente = new frmCadClientes(login, false); // false - eh uma exclusao
            cadastroCliente.Show();
        }
    }
}

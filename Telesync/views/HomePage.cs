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

        private void testeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var cadCliente = new frmCadClientes(login);
            cadCliente.Show();
        }
    }
}

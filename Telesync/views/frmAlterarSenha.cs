using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telesync.repositories;

namespace Telesync.views
{
    public partial class frmAlterarSenha : Form
    {
        private static UsuarioDao usuarioDao = new UsuarioDao();
        public frmAlterarSenha()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNovaSenha.Text == txtVerifica.Text)
            {
                var resultado = usuarioDao.alterarSenha(txtCPF.Text, txtNovaSenha.Text);
                MessageBox.Show(resultado);
            }
            else
            {
                MessageBox.Show("Foram encontrados valores diferentes nos campos");
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}

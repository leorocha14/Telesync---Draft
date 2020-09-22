using System;
using System.Diagnostics;
using System.Windows.Forms;
using Telesync.models;
using Telesync.repositories;

namespace Telesync.validations
{
    public class LoginValidation : AbstractValidaton
    {
        private static LoginDao loginDao = new LoginDao();

        public override void validar(Object login)
        {
            Debug.Assert(!login.Equals(typeof(Login)));
            var validacaoUsuario = loginDao.validarUsuario((Login)login);
            if (!validacaoUsuario)
            {
                MessageBox.Show("Usuário inválido");
                Application.Restart();
            }
        }
    }
}

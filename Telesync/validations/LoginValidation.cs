using System;
using System.Diagnostics;
using System.Windows.Forms;
using Telesync.models;
using Telesync.repositories;

namespace Telesync.validations
{
    public class LoginValidation : AbstractValidaton
    {
        public override void validar(Object login)
        {
            LoginDao loginDao = new LoginDao();
            Debug.Assert(!login.Equals(typeof(Login)));
            var validacaoUsuario = loginDao.validarUsuario((Login)login);
            Debug.Assert(validacaoUsuario);
            if (validacaoUsuario)
            {
                MessageBox.Show("Validado com sucesso!");
            }
        }
    }
}

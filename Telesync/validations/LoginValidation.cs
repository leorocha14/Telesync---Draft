using System;
using System.Diagnostics;
using System.Windows.Forms;
using Telesync.models;

namespace Telesync.validations
{
    public class LoginValidation : AbstractValidaton
    {
        public override void validar(Object login)
        {
            MessageBox.Show("Teste");
        }
    }
}

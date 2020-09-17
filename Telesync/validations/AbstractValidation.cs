using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telesync.validations
{
    public class AbstractValidation<T> : IValidation<T>
    {
        public void validar(T entity)
        {
            MessageBox.Show("Entidade não mapeada");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telesync.validations
{
    public abstract class AbstractValidaton
    {
        public abstract void validar(Object entityToBeValidated);
    }
}

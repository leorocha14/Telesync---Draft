using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telesync.factories;

namespace Telesync.validations
{
    public class GenericValidation<T> : IValidation<T>
    {
        private IValidationFactory<T> _factory;
        public GenericValidation(IValidationFactory<T> factory)
        {
            this._factory = factory;
        }

        public void validar(Object entityToBeValidated) 
        {
            var validator = _factory.build();
            validator.validar(entityToBeValidated);
        }

    }
}

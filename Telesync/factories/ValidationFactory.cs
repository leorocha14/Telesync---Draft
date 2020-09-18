using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telesync.validations;

namespace Telesync.factories
{
    public class ValidationFactory<T> : IValidationFactory<T>
    {
        private Type validatorType;

        public ValidationFactory(T entity)
        {
            validatorType = entity.GetType();
        }

        public AbstractValidaton build()
        {
            return getValidationInstance(validatorType);
        }

        private AbstractValidaton getValidationInstance(Type type)
        {
            if (typeof(LoginValidation).Equals(type))
            {
                return new LoginValidation();
            }
            return null;
        }
    }
}

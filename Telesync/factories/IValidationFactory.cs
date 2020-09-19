using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telesync.validations;

namespace Telesync.factories
{
    public interface IValidationFactory<T>
    {
        AbstractValidaton build();
    }
}

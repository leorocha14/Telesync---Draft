using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telesync.repositories;
using Telesync.validations;

namespace Telesync.config
{
    public class ApplicationModule : NinjectModule
    {
        public override void Load()
        {
            Bind(typeof(IValidation)).To(typeof(UserValidation));
        }
    }
}

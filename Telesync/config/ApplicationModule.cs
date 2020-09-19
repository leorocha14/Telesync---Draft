using Ninject.Modules;
using Telesync.factories;
using Telesync.repositories;
using Telesync.validations;

namespace Telesync.config
{
    public class ApplicationModule : NinjectModule
    {
        public override void Load()
        {
            Bind(typeof(IValidation<>)).To(typeof(GenericValidation<>));
            Bind(typeof(IValidationFactory<>)).To(typeof(ValidationFactory<>));
        }
    }
}

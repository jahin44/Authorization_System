using Authorization_System.API.Repositories;
using Authorization_System.API.Services;
using Autofac;

namespace Authorization_System.API
{
    public class AuthorizationDependencyModule : Module
    {

    protected override void Load(ContainerBuilder builder)
    {
        builder.RegisterType<ApplicationUserService>().As<IApplicationUserService>().InstancePerLifetimeScope();
        builder.RegisterType<UserOperationService>().As<IUserOperationService>().InstancePerLifetimeScope();
        builder.RegisterType<ApplicationUserRepository>().As<IApplicationUserRepository>().InstancePerLifetimeScope();

            base.Load(builder);
    }
}
}

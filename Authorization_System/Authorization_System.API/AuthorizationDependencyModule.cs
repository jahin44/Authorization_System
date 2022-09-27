using Authorization_System.API.Services;
using Autofac;

namespace Authorization_System.API
{
    public class AuthorizationDependencyModule : Module
    {

    protected override void Load(ContainerBuilder builder)
    {
        builder.RegisterType<ApplicationUserService>().As<IApplicationUserService>().InstancePerLifetimeScope();
        
        base.Load(builder);
    }
}
}

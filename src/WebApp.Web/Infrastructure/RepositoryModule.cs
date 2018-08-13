using System.Linq;
using System.Reflection;
using Autofac;

namespace WebApp.Web.Infrastructure
{
    public class RepositoryModule : Autofac.Module
    {
        public RepositoryModule()
        {
        }

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(Assembly.Load("WebApp.DAL"))
                   .Where(t => t.Name.EndsWith("Repository"))
                   .AsImplementedInterfaces()
                  .InstancePerLifetimeScope();
        }
    }
}
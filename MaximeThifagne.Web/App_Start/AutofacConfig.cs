
using Autofac;
using Autofac.Integration.Mvc;
using MaximeThifagne.Unity;
using System.Web.Mvc;

namespace MaximeThifagne.App_Start
{
    public static class AutofacConfig
    {
        public static void Register()
        {
            ContainerBuilder builder = new ContainerBuilder();
            
            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            MaximeThifagneRegistration.Register(builder);

            IContainer container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}
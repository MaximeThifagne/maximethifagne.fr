using Autofac;
using AutoMapper;
using MaximeThifagne.Entity.Mappings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace MaximeThifagne.Unity
{
    public static class MaximeThifagneRegistration
    {
        public static void Register(ContainerBuilder builder)
        {
            MaximeThifagneDataAcessRegister.Register(builder);
            FakeCodeToLoadEntityAssembly();

            AssemblyName[] assemblyNames = Assembly.GetExecutingAssembly().GetReferencedAssemblies();
            var assembliesTypes = assemblyNames
                .Where(a => a.Name.Equals("MaximeThifagne.Entity", StringComparison.OrdinalIgnoreCase))
                .SelectMany(an => Assembly.Load(an).GetTypes())
                .Where(p => typeof(Profile).IsAssignableFrom(p) && p.IsPublic && !p.IsAbstract)
                .Distinct();

            var autoMapperProfiles = assembliesTypes
                .Select(p => (Profile)Activator.CreateInstance(p)).ToList();

            builder.Register(ctx => new MapperConfiguration(cfg =>
            {
                foreach (var profile in autoMapperProfiles)
                {
                    cfg.AddProfile(profile);
                }
            }));

            //register your mapper
            builder.Register(c => c.Resolve<MapperConfiguration>().CreateMapper(c.Resolve)).As<IMapper>().InstancePerLifetimeScope();
        }

        private static void FakeCodeToLoadEntityAssembly()
        {
            var test = new MappingsConfiguration();
        }
    }
}

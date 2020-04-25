using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximeThifagne.Entity.Mappings
{
    public class MappingsConfiguration
    {
        public MappingsConfiguration()
        {
            var config = new MapperConfiguration(cfg => {
                cfg.AddProfile<UserMappings>();
                cfg.AddProfile<ArticleMappings>();
            });
        }
       
    }
}

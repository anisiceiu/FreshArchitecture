using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMCPayment.BLL.Mapping
{
   public class AutoMapperInitializer:Profile
    {
        public static void Initialize()
        {
            Mapper.Initialize(cfg => {
                cfg.AddProfile(new DomainToDBProfile());
                cfg.AddProfile(new DBToDomainProfile());
            });


        }
    }
}

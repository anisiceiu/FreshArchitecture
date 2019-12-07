using AutoMapper;
using SMCPayment.BLL.Models;
using SMCPAyment.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMCPayment.BLL.Mapping
{
  public  class DomainToDBProfile:Profile
    {

        public DomainToDBProfile()
        {
                CreateMap<BrandModel,brand>();
               CreateMap<CustomerModel, customer>();
        }
    }
}

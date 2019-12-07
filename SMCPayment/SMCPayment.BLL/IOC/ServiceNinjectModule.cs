using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMCPayment.BLL.IOC
{
   public class ServiceNinjectModule:NinjectModule
    {
        public override void Load()
        {
            Bind<IBrandService>().To<BrandService>();
            Bind<ICustomerService>().To<CustomerService>();
        }
    }
}

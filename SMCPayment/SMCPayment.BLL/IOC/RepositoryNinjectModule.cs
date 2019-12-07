using Ninject.Modules;
using SMCPAyment.DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMCPayment.BLL.IOC
{
   public class RepositoryNinjectModule:NinjectModule
    {
        public override void Load()
        {
            Bind<IBrandRepository>().To<BrandRepository>();
            Bind<ICustomerRepository>().To<CustomerRepository>();
        }
    }
}

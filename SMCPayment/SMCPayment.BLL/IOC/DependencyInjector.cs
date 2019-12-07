using Ninject;
using SMCPayment.BLL.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMCPayment.BLL.IOC
{
    public interface IDependencyInjector
    {
        void Inject(object Container);
    }
   public class DependencyInjector: IDependencyInjector
    {
       public void Inject(object Container)
        {
            var kernel = Container as IKernel;
            kernel.Load<RepositoryNinjectModule>();
            kernel.Load<ServiceNinjectModule>();
            AutoMapperInitializer.Initialize();
        }
    }
}

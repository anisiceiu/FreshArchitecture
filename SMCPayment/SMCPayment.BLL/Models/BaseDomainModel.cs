using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMCPayment.BLL.Models
{
    [Serializable]
   public abstract class BaseDomainModel <T>:IBaseDomainModel,IDomainModel,IDataModel where T:BaseDomainModel<T>
    {
        
    }
}

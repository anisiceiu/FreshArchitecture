using SMCPayment.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMCPayment.BLL.Services
{
   public interface IBusinessService<T,U> where T:IBaseDomainModel
    {
        IEnumerable<T> GetAll();
        T GetById(object Id);
        T Insert(T obj);
        void Delete(object Id);
        void Delete(T entityToDelete);
        T Update(T obj);
        void Save();
    }
}

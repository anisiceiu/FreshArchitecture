using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace SMCPayment.BLL
{
   public interface IService<T,U> where T:class where U:class
    {
        IEnumerable<U> GetAll();
        U GetById(object Id);
        U Insert(U obj);
        void Delete(object Id);
        U Update(U obj);
        void Save();
    }

    
    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using SMCPayment.BLL.Models;

namespace SMCPayment.BLL
{
   public interface IService<T,U> where T:class where U:class
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

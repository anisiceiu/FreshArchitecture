using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMCPAyment.DAL
{
    public interface IRepository<T>
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

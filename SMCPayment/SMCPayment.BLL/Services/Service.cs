using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using SMCPayment.BLL.Models;
using SMCPAyment.DAL;

namespace SMCPayment.BLL.Services
{
    public class Service<T, U>:IService<T,U> where T : class where U : class
    {
        public readonly IRepository<T> _repository;
        public Service(IRepository<T> repository)
        {
            _repository = repository;
                
        }

        

        public IEnumerable<U> GetAll()
        {

            return Mapper.Map <IEnumerable<U>>(_repository.GetAll());
        }
        public U GetById(object Id)
        {

            return Mapper.Map <U>(_repository.GetById(Id));
        }

        public U Insert(U obj)
        {

            return Mapper.Map<U>(_repository.Insert(Mapper.Map<T>(obj)));
        }

        public void  Delete(object Id)
        {

            _repository.Delete(Id);
        }
        public U Update(U obj)
        {

            return Mapper.Map<U>(_repository.Update(Mapper.Map<T>(obj)));
        }
        public void Save()
        {

            _repository.Save();
        }
    }
}

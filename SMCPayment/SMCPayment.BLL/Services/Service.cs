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
    public class Service<T,U>:IBusinessService<T,U> where T:IDomainModel
    {
        public readonly IRepository<U> _repository;
        public Service(IRepository<U> repository)
        {
            _repository = repository;
                
        } 

        public IEnumerable<T> GetAll()
        {

            return Mapper.Map <IEnumerable<T>>(_repository.GetAll());
        }
        public T GetById(object Id)
        {

            return Mapper.Map <T>(_repository.GetById(Id));
        }

        public T Insert(T obj)
        {

            return Mapper.Map<T>(_repository.Insert(Mapper.Map<U>(obj)));
        }

        public void  Delete(object Id)
        {

            _repository.Delete(Id);
        }
        public void Delete(T entity)
        {

           _repository.Delete(Mapper.Map<U>(entity));
        }
        public T Update(T obj)
        {

            return Mapper.Map<T>(_repository.Update(Mapper.Map<U>(obj)));
        }
        public void Save()
        {

            _repository.Save();
        }
    }
}

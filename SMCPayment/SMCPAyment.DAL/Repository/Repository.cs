using SMCPAyment.DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMCPAyment.DAL
{
    public class Repository<T> : IRepository<T> 
        where T : class
    
    {
        private readonly SMCPaymentEntities _dbContext;

        internal DbSet<T> DbSet;

        public Repository()
        {
            _dbContext = new SMCPaymentEntities();
            DbSet = _dbContext.Set<T>();
        }
        public IEnumerable<T> GetAll()
        {
            return _dbContext.Set<T>().AsNoTracking().AsEnumerable();
        }
        public T GetById(object id)
        {
            return DbSet.Find(id);
        }
        public T Insert(T obj)
        {
            DbSet.Add(obj);
            Save();
            return obj;
        }
        public void Delete(object id)
        {
            T entityToDelete = DbSet.Find(id);
            Delete(entityToDelete);
        }
        public void Delete(T entityToDelete)
        {
            if (_dbContext.Entry(entityToDelete).State == EntityState.Detached)
            {
                DbSet.Attach(entityToDelete);

            }
            DbSet.Remove(entityToDelete);
        }
        public T Update(T obj)
        {
            DbSet.Attach(obj);
            _dbContext.Entry(obj).State = EntityState.Modified;

            Save();
            return obj;
        }
        public void Save()
        {
            try
            {
                _dbContext.SaveChanges();

            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        System.Console.WriteLine("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);

                    }
                }
            }
        }
      

    }
}
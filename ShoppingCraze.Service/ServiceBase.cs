using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoppingCraze.Service.Interfaces;

namespace ShoppingCraze.Service
{
    public abstract class ServiceBase<T> : IService<T> where T:class
    {
        protected internal DbContext _context;

        public ServiceBase(DbContext context)
        {
            _context = context;
        }

        public bool Add(T entity)
        {
            try
            {
                _context.Entry<T>(entity).State = EntityState.Added;
                //_context.Set<T>().Add(entity);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Edit(T entity)
        {
            try
            {
                _context.Entry<T>(entity).State = EntityState.Modified;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public IEnumerable<T> GetAll()
        {
            try
            {
                return _context.Set<T>().ToList();
            }
            catch
            {
                return null;
            }
        }

        public T GetById<TKey>(TKey id)
        {
            try
            {
                return _context.Set<T>().Find(id);
            }
            catch
            {
                return null;
            }
        }

        public bool Remove<TKey>(TKey id)
        {
            try
            {
                T entity = _context.Set<T>().Find(id);
                _context.Entry<T>(entity).State = EntityState.Deleted;
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}

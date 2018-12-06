using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCraze.Service.Interfaces
{
    public interface IService<T>
    {
        bool Add(T entity);
        bool Edit(T entity);
        bool Remove<TKey>(TKey id);
        IEnumerable<T> GetAll();
        T GetById<TKey>(TKey id);
    }
}

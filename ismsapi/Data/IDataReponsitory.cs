using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ismsapi.Data
{
    public interface IDataReponsitory <T> where T: class
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(int id);
        Task<T> Create(T entity);
        Task<T> Update(T entity);
        bool Delete(T entity);
        bool DeleteById(int id);
        bool IsExists(T entity);

    }
}

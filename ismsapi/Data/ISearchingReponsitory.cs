using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ismsapi.Data
{
    public interface ISearchingReponsitory<T> where T: class
    {
        Task<IEnumerable<T>> GetByTitle(string title);
        Task<IEnumerable<T>> GetByCategoryId(int id);
        Task<IEnumerable<T>> GetByStatus(string status);
        Task<IEnumerable<T>> GetByStatusId(int statusId);
    }
}

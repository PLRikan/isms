using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ismsapi.Data
{
    public interface IPaginationReponsitory<T>: IDataReponsitory<T> where T: class
    {
        Task<IEnumerable<T>> GetAll(int page);
        Task<int> CountAllPage();
        void UpdatePageItem(int itemCount);
    }
}

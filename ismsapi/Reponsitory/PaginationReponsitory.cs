using ismsapi.Data;
using ismsapi.Options;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ismsapi.Reponsitory
{
    public class PaginationReponsitory<T> : DataReponsitory<T>, IPaginationReponsitory<T> where T : class
    {
        protected int pageItems ;
        public PaginationReponsitory(IOptionsMonitor<PaginOption> option, DataContext context) : base(context)
        {
            pageItems = option.CurrentValue.pageCount;
        }
        public virtual async Task<int> CountAllPage()
        {
            if (table.Count() > 0)
                return await table.CountAsync() / pageItems + 1;
            return 0;
        }

        public virtual async Task<IEnumerable<T>> GetAll(int page)
        {
            if (table.Count() > 0)
                return await table.Skip(pageItems * (page - 1)).Take(pageItems).ToListAsync();
            return new List<T>();
        }

        public void UpdatePageItem(int itemCount)
        {
            pageItems = itemCount;
        }
    }
}

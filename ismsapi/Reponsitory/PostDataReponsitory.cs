using ismsapi.Data;
using ismsapi.Models;
using ismsapi.Options;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ismsapi.Reponsitory
{
    public class PostDataReponsitory : PaginationReponsitory<Post>, IDatingReponsitory<Post>
    {
        public PostDataReponsitory(IOptionsMonitor<PaginOption> option, DataContext context) : base(option,context)
        {
            table = context.Set<Post>();
        }

        public async Task<IEnumerable<Post>> GetByDate(DateTime from, DateTime to)
        {
            return await table.Where(x => x.DateModify >= from && x.DateModify <= to).ToListAsync();
        }

        public async Task<IEnumerable<Post>> GetByTitle(string title)
        {
            return await table.Where(x => x.Title.Contains(title)).ToListAsync();
        }
    }
}

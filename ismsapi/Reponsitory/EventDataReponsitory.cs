using ismsapi.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ismsapi.Models;
using ismsapi.Options;
using Microsoft.Extensions.Options;
using Microsoft.EntityFrameworkCore;

namespace ismsapi.Reponsitory
{
    public class EventDataReponsitory : PaginationReponsitory<Event>, IDatingReponsitory<Event>, 
        ISearchingReponsitory<Event>
    {
        public EventDataReponsitory(IOptionsMonitor<PaginOption> option,DataContext context) : base(option,context)
        {
            table = _context.Set<Event>();
        }

        public override async Task<IEnumerable<Event>> GetAll()
        {
            return await table.Include(x=>x.EventStatus).ToListAsync();
        }

        public Task<IEnumerable<Event>> GetByCategoryId(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Event>> GetByDate(DateTime from, DateTime to)
        {
            return await table.Where(x => x.DateStart <= from && x.DateEnd >= to)
                .Include(x=>x.EventStatus).ToListAsync();
        }

        public async Task<IEnumerable<Event>> GetByStatus(string status)
        {
            return await table.Include(x => x.EventStatus).Where(e => e.EventStatus.Status.Equals(status)).ToListAsync();
        }

        public async Task<IEnumerable<Event>> GetByStatusId(int statusId)
        {
            return await table.Where(e => e.EventStatusId == statusId).ToListAsync();
        }

        public async Task<IEnumerable<Event>> GetByTitle(string title)
        {
            return await table.Where(x => x.Name.Contains(title))
                .Include(x=>x.EventStatus)
                .ToListAsync();
        }

        public Event GetNearestEvent()
        {
            return table.FirstOrDefault(x => x.DateStart >= DateTime.Now);
        }
    }
}

using ismsapi.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ismsapi.Reponsitory
{
    public class DataReponsitory<T> : IDataReponsitory<T> where T : class
    {
        protected DataContext _context;
        protected DbSet<T> table;

        public DataReponsitory(DataContext context)
        {
            _context = context;
            table = _context.Set<T>();
        }

        public virtual async Task<T> Create(T entity)
        {
            await table.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public virtual bool Delete(T entity)
        {
            table.Remove(entity);
            return _context.SaveChanges() > 0;
        }

        public virtual bool DeleteById(int Id)
        {
            var entity = table.Find(Id);
            if (entity == null) return false;
            return Delete(entity);
        }

        public virtual async Task<IEnumerable<T>> GetAll()
        {
            return await table.ToListAsync();
        }

        public virtual async Task<T> GetById(int Id)
        {
            return await table.FindAsync(Id);
        }

        public virtual bool IsExists(T entity)
        {
            return table.Find(entity) != null;
        }

        public virtual async Task<T> Update(T entity)
        {
            table.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return entity;
        }
    }
}

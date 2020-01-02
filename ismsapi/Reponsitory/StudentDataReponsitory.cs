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
    public class StudentDataReponsitory : PaginationReponsitory<Student>
    {
        public StudentDataReponsitory(IOptionsMonitor<PaginOption> option, DataContext context) : base(option, context)
        {
            table = _context.Set<Student>();
        }

        public override async Task<IEnumerable<Student>> GetAll()
        {
            return await table.Include(x => x.Faculty)
                                .Include(x => x.MajorStudent)
                                .Include(x => x.StudyStatus)
                                .Include(x => x.BankAccount)
                                .ThenInclude(x=>x.TutionStatusNavigation)
                                .ToListAsync();
        }

        public override async Task<Student> GetById(int id)
        {
            return await table.Include(x => x.Faculty)
                                .Include(x => x.MajorStudent)
                                .Include(x => x.StudyStatus)
                                .Include(x => x.EducateType)
                                .Include(x => x.BankAccount)
                                .ThenInclude(x => x.TutionStatusNavigation)
                                .Where(x => x.Id == id)
                                .FirstOrDefaultAsync();
        }
    }
}
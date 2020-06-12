using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WithTeachers.Data
{
    /// <summary>
    /// CRUD for Class
    /// </summary>
    public class ClassService
    {
        private readonly ApplicationDbContext _context;

        public ClassService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<int>> ReadYearsAsync(ApplicationUser user)
            =>  await _context.Classes.Where(x => x.User == user).OrderByDescending(x => x.Year).GroupBy(x => x.Year).Select(grouping => grouping.Key).ToListAsync();

        public async Task<Class> CreateAsync(Class cl)
        {
            _context.Classes.Add(cl);
            await _context.SaveChangesAsync();
            return cl;
        }

        public async Task<Class> ReadAsync(int id) 
            => await _context.Classes.SingleOrDefaultAsync(x => x.ClassId == id);

        public async Task<List<Class>> ReadAllAsync()
            => await _context.Classes.ToListAsync();

        public async Task<List<Class>> ReadAllAsync(ApplicationUser user)
            => await _context.Classes.Where(x => x.User == user).ToListAsync();

        public async Task<List<Class>> ReadAllAsync(ApplicationUser user, int year)
            => await _context.Classes.Where(x => x.User == user && x.Year == year).ToListAsync();

        public async Task<Class> UpdateAsync(Class cl)
        {
            Class classExists = await _context.Classes.SingleOrDefaultAsync(x => x.ClassId == cl.ClassId);
            if (classExists != null)
            {
                _context.Classes.Update(cl);
                await _context.SaveChangesAsync();
            }

            return cl;
        }

        public async Task Delete(Class cl)
        {
            Class classExists = await _context.Classes.SingleOrDefaultAsync(x => x.ClassId == cl.ClassId);
            if (classExists != null)
            {
                _context.Classes.Remove(cl);
                await _context.SaveChangesAsync();
            }
        }
    }
}
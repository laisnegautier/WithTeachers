using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WithTeachers.Data
{
    public class CourseDocumentService
    {
        private readonly ApplicationDbContext _context;

        public CourseDocumentService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task CreateAsync(CourseDocument courseDocument)
        {
            _context.CourseDocuments.Add(courseDocument);
            await _context.SaveChangesAsync();
        }
    }
}

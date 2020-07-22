using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace WithTeachers.Data
{
    public class CourseDocumentService
    {
        [Inject]
        private ApplicationDbContext Context { get; }

        public CourseDocumentService(ApplicationDbContext context)
            => Context = context;

        public async Task CreateAsync(CourseDocument courseDocument)
        {
            Context.CourseDocuments.Add(courseDocument);
            await Context.SaveChangesAsync();
        }

        public async Task UpdateAsync(CourseDocument courseDocument)
        {
            Context.CourseDocuments.Update(courseDocument);
            await Context.SaveChangesAsync();
        }
    }
}
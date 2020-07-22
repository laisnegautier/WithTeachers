using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace WithTeachers.Data
{
    public class CourseDocumentService
    {
        [Inject]
        private ApplicationDbContext Context { get; }

        public CourseDocumentService(ApplicationDbContext context)
            => Context = context;

        public async Task CreateAsync(CourseDocument document)
        {
            Context.CourseDocuments.Add(document);
            await Context.SaveChangesAsync();
        }

        public async Task UpdateAsync(CourseDocument document)
        {
            Context.CourseDocuments.Update(document);
            await Context.SaveChangesAsync();
        }

        public async Task DeleteAsync(CourseDocument document)
        {
            CourseDocument courseExists = await Context.CourseDocuments.SingleOrDefaultAsync(x => x.CourseDocumentId == document.CourseDocumentId);
            if (courseExists != null)
            {
                Context.CourseDocuments.Remove(document);
                await Context.SaveChangesAsync();
            }
        }
    }
}
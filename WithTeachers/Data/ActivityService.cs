using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WithTeachers.Data
{
    public class ActivityService
    {
        private readonly ApplicationDbContext _context;

        public ActivityService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Activity> CreateAsync(Activity activity)
        {
            _context.Activities.Add(activity);
            await _context.SaveChangesAsync();
            return activity;
        }

        public async Task<List<Activity>> ReadAllAsync(Week week)
            => await _context.Activities.OrderByDescending(x => x.ScheduledFor).Where(x => x.ScheduledFor > week.First() && x.ScheduledFor < week.Last()).ToListAsync();

        public async Task<Activity> UpdateAsync(Activity activity)
        {
            Activity activityExists = await _context.Activities.SingleOrDefaultAsync(x => x.ActivityId == activity.ActivityId);
            if (activityExists != null)
            {
                _context.Activities.Update(activity);
                await _context.SaveChangesAsync();
            }

            return activity;
        }
    }
}
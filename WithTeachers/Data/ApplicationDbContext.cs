using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WithTeachers.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Activity> Activities { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseDocument> CourseDocuments { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Videoconference> Videoconferences { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Class>().HasData(GetClasses());
            base.OnModelCreating(modelBuilder);
        }

        #region Seed

        private List<Class> GetClasses()
        {
            return new List<Class>
            {
                new Class { ClassId = 1, Year = 2013 },
                new Class { ClassId = 2, Year = 2015 },
                new Class { ClassId = 3, Year = 2011 },
                new Class { ClassId = 4, Year = 1984 },
                new Class { ClassId = 5, Year = 1700 }
            };
        }

        #endregion Seed
    }
}
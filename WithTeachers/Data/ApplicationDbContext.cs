using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Class>().HasData(GetClasses());
            //modelBuilder.Entity<Videoconference>().HasData(GetVideoconferences());
            base.OnModelCreating(modelBuilder);
        }

        #region Seed

        private List<Class> GetClasses()
        {
            return new List<Class>
            {
                new Class { ClassId = 1, Name = "3A", Year = 2013 },
                new Class { ClassId = 2, Name = "6B", Year = 2015 },
                new Class { ClassId = 3, Name = "6C", Year = 2011 },
                new Class { ClassId = 4, Name = "5D", Year = 1984 },
                new Class { ClassId = 5, Name = "4A", Year = 1700 }
            };
        }

        //private List<Videoconference> GetVideoconferences()
        //{
        //    return new List<Videoconference>
        //    {
        //        new Videoconference { VideoconferenceId = 1, Title = "3A", Password = "", Ongoing = true, CreationDate = new DateTime("28/07/2020), UserId = "f4e22dd9-48f0-4dcd-8ccf-c5e6d83635ae" },
        //    };
        //}

        #endregion Seed
    }
}
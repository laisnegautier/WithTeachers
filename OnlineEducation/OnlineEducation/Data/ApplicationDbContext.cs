using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OnlineEducation.Data;
using OnlineEducation.Data.Models;

namespace OnlineEducation.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Activity> Activities { get; set; }
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
            modelBuilder.Entity<Videoconference>().HasData(GetVideoconferences());
            base.OnModelCreating(modelBuilder);
        }

        #region Seed

        private List<Videoconference> GetVideoconferences()
        {
            return new List<Videoconference>
            {
                new Videoconference
                {
                    ActivityId = 1,
                    Title = "Course of Mathematics",
                    Description = "You have to follow now",
                    ScheduledFor = DateTime.Now,
                    TimeSpan = new TimeSpan(2,30,0),
                    IsCompleted = false,
                    IsOngoing = true,
                    CreationDate = new DateTime(2020,3,24,4,45,19),
                    UserId = "5925d79e-5ed1-4e19-ae1f-8ef0e4474cad",
                    RoomId = "course-of-mathXBZ",
                    Password = "SOIT"
                },
                new Videoconference
                {
                    ActivityId = 2,
                    Title = "Video already passed",
                    Description = "Goodbye Ornald",
                    ScheduledFor = new DateTime(2020,3,24),
                    TimeSpan = new TimeSpan(1,0,0),
                    IsCompleted = true,
                    IsOngoing = false,
                    CreationDate = new DateTime(2019,3,24,4,45,19),
                    UserId = "5925d79e-5ed1-4e19-ae1f-8ef0e4474cad",
                    RoomId = "this-is-me",
                    Password = "4XUBG"
                },
                new Videoconference
                {
                    ActivityId = 3,
                    Title = "Video to come",
                    Description = "Hy Iceland",
                    ScheduledFor = new DateTime(2020,10,9),
                    TimeSpan = new TimeSpan(5,0,0),
                    IsCompleted = false,
                    IsOngoing = false,
                    CreationDate = new DateTime(2018,3,24,4,45,19),
                    UserId = "5925d79e-5ed1-4e19-ae1f-8ef0e4474cad",
                    RoomId = "to-come",
                    Password = "YEAH"
                },
                new Videoconference
                {
                    ActivityId = 4,
                    Title = "Without Password",
                    Description = "You",
                    ScheduledFor = DateTime.Now,
                    TimeSpan = new TimeSpan(0,30,0),
                    IsCompleted = false,
                    IsOngoing = true,
                    CreationDate = new DateTime(2020,3,24,4,45,19),
                    UserId = "5925d79e-5ed1-4e19-ae1f-8ef0e4474cad",
                    RoomId = "without-password"
                }
            };
        }

        #endregion Seed
    }
}

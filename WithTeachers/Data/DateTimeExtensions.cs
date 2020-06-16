using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace WithTeachers.Data
{
    public static class DateTimeExtensions
    {
        public static DateTime StartOfWeek(this DateTime dt, DayOfWeek day)
        {
            DayOfWeek Day = dt.DayOfWeek;
            int Days;

            // This is to issue the fact that in C# a week begin on Sunday
            if (Day == DayOfWeek.Sunday)
            {
                Days = Day - DayOfWeek.Sunday;
                DateTime WeekStartDate = dt.AddDays(-Days);
                if (day == DayOfWeek.Monday) return WeekStartDate.AddDays(-6);
                else if (day == DayOfWeek.Tuesday) return WeekStartDate.AddDays(-5);
                else if (day == DayOfWeek.Wednesday) return WeekStartDate.AddDays(-4);
                else if (day == DayOfWeek.Thursday) return WeekStartDate.AddDays(-3);
                else if (day == DayOfWeek.Friday) return WeekStartDate.AddDays(-2);
                else if (day == DayOfWeek.Saturday) return WeekStartDate.AddDays(-1);
                else return WeekStartDate.AddDays(0);
            }
            else
            {
                Days = Day - DayOfWeek.Monday;
                DateTime WeekStartDate = dt.AddDays(-Days);
                if (day == DayOfWeek.Monday) return WeekStartDate.AddDays(0);
                else if (day == DayOfWeek.Tuesday) return WeekStartDate.AddDays(1);
                else if (day == DayOfWeek.Wednesday) return WeekStartDate.AddDays(2);
                else if (day == DayOfWeek.Thursday) return WeekStartDate.AddDays(3);
                else if (day == DayOfWeek.Friday) return WeekStartDate.AddDays(4);
                else if (day == DayOfWeek.Saturday) return WeekStartDate.AddDays(5);
                else return WeekStartDate.AddDays(6);
            }            
        }
    }

    public class Week : IEnumerable<DateTime>
    {
        private readonly DateTime _dt;

        public Week(DateTime dt)
        {
            _dt = dt;
        }

        public DateTime Monday { get => _dt.StartOfWeek(DayOfWeek.Monday); }
        public DateTime Tuesday { get => _dt.StartOfWeek(DayOfWeek.Tuesday); }
        public DateTime Wednesday { get => _dt.StartOfWeek(DayOfWeek.Wednesday); }
        public DateTime Thursday { get => _dt.StartOfWeek(DayOfWeek.Thursday); }
        public DateTime Friday { get => _dt.StartOfWeek(DayOfWeek.Friday); }
        public DateTime Saturday { get => _dt.StartOfWeek(DayOfWeek.Saturday); }
        public DateTime Sunday { get => _dt.StartOfWeek(DayOfWeek.Sunday); }

        public IEnumerator<DateTime> GetEnumerator()
        {
            yield return Monday;
            yield return Tuesday;
            yield return Wednesday;
            yield return Thursday;
            yield return Friday;
            yield return Saturday;
            yield return Sunday;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}

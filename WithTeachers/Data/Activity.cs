using System;
using System.ComponentModel.DataAnnotations;

namespace WithTeachers.Data
{
    public class Activity
    {
        public int ActivityId { get; set; }

        [Required(ErrorMessage = "The activity title should not be left empty.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "The activity description should not be left empty.")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [Required(ErrorMessage = "The scheduled activity date should be selected.")]
        [DataType(DataType.DateTime)]
        public DateTime ScheduledFor { get; set; }

        [DataType(DataType.Duration)]
        public TimeSpan TimeSpan { get; set; } = new TimeSpan(2, 0, 0);

        public bool Completed { get; set; } = false;

        [DataType(DataType.DateTime)]
        public DateTime CreationDate { get; set; }


        //public int VideoconferenceId { get; set; }
        //public virtual Videoconference Videoconference { get; set; }

        //public int CourseId { get; set; }
        //public virtual Course Course { get; set; }

        //public int ClassId { get; set; }
        //public virtual Class Class { get; set; }
    }
}
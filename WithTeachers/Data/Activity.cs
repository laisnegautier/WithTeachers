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

        public bool Completed { get; set; } = false;


        public virtual Videoconference Videoconference { get; set; }

        public virtual Course Course { get; set; }

        public virtual Class Class { get; set; }
    }
}
using System;
using System.ComponentModel.DataAnnotations;

namespace WithTeachers.Data
{
    public class Videoconference
    {
        public string VideoconferenceId { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }

        public bool Ongoing { get; set; }

        [DataType(DataType.Date)]
        public DateTime CreationDate { get; set; }

        public string UserId { get; set; }
        public virtual ApplicationUser User { get; set; }
    }
}
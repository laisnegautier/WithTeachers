using System.ComponentModel.DataAnnotations;

namespace WithTeachers.Data
{
    public class Videoconference
    {
        public int VideoconferenceId { get; set; }
        
        public string Slug { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }

        public bool Ongoing { get; set; }
    }
}
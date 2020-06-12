using System.ComponentModel.DataAnnotations;

namespace WithTeachers.Data
{
    public class Student
    {
        public int StudentId { get; set; }

        [Required]
        public string Lastname { get; set; }

        [Required]
        public string Firstname { get; set; }

        [DataType(DataType.MultilineText)]
        public string Comments { get; set; }

        public int ClassId { get; set; }
        public virtual Class Class { get; set; }
    }
}
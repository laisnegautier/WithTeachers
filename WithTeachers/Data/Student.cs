using System.ComponentModel.DataAnnotations;

namespace WithTeachers.Data
{
    public class Student
    {
        public int StudentId { get; set; }

        [Required(ErrorMessage = "The student last name should not be left empty")]
        public string Lastname { get; set; }

        [Required(ErrorMessage = "The student first name should not be left empty")]
        public string Firstname { get; set; }

        [DataType(DataType.MultilineText)]
        public string Comments { get; set; }

        [Required(ErrorMessage = "The student class should not be left empty")]
        public int ClassId { get; set; }
        public virtual Class Class { get; set; }
    }
}
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WithTeachers.Data.ViewModels
{
    public class ClassStudents
    {
        [ValidateComplexType]
        public Class Class { get; set; } = new Class();

        [ValidateComplexType]
        public List<Student> Students { get; set; } = new List<Student>() { new Student() };
    }
}
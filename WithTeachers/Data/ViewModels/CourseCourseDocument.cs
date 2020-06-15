using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WithTeachers.Data;
using System.ComponentModel.DataAnnotations;

namespace WithTeachers.Data.ViewModels
{
    public class CourseCourseDocument
    {
        [ValidateComplexType]
        public Course Course { get; set; } = new Course();

        [ValidateComplexType]
        public CourseDocument CourseDocument { get; set; } = new CourseDocument();
    }
}

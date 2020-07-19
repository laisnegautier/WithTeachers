using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WithTeachers.Data.ViewModels
{
    public class CourseCourseDocument
    {
        [ValidateComplexType]
        public Course Course { get; set; } = new Course();

        [ValidateComplexType]
        public List<CourseDocument> CourseDocuments { get; set; } = new List<CourseDocument>() { };
    }
}
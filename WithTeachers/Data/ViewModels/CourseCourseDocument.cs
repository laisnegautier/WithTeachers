using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WithTeachers.Data;
using System.ComponentModel.DataAnnotations;
using BlazorInputFile;

namespace WithTeachers.Data.ViewModels
{
    public class CourseCourseDocument
    {
        [ValidateComplexType]
        public Course Course { get; set; } = new Course();

        [ValidateComplexType]
        public List<CourseDocument> CourseDocuments { get; set; } = new List<CourseDocument>() { new CourseDocument() };
    }
}

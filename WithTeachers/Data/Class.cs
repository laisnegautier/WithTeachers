using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WithTeachers.Data
{
    public class Class
    {
        public int ClassId { get; set; }

        [Required(ErrorMessage = "The class name should not be left empty.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "The class year should not be left empty.")]
        public int Year { get; set; }

        public string UserId { get; set; }
        public virtual ApplicationUser User { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}

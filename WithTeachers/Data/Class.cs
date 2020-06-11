using System.ComponentModel.DataAnnotations;

namespace WithTeachers.Data
{
    public class Class
    {
        public int ClassId { get; set; }

        [Required(ErrorMessage = "The class year should not be left empty.")]
        public int Year { get; set; }
        
        public ApplicationUser User { get; set; }
    }
}
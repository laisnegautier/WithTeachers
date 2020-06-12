using System.ComponentModel.DataAnnotations;

namespace WithTeachers.Data
{
    public class Skill
    {
        public int SkillId { get; set; }

        [Required(ErrorMessage = "The skill title should not be left empty")]
        public string Title { get; set; }

        [Required(ErrorMessage = "The skill description should not be left empty")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        public virtual Course Course { get; set; }
    }
}
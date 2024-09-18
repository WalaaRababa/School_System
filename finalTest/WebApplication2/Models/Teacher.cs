using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Teacher
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int teacherId { get; set; }
        [MinLength(5)]
        [MaxLength(50)]
        public required string teacherName { get; set; }
        [Range(25, 60)]
        public int teacherAge { get; set; }
    }
}

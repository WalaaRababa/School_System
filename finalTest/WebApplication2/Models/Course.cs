using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Course
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int courseId { get; set; }
        [MinLength(5)]
        [MaxLength(50)]
        public required string courseName { get; set; }
        public int teacherId { get; set; }
        public required Teacher teacher { get; set; }
        [Range(0, 25)]
        public int roomCapacity { get; set; }
    }
}

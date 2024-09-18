using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication2.Models
{
    public class Student
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int studentId { get; set; }
        [MinLength(5)]
        [MaxLength(50)]
        public required string studentName { get; set; }
        [Range(5, 18)]
        public int studentAge { get; set; }
        public bool isActive { get; set; }
    }
}

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Enrollment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int enrollId { get; set; }
        public int studentId { get; set; }
        public required Student student { get; set; }
        public int courseId { get; set; }
        public required Course course { get; set; }
    }
}

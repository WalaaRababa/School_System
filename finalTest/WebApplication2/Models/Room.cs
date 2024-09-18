using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Room
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int roomId { get; set; }
        [MinLength(5)]
        [MaxLength(50)]
        public string roomName { get; set; }

    }
}

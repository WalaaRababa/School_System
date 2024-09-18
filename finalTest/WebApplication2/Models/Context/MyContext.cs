using Microsoft.EntityFrameworkCore;

namespace WebApplication2.Models.Context
{
    public class MyContext: DbContext
    {
        public MyContext( DbContextOptions<MyContext> options):base(options) { }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Room> Rooms { get; set; }
    }
}

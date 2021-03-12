using ContosoUniversity.Models;
using Microsoft.EntityFrameworkCore;

//tinfo200:[2021-03-12-gtash3-dykstra1] - Creating the School Context, which contains 3 entities(Courses,Enrollmments,Students)
//          These entities utilize get/set for the values pertaining their titles (Student's enrolled in the course, enrollment
//              count, courses being utilized).
namespace ContosoUniversity.Data
{
    public class SchoolContext : DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {
        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Student> Students { get; set; }

        //tinfo200:[2021-03-12-gtash3-dykstra1] - This override method forces the framework to use these strings for the table
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().ToTable("Course");
            modelBuilder.Entity<Enrollment>().ToTable("Enrollment");
            modelBuilder.Entity<Student>().ToTable("Student");
        }
    }
}
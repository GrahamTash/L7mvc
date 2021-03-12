using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//tinfo200:[2021-03-12-gtash3-dykstra1] - Using get/set for the values of the Entity framework for student ID's, their first, 
//      middle and last name, and includes the enrollment date for class Student.
namespace ContosoUniversity.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

//tinfo200:[2021-03-12-gtash3-dykstra1] - Using get/set for the values of the Entity framework for the CourseID,
//         Title and Credits. These complete the task of the require data for the Course class.

namespace ContosoUniversity.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseID { get; set; }
        public string Title { get; set; }

        public int Credits { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }

    }
}

namespace ContosoUniversity.Models
{
    //tinfo200:[2021-03-12-gtash3-dykstra1] - The enum sets the standard for what grade a student can receieve
    //    Using get/set for the values of the Entity framework for finding StudentID, CourseID, EnrollmentID,
    //      the grade the student receieves as well as the identity of the students themselves.
    public enum Grade
    {
        A, B, C, D, E, F
    }
    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }

        public Grade? Grade { get; set; }

        public Student Student { get; set; }

    }
}
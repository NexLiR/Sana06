using System;

namespace ClassLibrary
{
    public class Student : Applicant
    {
        protected byte Course { get; set; }
        protected string Group { get; set; }
        protected string Faculty { get; set; }
        protected string University { get; set; }

        public Student() : base()
        {
            Course = 0;
            Group = "Unknown";
            Faculty = "Unknown";
            University = "Unknown";
        }
        public Student(string firstName, string lastName, DateTime dateOfBirth, ZNO sertificateZNO, double avgScoreInEducationDocument, string nameOfTheEduacationalInstitution, byte course, string group, string faculty, string university)
            : base(firstName, lastName, dateOfBirth, sertificateZNO, avgScoreInEducationDocument, nameOfTheEduacationalInstitution)
        {
            Course = course;
            Group = group;
            Faculty = faculty;
            University = university;
        }
        public Student(Student student)
            : base(student.FirstName, student.LastName, student.DateOfBirth, student.SertificateZNO, student.AverageScoreInEducationDocument, student.NameOfTheFirstEducationalInstitution)
        {
            Course = student.Course;
            Group = student.Group;
            Faculty = student.Faculty;
            University = student.University;
        }
        
        public override string ShowInfo()
        {
            return base.ShowInfo() + $"\nCourse: {Course}\nGroup: {Group}\nFaculty: {Faculty}\nUniversity: {University}";
        }
    }
}

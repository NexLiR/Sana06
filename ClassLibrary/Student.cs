using System;

namespace ClassLibrary
{
    public class Student : Applicant
    {
        protected byte _course;
        protected string _group;
        protected string _faculty;
        protected string _university;
        public byte Course
        {
            get
            {
                return _course;
            }
            set
            {
                if (value < 0 || value > 6)
                {
                    throw new Exception("Course must be in range from 1 to 6");
                }
                else _course = value;
            }
        }
        public string Group
        {
            get
            {
                return _group;
            }
            set
            {
                if (value.Length < 1)
                {
                    throw new Exception("Group number must be higher than 0");
                }
                else _group = value;
            }
        }
        public string Faculty
        {
            get
            {
                return _faculty;
            }
            set
            {
                if (value.Length < 1)
                {
                    throw new Exception("Faculty name can not be empty!");
                }
                else _faculty = value;
            }
        }
        public string University
        {
            get
            {
                return _university;
            }
            set
            {
                if (value.Length < 1)
                {
                    throw new Exception("University name can not be empty!");
                }
                else _university = value;
            }
        }

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

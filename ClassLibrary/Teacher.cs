using System;

namespace ClassLibrary
{
    public class Teacher : Person
    {
        public string Situation { get; set; }
        public string Department { get; set; }
        public string HigherEducationInstitution { get; set; }

        public Teacher() : base()
        {
            Situation = "Unknown";
            Department = "Unknown";
            HigherEducationInstitution = "Unknown";
        }
        public Teacher(string firstName, string lastName, DateTime dateOfBirth, string situation, string department, string higherEducationInstitution)
            : base(firstName, lastName, dateOfBirth)
        {
            Situation = situation;
            Department = department;
            HigherEducationInstitution = higherEducationInstitution;
        }
        public Teacher(Teacher teacher)
            : base(teacher.FirstName, teacher.LastName, teacher.DateOfBirth)
        {
            Situation = teacher.Situation;
            Department = teacher.Department;
            HigherEducationInstitution = teacher.HigherEducationInstitution;
        }
        public override string ShowInfo()
        {
            return base.ShowInfo() + $"\nSituation: {Situation}\nDepartment: {Department}\nHigher education institution: {HigherEducationInstitution}";
        }
    }
}
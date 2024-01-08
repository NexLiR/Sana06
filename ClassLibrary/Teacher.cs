using System;

namespace ClassLibrary
{
    public class Teacher : Person
    {
        protected string _situation;
        protected string _department;
        protected string _higherEducationInstitution;
        public string Situation
        {
            get 
            { 
                return _situation; 
            }
            set
            {
                if(value.Length < 0)
                {
                    throw new Exception("Situation cannot be empty");
                }
                else _situation = value; 
            }
        }
        public string Department
        {
            get 
            {
                return _department;
            }
            set
            {
                if(value.Length < 0)
                {
                    throw new Exception("Department cannot be empty");
                }
                else _department = value;
            }
        }
        public string HigherEducationInstitution
        {
            get
            {
                return _higherEducationInstitution;
            }
            set
            {
                if(value.Length < 0)
                {
                    throw new Exception("Higher education institution cannot be empty");
                }
                else _higherEducationInstitution = value;
            }
        }

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
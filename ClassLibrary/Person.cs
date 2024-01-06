using System;

namespace ClassLibrary
{
    public class Person
    {
        protected string FirstName;
        protected string LastName;
        protected DateTime DateOfBirth;
        public Person()
        {
            FirstName = "Undefinded";
            LastName = "Undefinded";
            DateOfBirth = new DateTime(1901, 1, 1);
        }
        public Person(string firstName, string lastName, DateTime dateOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
        }
        public Person(Person person)
        {
            FirstName = person.FirstName;
            LastName = person.LastName;
            DateOfBirth = person.DateOfBirth;
        }
        public string GetFirstName()
        {
            return FirstName;
        }
        public string GetLastName()
        {
            return LastName;
        }
        public DateTime GetDateOfBirth()
        {
            return DateOfBirth;
        }
        public void SetFirstName(string firstName)
        {
            if (firstName.Length < 1)
            {
                throw new Exception("First name can not be empty!");
            }
            else FirstName = firstName;
        }
        public void SetLastName(string lastName)
        {
            if (lastName.Length < 1)
            {
                throw new Exception("Last name can not be empty!");
            }
            else LastName = lastName;
        }
        public void SetDateOfBirth(DateTime dateOfBirth)
        {
            if (dateOfBirth > DateTime.Now)
            {
                throw new Exception("Date of birth can not be in the future!");
            }
            else DateOfBirth = dateOfBirth;
        }
        public virtual string ShowInfo()
        { 
            return $"First name: {FirstName}\nLast name: {LastName}\nDate of birth: {DateOfBirth.Day:00}/{DateOfBirth.Month:00}/{DateOfBirth.Year}";
        }
    }
}


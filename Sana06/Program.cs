using System;
using ClassLibrary;
static class Program
{
    static void Main()
    {
        Person[] people = new Person[5];
        people[0] = new Person("Oleg", "Redka", new DateTime(2006, 9, 27));
        people[1] = new Applicant("Oleg", "Redka", new DateTime(2006, 9, 27), new ZNO("Math", 152, "Ukrainian", 157, "History", 163), 9.7, "School 28");
        people[2] = new Student("Oleg", "Redka", new DateTime(2006, 9, 27), new ZNO("Math", 152, "Ukrainian", 157, "History", 163), 9.7, "School 28", 1, "IPZ-23-2", "FICT", "ZPSU");
        people[3] = new Teacher("Oleksii", "Chizhmotrya", new DateTime(1976, 5, 14), "Senior Lecturer", "Department of Software Engineering", "Zhytomyr Polytechnic State University");
        people[4] = new LibraryUser("Oleg", "Redka", new DateTime(2006, 9, 27), 4863753, new DateTime(2024, 1, 6), 24.50f);

        for (int i = 0; i < people.Length; i++) 
        {
            Console.WriteLine(people[i].ShowInfo());
            Console.WriteLine();
        }
    }
}
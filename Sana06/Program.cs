using System;
using ClassLibrary;
static class Program
{
    static void Main()
    {
        DateTime date = new DateTime(2006, 9, 27);
        Person person = new Person("Oleg", "Redka", date);
        Console.WriteLine(person.ShowInfo());
        Console.WriteLine();
        ZNO zno = new ZNO("Math", 152, "Ukrainian", 157, "History", 163);
        Applicant applicant = new Applicant("Oleg", "Redka", date, zno, 9.7, "School 28");
        Console.WriteLine(applicant.ShowInfo());
        Console.WriteLine();
        Student student = new Student("Oleg", "Redka", date, zno, 9.7, "School 28", 1, "IPZ-23-2", "FICT", "ZPSU");
        Console.WriteLine(student.ShowInfo());
        Console.WriteLine();
        DateTime date1 = new DateTime(1976, 5, 14);
        Teacher teacher = new Teacher("Oleksii", "Chizhmotrya", date1, "Senior Lecturer", "Department of Software Engineering", "Zhytomyr Polytechnic State University");
        Console.WriteLine(teacher.ShowInfo());
        Console.WriteLine();
        DateTime date2 = new DateTime(2024, 1, 6);
        LibraryUser libraryUser = new LibraryUser("Oleg", "Redka", date, 4863753, date2, 24.50f);
        Console.WriteLine(libraryUser.ShowInfo());
    }
}
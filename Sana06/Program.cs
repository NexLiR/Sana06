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
    }
}
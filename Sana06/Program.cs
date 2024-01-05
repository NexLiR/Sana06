using System;
using ClassLibrary;
static class Program
{
    static void Main()
    {
        DateTime date = new DateTime(2006, 9, 27);
        Person person = new Person("Oleg", "Redka", date);
        Console.WriteLine(person.ShowInfo());
    }
}
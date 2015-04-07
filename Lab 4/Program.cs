using System;

namespace Lab4
{
    class Program
    {
        ///////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////

        static void Main(string[] args)
        {
            AverageAge averageAge = new AverageAge();
            averageAge.AddPerson(Person.Create("Person #1"));
            averageAge.AddPerson(Person.Create("Person #2"));
            averageAge.AddPerson(Person.Create("Person #3"));
            Console.WriteLine("Average Age: " + averageAge.Get());
            Console.ReadKey();
        }

        ///////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////
    }
}
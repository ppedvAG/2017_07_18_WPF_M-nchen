using System;
using System.Collections.Generic;
using System.Linq;

namespace DelegatesInPraxis
{
    public delegate bool MyDelegate(Employee employee);
    // Action           -> void
    // Predicate        -> bool
    // Func
        
    class Program
    {
        static void Main(string[] args)
        {
            var employees = GetData();

            //MyDelegate del = new MyDelegate(Bedingung);
            //Func<Employee, bool> del = new Func<Employee, bool>(Bedingung);
            //var del = new Func<Employee, bool>(Bedingung);
            //Func<Employee, bool> del = Bedingung;
            //var query = Abfrage(employees, del);

            //var query = Abfrage(employees, Bedingung);

            //var query = Abfrage(employees, delegate(Employee e)
            //{
            //    return e.Experience < 10;
            //});

            //var query = Abfrage(employees, (Employee e) =>
            //{
            //    return e.Experience < 10;
            //});

            //var query = Abfrage(employees, (e) =>
            //{
            //    return e.Experience < 10;
            //});

            var query = Abfrage(employees, e => e.Experience < 10);
            var linqQuery = employees.Where(Bedingung).ToList();


            linqQuery.ForEach(Console.WriteLine);

            foreach (var e in query)
                Console.WriteLine($"Id: {e.Id} - {e.Name, 10} - {e.Experience}");

            Console.ReadKey();
        }

        private static bool Bedingung(Employee e)
        {
            return e.Name.StartsWith("A");
        }

        private static IEnumerable<Employee> Abfrage(IEnumerable<Employee> employees, Func<Employee, bool> predicate)
        {
            foreach (var e in employees)
                if (predicate(e))
                    yield return e;
        }

        private static IEnumerable<Employee> GetData()
        {
            return new List<Employee>
            {
                new Employee { Id = 1, Name = "Hans", Experience = 5 },
                new Employee { Id = 2, Name = "Lisa", Experience = 3 },
                new Employee { Id = 3, Name = "Maria", Experience = 6 },
                new Employee { Id = 4, Name = "Anna", Experience = 10 },
                new Employee { Id = 5, Name = "Thomas", Experience = 14 },
                new Employee { Id = 6, Name = "Stanislaus", Experience = 8 },
                new Employee { Id = 7, Name = "Luis", Experience = 2 },
                new Employee { Id = 8, Name = "Andreas", Experience = 12 },
                new Employee { Id = 9, Name = "Herbert", Experience = 14 },
            };
        }
    }
}

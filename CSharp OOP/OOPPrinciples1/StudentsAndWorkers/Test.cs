//Problem 2. Students and workers
//Define abstract class Human with first name and last name. 
//Define new class Student which is derived from Human and has new field – grade. 
//Define class Worker derived from Human with new property WeekSalary and WorkHoursPerDay and method MoneyPerHour() 
//that returns money earned by hour by the worker. Define the proper constructors and properties for this hierarchy.
//Initialize a list of 10 students and sort them by grade in ascending order (use LINQ or OrderBy() extension method).
//Initialize a list of 10 workers and sort them by money per hour in descending order.
//Merge the lists and sort them by first name and last name.

namespace StudentsAndWorkers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class Test
    {
        static void Main()
        {
            var allStudents = InitializeStudents();
            var allWorkers = InitializeWorkers();

            var sortedStudents = SortStudentsByGrade(allStudents);
            Console.WriteLine("Students sorted by their grade: ");
            PrintResult(sortedStudents);

            Console.WriteLine();

            var sortedWorkers = SortWorkersByMPHDescending(allWorkers);
            Console.WriteLine("Workers sorted by money per hour earned: ");
            PrintResult(sortedWorkers);

            Console.WriteLine();

            List<Human> mergedList = MergeTwoLists(sortedStudents, sortedWorkers);
            List<Human> orderedHumans = OrderHumansByFirstAndLasrName(mergedList);
            Console.WriteLine("Students and workers sorted by their first and last names: ");
            PrintHumans(orderedHumans);
        }

        private static void PrintResult<T>(IEnumerable<T> collection)
        {
            foreach (var item in collection)
            {
                Console.Write("- {0}", item);
            }
        }

        private static void PrintHumans(IEnumerable<Human> orderedHumans)
        {
            foreach (var human in orderedHumans)
            {
                Console.WriteLine("- {0} {1}", human.FirstName, human.LastName);
            }
        }

        private static List<Human> OrderHumansByFirstAndLasrName(IEnumerable<Human> mergedList)
        {
            var result = mergedList.OrderBy(x => x.FirstName)
                                   .ThenBy(x => x.LastName)
                                   .ToList();

            return result;
        }

        private static List<Human> MergeTwoLists(IEnumerable<Student> sortedStudents, IEnumerable<Worker> sortedWorkers)
        {
            List<Human> result = new List<Human>();

            result.AddRange(sortedStudents);
            result.AddRange(sortedWorkers);

            return result;
        }

        private static List<Worker> SortWorkersByMPHDescending(IEnumerable<Worker> allWorkers)
        {
            var result = allWorkers.OrderByDescending(x => x.CalculateMoneyPerHour())
                                   .ToList();

            return result;
        }

        private static List<Student> SortStudentsByGrade(IEnumerable<Student> allStudents)
        {
            var result = allStudents.OrderBy(x => x.Grade)
                                    .ToList();

            return result;
        }

        private static List<Worker> InitializeWorkers()
        {
            List<Worker> allWorkers = new List<Worker>();

            allWorkers.Add(new Worker("Ivan", "Ivanov", 400, 8));
            allWorkers.Add(new Worker("Dragan", "Draganov", 400, 8));
            allWorkers.Add(new Worker("Petkan", "Petkanov", 500, 6));
            allWorkers.Add(new Worker("Stamat", "Stamatov", 450, 9));
            allWorkers.Add(new Worker("Koicho", "Koichev", 800, 12));
            allWorkers.Add(new Worker("Peicho", "Peichev", 500, 8));
            allWorkers.Add(new Worker("Georgi", "Georgiev", 100, 11));
            allWorkers.Add(new Worker("Penka", "Penkova", 300, 12));
            allWorkers.Add(new Worker("Valq", "Valeva", 450, 10));
            allWorkers.Add(new Worker("Hanko", "Brat", 330, 3));

            return allWorkers;

        }

        private static List<Student> InitializeStudents()
        {
            List<Student> allStudents = new List<Student>();

            allStudents.Add(new Student("Student", "Studentov", 9));
            allStudents.Add(new Student("Ivan", "Petrov", 8));
            allStudents.Add(new Student("Petyr", "Ivanov", 7));
            allStudents.Add(new Student("Eratosten", "Ivanov", 6));
            allStudents.Add(new Student("Galileo", "Galileev", 5));
            allStudents.Add(new Student("Moisei", "Strahilov", 5));
            allStudents.Add(new Student("Petkan", "petkanov", 6));
            allStudents.Add(new Student("Robinzon", "Kruzo", 12));
            allStudents.Add(new Student("Strahil", "Bezstrashnev", 10));
            allStudents.Add(new Student("Kamen", "Ognqnov", 12));

            return allStudents;
        }
    }
}

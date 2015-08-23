//Problem 18. Grouped by GroupNumber
//Create a program that extracts all students grouped by GroupNumber and then prints them to the console.
//Use LINQ.
//Problem 19. Grouped by GroupName extensions
//Rewrite the previous using extension methods.
namespace Grouped
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Students; //Reference to '09. Students' added!

    public class Grouped
    {
        public static void Main()
        {
            List<Student> students = new List<Student>()
            {
                new Student("Toshko", "Toshkov", "123456", "02 262626", "toshko@mail.bg", 1, new List<int> { 4, 4, 5, 4, 6 }),
                new Student("Simeon", "Aleksandrov", "987654", "0888111222", "simeon@abv.bg", 2, new List<int> { 3, 4, 5, 6, 4 }),
                new Student("Koicho", "Koiev", "147258", "0899333444", "koicho@mail.bg", 1, new List<int> { 5, 6, 3, 5, 5 }),
                new Student("Petko", "Petkov", "369258", "0877999888", "petko@gmail.com", 2, new List<int> { 2, 2, 3, 3, 4 }),
                new Student("Radina", "Radinova", "852258", "0888555666", "radina@gmail.com", 1, new List<int> { 6, 6, 6, 6, 5 }),
                new Student("Petka", "Petkova", "123987", "+3592 172839", "petka@abv.bg", 2, new List<int> { 3, 4, 2, 2, 4 }),
                new Student("Traqna", "Traqnova", "261548", "+35958 562389", "traqna@yahoo.com", 1, new List<int>{5, 5, 2, 6, 4})
            };

            Console.WriteLine("Students grouped by GroupNumber (LINQ):\n");

            var groupedStudentsLINQ = from student in students
                                      orderby student.GroupNumber
                                      select (string.Format("{0} {1}, GroupNumber: {2}", student.FirstName, student.LastName, student.GroupNumber));

            Console.WriteLine(String.Join(Environment.NewLine, groupedStudentsLINQ));


            Console.WriteLine("\n\nStudents grouped by GroupNumber (extention):\n");

            var groupedStudentsExt = students
                .OrderBy(x => x.GroupNumber)
                .Select(x => string.Format("{0} {1}, GroupNumber: {2}", x.FirstName, x.LastName, x.GroupNumber));

            Console.WriteLine(String.Join(Environment.NewLine, groupedStudentsExt));
            Console.WriteLine();
        }
    }
}

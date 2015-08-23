//Problem 1. School classes
//We are given a school. In the school there are classes of students. Each class has a set of teachers. 
//Each teacher teaches a set of disciplines. Students have name and unique class number. Classes have unique text identifier. 
//Teachers have name. Disciplines have name, number of lectures and number of exercises. Both teachers and students are people. 
//Students, classes, teachers and disciplines could have optional comments (free text block).
//Your task is to identify the classes (in terms of OOP) and their attributes and operations,
//encapsulate their fields, define the class hierarchy and create a class diagram with Visual Studio.
namespace SchoolClasses
{
    using System;
    class Test
    {
        static void Main()
        {
            School school = new School("PMG");

            Class firstClass = new Class('A');
            Class secondClass = new Class('B');
            Class thirdClass = new Class('V');

            Teacher firstTeacher = new Teacher("Janeta", "super!");
            Teacher secondTeacher = new Teacher("Gonzo", "stranen");

            Student firstStudent = new Student("Ivan", "111213", "razdraznitelen");
            Student secondStudent = new Student("Dragan", "111214", "otkachen");
            Student thirdStudent = new Student("Petkan", "111215");
            Student forthStudent = new Student("Stamat", "111216", "uchenolubiv");

            Discipline math = new Discipline("Math", 5, 10);
            Discipline history = new Discipline("History", 2, 4);
            Discipline physics = new Discipline("Physics", 4, 8);
            Discipline english = new Discipline("English", 2, 4);

            school.AddClass(firstClass);
            school.AddClass(secondClass);
            school.AddClass(thirdClass);

            firstTeacher.AddDiscipline(math);
            firstTeacher.AddDiscipline(english);
            secondTeacher.AddDiscipline(history);
            secondTeacher.AddDiscipline(physics);

            firstClass.AddStudentToAClass(firstStudent);
            firstClass.AddStudentToAClass(secondStudent);
            secondClass.AddStudentToAClass(thirdStudent);
            thirdClass.AddStudentToAClass(forthStudent);

            firstClass.AddTeacherToAClass(firstTeacher);
            firstClass.AddTeacherToAClass(secondTeacher);
            secondClass.AddTeacherToAClass(firstTeacher);
            thirdClass.AddTeacherToAClass(secondTeacher);

            Console.WriteLine("School named {0} has {1} classes: \n\n {2} {3} {4}", school.Name, school.Classes.Count, firstClass, secondClass, thirdClass);
        }
    }
}

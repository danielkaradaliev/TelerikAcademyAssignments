//Problem 1. Student class
//Define a class Student, which contains data about a student – first, middle and last name, SSN, permanent address, mobile phone e-mail, course,
//specialty, university, faculty. Use an enumeration for the specialties, universities and faculties.
//Override the standard methods, inherited by System.Object: Equals(), ToString(), GetHashCode() and operators == and !=.
//Problem 2. IClonable
//Add implementations of the ICloneable interface. The Clone() method should deeply copy all object's fields into a new object of type Student.
//Problem 3. IComparable
//Implement the IComparable<Student> interface to compare students by names (as first criteria, in lexicographic order)
//and by social security number (as second criteria, in increasing order).
namespace StudentClass
{
    using System;

    public class Test
    {
        public static void Main()
        {
            Student firstStudent = new Student("Stamat", "Stamatov", "Stamatev", "1112131415", "StudentskiCity", "0888112233", "stamatisthebest@abv.bg",
                                               1, Specialty.Literature, University.SofiaUniversity, Faculty.Literature);

            Console.WriteLine("First student:\n\n" + firstStudent);
            Console.WriteLine("First student hash code: {0}\n", firstStudent.GetHashCode());

            Student secondStudent = firstStudent;
            Console.WriteLine("Second student:\n\n" + secondStudent);

            Console.WriteLine("DoesReferenceEquals(firstStudent, secondStudent)? : {0}\n", ReferenceEquals(firstStudent, secondStudent));

            Student thirdStudent = (Student)secondStudent.Clone();
            Console.WriteLine("Third student (cloned second student):\n\n" + thirdStudent);

            Console.WriteLine("DoesReferenceEquals(thirdStudent, secondStudent)? : {0}\n", ReferenceEquals(thirdStudent, secondStudent));

            secondStudent = new Student("Oh", "Kotio", "Kotev", "12455623125", "Address", "0888765432", "kotkov@abv.com",
                                        2, Specialty.Chemistry, University.SofiaUniversity, Faculty.Physics);

            Console.WriteLine("Second student (changed):\n\n" + secondStudent);
            Console.WriteLine("Third student:\n\n" + thirdStudent);

            Console.WriteLine("firstStudent != secondStudent : {0}", firstStudent != secondStudent);
            Console.WriteLine("firstStudent.Equals(secondStudent)) : {0}", firstStudent.Equals(secondStudent));
            Console.WriteLine("firstStudent.CompareTo(secondStudent) : {0}\n", firstStudent.CompareTo(secondStudent));
        }
    }
}
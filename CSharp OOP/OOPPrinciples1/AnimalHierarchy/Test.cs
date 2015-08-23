//Problem 3. Animal hierarchy
//Create a hierarchy Dog, Frog, Cat, Kitten, Tomcat and define useful constructors and methods. 
//Dogs, frogs and cats are Animals. All animals can produce sound (specified by the ISound interface). 
//Kittens and tomcats are cats. All animals are described by age, name and sex. Kittens can be only female and tomcats can be only male. 
//Each animal produces a specific sound.
//Create arrays of different kinds of animals and calculate the average age of each kind of animal using a static method (you may use LINQ).
namespace AnimalHierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Test
    {
        static void Main()
        {
            Dog[] dogsArray = {
                                  new Dog(8, "Balkan", Gender.Male),
                                  new Dog(9, "Sharo", Gender.Male),
                                  new Dog(2, "Stamat", Gender.Male),
                                  new Dog(4, "Ivane", Gender.Male)
                              };

            Cat[] catsArray = {
                                  new Kitten(2, "Maac"),
                                  new Kitten(4, "Pisi"),
                                  new Tomcat(3, "Koti"),
                                  new Tomcat(6, "Kotaraka")
                              };

            Frog[] frogsArray = {
                                    new Frog(1, "KvartetKvazimodo", Gender.Male),
                                    new Frog(2, "Petra", Gender.Female),
                                };

            List<Animal> allAnimals = new List<Animal>();
            allAnimals.AddRange(dogsArray);
            allAnimals.AddRange(catsArray);
            allAnimals.AddRange(frogsArray);

            Console.WriteLine("Average age of dogs: {0} years.", CalculateAverageYears(dogsArray));
            Console.WriteLine("Average age of cats: {0} years.", CalculateAverageYears(catsArray));
            Console.WriteLine("Average age of frogs: {0} years.", CalculateAverageYears(frogsArray));

            Console.WriteLine();

            foreach (var item in allAnimals)
            {
                Console.WriteLine(item.MakeSound());
            }
        }

        private static double CalculateAverageYears(Animal[] collection)
        {
            double averageAge = collection.Average(x => x.Age);

            return Math.Round(averageAge, 2);
        }
    }
}

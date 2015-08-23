//Problem 7. Timer
//Using delegates write a class Timer that can execute certain method at each t seconds.
//Problem 8.* Events
//Read in MSDN about the keyword event in C# and how to publish events.
//Re-implement the above using .NET events and following the best practices.
namespace Timer
{
    using System;

    public class Test
    {
        private static void PrintMethod()
        {
            Console.WriteLine("Some things executing...");
        }

        public static void Main()
        {
            Timer timer = new Timer(300, 8);
            timer.TDelegate += PrintMethod;

            Console.WriteLine("Start Test");
            timer.Execute();
            Console.WriteLine("Finish Test");
        }
    }
}

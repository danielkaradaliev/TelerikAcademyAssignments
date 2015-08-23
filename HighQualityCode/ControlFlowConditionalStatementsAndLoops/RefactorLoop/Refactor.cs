namespace RefactorLoop
{
    using System;

    public class Refactor
    {
        public static void Main()
        {
            int[] array = CreateArray();
            int breakingValue = 20;
            for (int i = 0; i < 100; i++)
            {
                if (i % 10 == 0 && array[i] == breakingValue)
                {
                    Console.WriteLine("Value Found!");
                    break;
                }
                else
                {
                    Console.WriteLine(array[i]);
                }
            }
        }

        public static int[] CreateArray()
        {
            int[] array = new int[100];

            for (int i = 0; i < 100; i++)
            {
                array[i] = i;
            }

            return array;
        }
    }
}

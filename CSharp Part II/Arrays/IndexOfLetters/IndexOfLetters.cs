//Problem 12. Index of letters
//Write a program that creates an array containing all letters from the alphabet (A-Z).
//Read a word from the console and print the index of each of its letters in the array.
using System;
class IndexOfLetters
{
    static void Main()
    {
        int j = 65;                             //For Capital Letters only
        int[] arr = new int[27];
        arr[0] = 0;
        for (int i = 1; i < 27; i++)            //A = 1 , B = 2. C = 3, etc.
        {
            arr[i] = j;
            j++;
        }
        string input = Console.ReadLine();      //Input Capital Letters!
        string output = "";
        for (int k = 0; k < input.Length; k++)
        {
            for (int m = 1; m < 27; m++)
            {
                if (input[k] == arr[m])
                {
                    output += m + ",";
                }
            }
        }
        for (int k = 0; k < output.Length - 1; k++)
        {
            Console.Write(output[k]);
        }
        Console.WriteLine();
    }
}
//Problem 21. Letters count
//Write a program that reads a string from the console and prints all different letters in the string along with information how many times each letter is found.
using System;
class LettersCount
    {
        static void Main()
        {
            Console.Write("Enter some text: ");
            string input = Console.ReadLine();
            char[] letters = new char[100000]; //I could not figure out exacly how long it should be
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsLetter(input[i]))
                {
                    letters[input[i]]++;
                }
            }
            for (int i = 0; i < letters.Length; i++)
            {
                if (char.IsLetter((char)i) && letters[i] > 0)
                {
                    Console.WriteLine("{0} is met {1} times", (char)i, (int)letters[i]);
                }
            }
        }
    }